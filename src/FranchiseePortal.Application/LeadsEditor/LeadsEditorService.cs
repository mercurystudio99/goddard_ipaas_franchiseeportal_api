using Abp.Authorization;
using FranchiseePortal.Application.Shared.LeadsEditor.Models;
using FranchiseePortal.Dto;
using FranchiseePortal.LeadsEditor.Dtos;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Model;
using FranchiseePortal.SchoolsWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FranchiseePortal.LeadsEditor
{
    public class LeadsEditorService : FranchiseePortalAppServiceBase, ILeadsEditorService
    {
        #region Variables
        // Customized client by Swagger
        private readonly ISchoolParentLeadsApi _schoolParentLeadClient;
        private readonly IToursApi _toursClient;
        private readonly ISchoolsApi _schoolsApi;
        private const string APP_NAME = "iGoddard.com";
        #endregion

        //========================================================================================

        #region Constructor
        public LeadsEditorService(ISchoolParentLeadsApi client, ISchoolsApi schoolsApi, IToursApi toursClient)
        {
            _schoolParentLeadClient = client;
            _schoolsApi = schoolsApi;
            _toursClient = toursClient;
        }
        #endregion

        //========================================================================================

        [HttpGet]
        public async Task<IEnumerable<LeadFindDto>> Find(FindLeadsInput input, PagingParametersDto paging)
        {
            if (!await AuthorizeForSchoolAsync(input.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized for school");
            }

            var school = await _schoolsApi.ApiV1SchoolsIdGetAsync(input.SchoolId);

            var paged = await _schoolParentLeadClient.ApiV1SchoolLeadsGetAsync(
                schoolId: long.Parse(school.FmsId),
                q: input.Q,
                name: input.LeadName,
                input.ChildAge,
                input.StartDate,
                input.EndDate,
                input.ProgramsOfInterest,
                paging.Page,
                paging.PageSize);

            IEnumerable<LeadFindDto> result = null;

            TourDtoPaginationDto toursSearchResult = null;

            if (paged.Items != null && paged.Items.Any())
            {
                var leadsToSearch = paged.Items.Select(x => x.SchoolParentLeadId).Distinct();
                toursSearchResult = await _toursClient.ApiV1SchoolsSchoolCrmIdToursGetAsync(
                    schoolCrmId: input.SchoolId,
                    statuses: new List<TourStatus>() { TourStatus.Scheduled },
                    leadIds: leadsToSearch.ToList()); ;
            }

            var vms = MapToLeadFindResult(paged, toursSearchResult);
            result = MapToLeadFindDtos(vms);
            return result;
        }

        [HttpGet]
        public async Task<LeadDto> FindLeadById(string crmId, string id)
        {
            if (!await AuthorizeForSchoolAsync(crmId))
            {
                throw new AbpAuthorizationException("User is not authorized to access school");
            }

            // Find lead
            var lead = await _schoolParentLeadClient.ApiV1SchoolLeadsIdGetAsync(id);

            return lead;
        }

        public async Task<LeadDto> CreateLead(ApiV1SchoolLeadsInternalPostRequest lead, bool? async = true)
        {
            var school = _schoolsApi.ApiV1SchoolsFmsIdIdGet(lead.SchoolId.ToString());

            if (!await AuthorizeForSchoolAsync(school.CrmId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var createdLead = await _schoolParentLeadClient.ApiV1SchoolLeadsInternalPostAsync(async, APP_NAME, lead);

            return createdLead;
        }

        private IEnumerable<LeadFindResult> MapToLeadFindResult(LeadDtoPaginationDto leads, TourDtoPaginationDto toursSearchResult)
        {
            if (leads?.Items == null)
            {
                return new List<LeadFindResult>();
            }

            return leads.Items.Select(x =>
            {
                var vm = new LeadFindResult
                {
                    LeadFindResultDto = x,
                    Tours = toursSearchResult.Items,
                };

                return vm;
            });
        }

        private IEnumerable<LeadFindDto> MapToLeadFindDtos(IEnumerable<LeadFindResult> leadSearchViewModels)
        {
            return leadSearchViewModels.Select(x => ObjectMapper.Map<LeadFindDto>(x));
        }
    }
}
