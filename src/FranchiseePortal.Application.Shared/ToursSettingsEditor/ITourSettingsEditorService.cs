using Abp.Application.Services;
using FranchiseePortal.ToursSettingsEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Model;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FranchiseePortal.ToursSettingsEditor
{
    /// <summary>
    /// App service interface for managing tour availability and settings 
    /// </summary>
    public interface ITourSettingsEditorService : IApplicationService
    {
        /// <summary>
        /// Gets regular availability for a school
        /// </summary>
        /// <param name="schoolId" example="F0EDC50F-ED22-DE11-B821-0014221C4264"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<AvailabilityDto> GetAvailability(string schoolId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets date specific availability for <paramref name="date"/> for school identified by <paramref name="schoolId"/>
        /// </summary>
        /// <param name="schoolId" example="F0EDC50F-ED22-DE11-B821-0014221C4264"></param>
        /// <param name="date"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<DateAvailabilityDto> GetDateAvailability(
            string schoolId,
            DateTime date,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets default availability for specified tour duration
        /// </summary>
        /// <param name="schoolId" example="F0EDC50F-ED22-DE11-B821-0014221C4264"></param>
        /// <param name="tourDuration" example="30"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<AvailabilityDto> GetDefaultAvailability(
            string schoolId, 
            int tourDuration,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Resets regular availability for school identified by <paramref name="schoolId"/>
        /// </summary>
        /// <param name="schoolId" example="F0EDC50F-ED22-DE11-B821-0014221C4264"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>
        /// User Story 15331: Tour Scheduling - Manage Availability - Custom (Default) Tour Availability
        /// Reset to Default
        ///     - If Confirmed, clear all custom availability slots and replace with the applicable default availability schedule according to their Default Tour Duration.
        /// </remarks>
        Task ResetToDefaults(string schoolId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves regular day of week availability for a school
        /// </summary>
        /// <param name="schoolId" example="F0EDC50F-ED22-DE11-B821-0014221C4264"></param>
        /// <param name="availability"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task SaveAvailability(string schoolId, AvailabilityInputDto availability, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves date specific availability for <paramref name="date"/> for school identified by <paramref name="schoolId"/>
        /// </summary>
        /// <param name="schoolId" example="F0EDC50F-ED22-DE11-B821-0014221C4264"></param>
        /// <param name="date"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task SaveDateAvailability(
            string schoolId,
            DateTime date,
            DateAvailabilityInputDto input,
            CancellationToken cancellationToken);

        Task SaveTourSettings(string schoolId, TourSettingsInputDto input, CancellationToken cancellationToken = default);

        Task<AppTourSettingsDto> GetTourSettings(string schoolId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save online tour settings
        /// </summary>
        /// <param name="schoolId" example="F0EDC50F-ED22-DE11-B821-0014221C4264"></param>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task SaveOnlineTourSettings(string schoolId, SaveOnlineTourSettingsInput input, CancellationToken cancellationToken = default);
    }
}
