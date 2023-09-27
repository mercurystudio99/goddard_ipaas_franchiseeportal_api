using Abp.Application.Features;
using Abp.Authorization;
using Castle.Windsor.Installer;
using FranchiseePortal.Configuration;
using FranchiseePortal.Features;
using FranchiseePortal.SchoolsWebApiClient.Model;
using FranchiseePortal.ToursEditor.Dtos;
using FranchiseePortal.ToursSettingsEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Model;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FranchiseePortal.ToursSettingsEditor
{
    [RequiresFeature(AppFeatures.TourFeature)]
    public class ToursSettingEditorService : FranchiseePortalAppServiceBase, IToursSettingEditorService
    {
        #region Members
        private readonly ISettingsApi _settingsApi;
        private readonly IConfigurationRoot _appConfiguration;
        #endregion

        //=================================================================

        #region Constructor

        public ToursSettingEditorService(ISettingsApi settingsApi, IAppConfigurationAccessor appConfigurationAccessor)
        {
            _settingsApi = settingsApi;
            _appConfiguration = appConfigurationAccessor.Configuration;
        }
        #endregion

        //=================================================================

        public async Task CreateTourSetting(TourSettingsDto input)
        {
            if (!await AuthorizeForSchoolAsync(input.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            await _settingsApi.ApiV1SettingsPostAsync(input);
        }
        public async Task UpdateTourSetting(string id, TourSettingsDto input)
        {
            if (!await AuthorizeForSchoolAsync(input.SchoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            await _settingsApi.ApiV1SettingsIdPutAsync(id, input);
        }
        public async Task<AppTourSettingsDto> GetTourSetting(string schoolId)
        {
            if (!await AuthorizeForSchoolAsync(schoolId))
            {
                throw new AbpAuthorizationException("User is not authorized to modify school");
            }

            AppTourSettingsDto result = null;
            try
            {
                result = ObjectMapper.Map<AppTourSettingsDto>(await _settingsApi.ApiV1SettingsSchoolIdGetAsync(schoolId));
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("not found", System.StringComparison.InvariantCultureIgnoreCase))
                {
                    result = AppTourSettingsDto.Default(schoolId);
                }
                else
                {
                    throw;
                }
                
            }

            result.OnlineOptions = new OnlineOptionsDto()
            {
                AllowedMaxOpenHouseParticipants = JsonConvert.DeserializeObject<List<int>>(_appConfiguration["App:Tours:AllowedMaxOpenHouseParticipants"]),
                
            };

            result.AllowedTourDurationOptionsInMinutes = JsonConvert.DeserializeObject<List<int>>(_appConfiguration["App:Tours:AllowedTourDurationOptionsInMinutes"]);

            return result;
        }
    }
}
