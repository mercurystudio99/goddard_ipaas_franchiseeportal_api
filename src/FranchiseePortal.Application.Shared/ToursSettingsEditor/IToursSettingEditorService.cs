using FranchiseePortal.ToursSettingsEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Model;
using System.Threading;
using System.Threading.Tasks;

namespace FranchiseePortal.ToursSettingsEditor
{
    public interface IToursSettingEditorService
    {
        Task CreateTourSetting(TourSettingsDto settingsDto);
        Task UpdateTourSetting(string id, TourSettingsDto settingsDto);
        Task<AppTourSettingsDto> GetTourSetting(string schoolId);        
    }
}
