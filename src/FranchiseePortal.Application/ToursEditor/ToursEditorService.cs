using Abp.Application.Features;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using FranchiseePortal.Extensions;
using FranchiseePortal.Features;
using FranchiseePortal.LeadsEditor.Dtos;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Model;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.ToursEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace FranchiseePortal.ToursEditor
{
    [RequiresFeature(AppFeatures.TourFeature)]
    public class ToursEditorService : FranchiseePortalAppServiceBase, IToursEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly IToursApi _toursClient;
        private readonly IGuidesApi _guidesClient;
        private readonly ISchoolParentLeadsApi _leadsClient;
        private readonly ISchoolsApi _schoolsApi;
        private readonly ISchedulesApi _schedulesApi;
        #endregion

        //========================================================================================

        #region Constructor
        public ToursEditorService(
            IToursApi toursClient,
            ISchoolParentLeadsApi leadsClient,
            ISchoolsApi schoolsApi,
            IGuidesApi guidesApi,
            ISchedulesApi schedulesApi)
        {
            _toursClient = toursClient;
            _leadsClient = leadsClient;
            _schoolsApi = schoolsApi;
            _guidesClient = guidesApi;
            _schedulesApi = schedulesApi;
        }

        #endregion

        //========================================================================================

        #region Endpoints

        /// <summary>
        /// Gets school tours
        /// </summary>
        /// <param name="input">Tours parameters that can be searched</param>
        /// <param name="cancellationToken"></param>
        /// <returns>School tours</returns>
        /// <response code="200">Returns school tours</response>
        /// <response code="400">schoolId is invalid</response>
        /// <response code="404">School not found</response>
        [HttpGet]
        public async Task<PagedResultDto<TourItemDto>> FindTours(
            FindToursInput input,
            CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(input.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            //need to know source for sorting to send appropiate column names to each Tours or Leads API
            var school = await _schoolsApi.ApiV1SchoolsIdGetAsync(
                input.SchoolId,
                cancellationToken: cancellationToken);

            // Fetch tours, filtered, sorted, and paged for all criteria
            var toursSearchResult = await _toursClient.ApiV1SchoolsSchoolCrmIdToursGetAsync(
                schoolCrmId: input.SchoolId,
                statuses: input.Statuses,
                startDateTime: input.StartDateTime,
                endDateTime: input.EndDateTime,
                types: input.Types,
                guideIds: input.GuideIds,
                leadName: input.LeadName,
                leadMaximumPreferredStartDate: input.LeadEndDate,
                leadMinimumPreferredStartDate: input.LeadStartDate,
                leadProgramsOfInterest: input.ProgramsOfInterest,
                page: input.Page,
                pageSize: input.PageSize,
                sort: GetTourSort(input),
                sortDirection: input.GetSortDirection(),
                cancellationToken: cancellationToken);

            // Fetch leads
            var leads = await _leadsClient.ApiV1SchoolLeadsQueryByIdsPostAsync(
                toursSearchResult.Items.Select(x => x.LeadId.ToString()).ToList(),
                cancellationToken: cancellationToken);

            // Join tours and leads on lead ID and map to TourDto
            var dtos = toursSearchResult
                .Items
                .Join(
                    leads,
                    outer => outer.LeadId,
                    inner => inner.SchoolParentLeadId,
                    CreateTourItemDto)
                .ToList();

            var result = new PagedResultDto<TourItemDto>(toursSearchResult.Total, dtos);
            return result;
        }

        [HttpGet]
        public async Task<TourItemDto> GetTour(string schoolId, string id)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            // Fetch tour and lead data
            var tour = await _toursClient.ApiV1SchoolsSchoolCrmIdToursIdGetAsync(schoolId, id);
            var lead = await _leadsClient.ApiV1SchoolLeadsIdGetAsync(tour.LeadId);

            // map to TourDto
            var result = CreateTourItemDto(tour, lead);

            return result;
        }

        [HttpGet]
        public async Task<List<TourGuideDto>> GetSchoolGuides(string schoolId)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            var result = await _guidesClient.ApiV1SchoolsSchoolCrmIdGuidesGetAsync(schoolId);

            return result;
        }

        public async Task CreateTour(CreateTourInput tourDto)
        {
            if (!await AuthorizeForSchoolAsync(tourDto.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var apiInputDto = CreateTourInput.CreateApiTourInputDto(tourDto);

            await _toursClient.ApiV1SchoolsSchoolCrmIdToursPostAsync(
                tourDto.SchoolId,
                apiInputDto);

            //Update lead
            await UpdateLead(tourDto.Lead.GuidId, CreateLeadInput.CreateLeadUpdateRequest(tourDto.Lead));
        }

        public async Task UpdateTour(string id, UpdateTourInput input)
        {
            if (!await AuthorizeForSchoolAsync(input.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            //Update lead
            await UpdateLead(input.Lead.GuidId, UpdateLeadInput.CreateLeadUpdateRequest(input.Lead));

            var tour = await _toursClient.ApiV1SchoolsSchoolCrmIdToursIdGetAsync(input.SchoolId, id);

            var apiInput = ObjectMapper.Map<TourInputDto>(tour);

            UpdateTourInput.UpdateTourFields(input, apiInput);

            //Update Tour
            await _toursClient.ApiV1SchoolsSchoolCrmIdToursIdPutAsync(input.SchoolId, id, apiInput);
        }

        private async Task UpdateLead(Guid guidId, ApiV1SchoolLeadsIdTourPutRequest leadUpdate)
        {
            await _leadsClient.ApiV1SchoolLeadsIdTourPutAsync(guidId, leadUpdate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="schoolId"></param>
        /// <param name="startDate">Start UTC date</param>
        /// <param name="endDate">End UTC date</param>
        /// <returns></returns>
        /// <exception cref="AbpAuthorizationException"></exception>
        public async Task<IEnumerable<ScheduleDto>> GetSchedules(
            string schoolId,
            DateTime startDate,
            DateTime endDate)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            var result = await _schedulesApi.ApiV1SchoolsSchoolCrmIdSchedulesGetAsync(
                schoolId,
                startDate.ToApiDateOnlyCompatibleDateTime(),
                endDate.ToApiDateOnlyCompatibleDateTime());

            return result;
        }
        #endregion

        //========================================================================================

        private TourItemDto CreateTourItemDto(TourDto tour, LeadDto lead)
        {
            // Map tour and lead to DTO
            var dto = ObjectMapper.Map<TourItemDto>(tour);
            dto.Lead = ObjectMapper.Map<TourItemLeadDto>(lead);

            return dto;
        }

        private TourSort GetTourSort(FindToursInput input)
        {

            var sortField = input.GetSortField();

            if (sortField.Contains(FindToursInput.DEFAULT_SORTING, StringComparison.OrdinalIgnoreCase))
            {
                return TourSort.Default;
            }
            else
            {
                switch (sortField)
                {
                    case "StartDateTime":
                        return TourSort.StartDateTime;
                    case "Type":
                        return TourSort.Type;
                    case "Guide.Name":
                        return TourSort.TourGuide;
                    case "Lead.FirstName":
                        return TourSort.LeadFirstName;
                    case "Lead.LastName":
                        return TourSort.LeadLastName;
                    default:
                        throw new NotImplementedException($"{sortField} is not implemented");
                }
            }

        }
    }
}
