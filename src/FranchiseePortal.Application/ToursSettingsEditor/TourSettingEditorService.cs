using Abp.Application.Features;
using Abp.Authorization;
using Ardalis.GuardClauses;
using FranchiseePortal.Configuration;
using FranchiseePortal.Extensions;
using FranchiseePortal.Features;
using FranchiseePortal.ToursSettingsEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Model;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace FranchiseePortal.ToursSettingsEditor
{
    [RequiresFeature(AppFeatures.TourFeature)]
    public class TourSettingsEditorService : FranchiseePortalAppServiceBase, ITourSettingsEditorService
    {
        #region Members
        private readonly ISettingsApi _settingsApi;
        private readonly IConfigurationRoot _appConfiguration;
        private readonly IAvailabilityApi _availabilityApi;
        private readonly IDateAvailabilitiesApi _dateAvailaibilityApi;
        private readonly IDefaultAvailabilityApi _defaultAvailabilityApi;
        #endregion

        //=================================================================

        #region Constructor

        public TourSettingsEditorService(
            ISettingsApi settingsApi,
            IAppConfigurationAccessor appConfigurationAccessor,
            IAvailabilityApi availabilityApi,
            IDateAvailabilitiesApi dateAvailaibilityApi,
            IDefaultAvailabilityApi defaultAvailabilityApi)
        {
            _settingsApi = Guard.Against.Null(settingsApi);
            _appConfiguration = Guard.Against.Null(appConfigurationAccessor.Configuration);
            _availabilityApi = Guard.Against.Null(availabilityApi);
            _dateAvailaibilityApi = Guard.Against.Null(dateAvailaibilityApi);
            _defaultAvailabilityApi = defaultAvailabilityApi ?? throw new ArgumentNullException(nameof(defaultAvailabilityApi));
        }
        #endregion

        //=================================================================

        /// <inheritdoc cref="ITourSettingsEditorService.GetAvailability(string, CancellationToken)"/>
        public async Task<AvailabilityDto> GetAvailability(string schoolId, CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var availability = await _availabilityApi.ApiV1SchoolsSchoolCrmIdAvailabilityGetAsync(
                schoolId, 
                cancellationToken: cancellationToken);
            return availability;
        }

        /// <inheritdoc/>
        public async Task<DateAvailabilityDto> GetDateAvailability(
            string schoolId, 
            DateTime date,
            CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var result = await _dateAvailaibilityApi.ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateGetAsync(
                schoolId,
                date.ToApiDateOnlyCompatibleDateTime(),
                cancellationToken: cancellationToken);

            return result;
        }

        /// <inheritdoc/>
        public async Task<AvailabilityDto> GetDefaultAvailability(
            string schoolId,
            int tourDuration,
            CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var result = await _defaultAvailabilityApi.ApiV1DefaultAvailabilityTourDurationGetAsync(
                tourDuration,
                cancellationToken: cancellationToken);

            return result;
        }

        /// <inheritdoc/>
        public async Task ResetToDefaults(string schoolId, CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            await _availabilityApi.ApiV1SchoolsSchoolCrmIdAvailabilityDeleteAsync(
                schoolId, 
                cancellationToken: cancellationToken);                        
        }
        
        /// <inheritdoc/>
        public async Task SaveAvailability(
            string schoolId, 
            AvailabilityInputDto availability, 
            CancellationToken cancellationToken)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            await _availabilityApi.ApiV1SchoolsSchoolCrmIdAvailabilityPutAsync(
                schoolId, 
                availability,
                cancellationToken: cancellationToken);
        }

        /// <inheritdoc/>
        public async Task SaveDateAvailability(
            string schoolId,
            DateTime date,
            DateAvailabilityInputDto input,
            CancellationToken cancellationToken)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            await _dateAvailaibilityApi.ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDatePutAsync(
                schoolId,
                date.ToApiDateOnlyCompatibleDateTime(),
                input,
                cancellationToken: cancellationToken);
        }

        public async Task SaveTourSettings(string schoolId, TourSettingsInputDto input, CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            await _settingsApi.ApiV1SchoolsSchoolCrmIdSettingsPutAsync(
                schoolId, 
                input, 
                cancellationToken: cancellationToken);
        }

        public async Task<AppTourSettingsDto> GetTourSettings(string schoolId, CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var result = ObjectMapper.Map<AppTourSettingsDto>(await _settingsApi.ApiV1SchoolsSchoolCrmIdSettingsGetAsync(schoolId, cancellationToken: cancellationToken));
           

            result.OnlineOptions = new OnlineOptionsDto()
            {
                AllowedMaxOpenHouseParticipants = JsonConvert.DeserializeObject<List<int>>(_appConfiguration["App:Tours:AllowedMaxOpenHouseParticipants"]),
                
            };

            result.AllowedTourDurationOptionsInMinutes = JsonConvert.DeserializeObject<List<int>>(_appConfiguration["App:Tours:AllowedTourDurationOptionsInMinutes"]);

            return result;
        }

        /// <inheritdoc/>
        public async Task SaveOnlineTourSettings(string schoolId, SaveOnlineTourSettingsInput input, CancellationToken cancellationToken = default)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            var settings = await _settingsApi.ApiV1SchoolsSchoolCrmIdSettingsGetAsync(schoolId, cancellationToken: cancellationToken);
            var apiInput = ObjectMapper.Map<TourSettingsInputDto>(settings);
            apiInput = ObjectMapper.Map(input, apiInput);

            try
            {
                await _settingsApi.ApiV1SchoolsSchoolCrmIdSettingsPutAsync(
                    schoolId, 
                    apiInput, 
                    cancellationToken: cancellationToken);
            }
            catch(ToursWebApiClient.Client.ApiException ex)
            {
                if(ex.ErrorCode == (int)HttpStatusCode.BadRequest)
                {
                    Logger.WarnFormat(ex.Message, ex);
                }

                throw;
            }
            
        }      
    }
}
