using Abp.Application.Features;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.UI;
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
        private readonly IScheduleApi _scheduleApi;
        private readonly ISchoolTourAvailabilityApi _availabilityApi;
        #endregion

        //========================================================================================

        #region Constructor
        public ToursEditorService(
            IToursApi toursClient,
            ISchoolParentLeadsApi leadsClient,
            ISchoolsApi schoolsApi,
            IGuidesApi guidesApi,
            IScheduleApi scheduleApi,
            ISchoolTourAvailabilityApi availabilityApi)
        {
            _toursClient = toursClient;
            _leadsClient = leadsClient;
            _schoolsApi = schoolsApi;
            _guidesClient = guidesApi;
            _scheduleApi = scheduleApi;
            _availabilityApi = availabilityApi;
        }

        #endregion

        //========================================================================================

        #region Endpoints

        [HttpGet]
        public async Task<PagedResultDto<TourItemDto>> FindTours(FindToursInput input)
        {
            if (!await AuthorizeForSchoolAsync(input.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            // Fetch tours data
            var toursSearchResult = await _toursClient.ApiV1ToursGetAsync(input.SchoolId, input.Status, input.StartDate, input.EndDate, input.Type, input.GuideName);

            List<LeadDto> leads = new List<LeadDto>();
            if (input.HasAdvancedLeadFilters())
            {
                var school = await _schoolsApi.ApiV1SchoolsIdGetAsync(input.SchoolId);

                // Fetch leads data using advanced filters only (empty query)
                leads = (await _leadsClient.ApiV1SchoolLeadsGetAsync(
                    long.Parse(school.FmsId), null, input.LeadName, input.ChildAge,
                    input.LeadStartDate, input.LeadEndDate, input.ProgramsOfInterest,
                    1, int.MaxValue)).Items;
            }
            else
            {
                var leadIds = toursSearchResult.Items
                    .Select(x => x.LeadId)
                    .Distinct()
                    .ToList();

                leads = (await _leadsClient.ApiV1SchoolLeadsQueryByIdsPostAsync(leadIds))
                    .ToList();

                if (leadIds.Count > leads.Count)
                {
                    Logger.WarnFormat("Expected {expected}, but received {actual} leads",
                            leadIds.Count,
                            leads.Count);
                }
            }

            // Join tours and leads on lead ID and map to TourDto
            var items = toursSearchResult.Items.Join(
                leads,
                outer => outer.LeadId,
                inner => inner.SchoolParentLeadId.ToString(),
                (tour, lead) => CreateTourItemDto(tour, lead))
                .ToList();

            var result = new PagedResultDto<TourItemDto>(toursSearchResult.Total, items);
            return result;
        }

        [HttpGet]
        public async Task<List<TourGuideDto>> GetSchoolGuides(string crmId)
        {
            if (!await AuthorizeForSchoolAsync(crmId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            var result = await _guidesClient.ApiV1GuidesGetAsync(crmId);

            return result;
        }

        public async Task CreateTour(CreateTourInput tourDto)
        {
            if (!await AuthorizeForSchoolAsync(tourDto.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var tour = CreateTourInput.CreateTourDto(tourDto);

            var result = await _toursClient.ApiV1ToursPostAsync(tour);

            //Update lead
            await UpdateLead(tourDto.Lead.GuidId, CreateLeadInput.CreateLeadUpdateRequest(tourDto.Lead));
        }

        public async Task UpdateTour(string id, UpdateTourInput tourDto)
        {
            if (!await AuthorizeForSchoolAsync(tourDto.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            //Update lead
            await UpdateLead(tourDto.Lead.GuidId, UpdateLeadInput.CreateLeadUpdateRequest(tourDto.Lead));

            var tour = await _toursClient.ApiV1ToursIdGetAsync(id);

            UpdateTourInput.UpdateTourFields(tourDto, tour);

            //Update Tour
            await _toursClient.ApiV1ToursIdPutAsync(id, tour);
        }

        private async Task UpdateLead(Guid guidId, ApiV1SchoolLeadsIdTourPutRequest leadUpdate)
        {
            await _leadsClient.ApiV1SchoolLeadsIdTourPutAsync(guidId, leadUpdate);
        }

        public async Task<ScheduleDto> GetSchedule(string schoolId, DateTime? startDate, DateTime? endDate)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            var result = await _scheduleApi.ApiV1ScheduleSchoolIdGetAsync(schoolId, startDate, endDate);

            return result;
        }

        [HttpGet]
        public async Task<List<SchoolTourAvailabilityDto>> GetSchoolTourAvailabilities(string schoolId, CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            var result = await _availabilityApi.ApiV1SchoolTourAvailabilitySchoolIdGetAsync(schoolId, cancellationToken: cancellationToken);

            return result;
        }

        [HttpGet]
        public async Task<List<SchoolTourAvailabilityDto>> GetSchoolDefaultTourAvailabilities(string schoolId, CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            var result = await _availabilityApi.ApiV1SchoolTourAvailabilityDefaultAvailabilitySchoolIdGetAsync(schoolId);

            return result;
        }


        public async Task SaveSchoolTourAvailabilitySettings(string schoolId, List<SchoolTourAvailabilityDto> tourAvailabilities, CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            var newTourAvailabilities = tourAvailabilities.Where(t => string.IsNullOrEmpty(t.Id)).ToList();
            var updateTourAvailabilities = tourAvailabilities.Where(t => !string.IsNullOrEmpty(t.Id)).ToList();

            //Create new ones
            if (newTourAvailabilities.Any())
            {
                await _availabilityApi.ApiV1SchoolTourAvailabilityIncludeBatchPostAsync(newTourAvailabilities, cancellationToken: cancellationToken);
            }

            //Update
            if (updateTourAvailabilities.Any())
            {
                await _availabilityApi.ApiV1SchoolTourAvailabilityUpdateBatchPutAsync(updateTourAvailabilities, cancellationToken: cancellationToken);
            }
        }

        [HttpDelete]
        public async Task DeleteSchoolTourAvailabilitySettings(string schoolId, [FromBody]List<SchoolTourAvailabilityDto> tourAvailabilities, CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            await _availabilityApi.ApiV1SchoolTourAvailabilityDeleteBatchDeleteAsync(tourAvailabilities, cancellationToken: cancellationToken);
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
    }

}
