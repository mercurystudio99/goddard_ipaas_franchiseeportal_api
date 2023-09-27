using Abp.Application.Services.Dto;
using FranchiseePortal.ToursEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Model;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FranchiseePortal.ToursEditor
{
    public interface IToursEditorService
    {
        Task<PagedResultDto<TourItemDto>> FindTours(
            FindToursInput input, 
            CancellationToken cancellationToken = default);

        Task<TourItemDto> GetTour(string schoolId, string id);
        Task CreateTour(CreateTourInput input);

        Task UpdateTour(string id, UpdateTourInput tourDto);

        Task<List<TourGuideDto>> GetSchoolGuides(string crmId);

        /// <summary>
        /// Get schedules for school identified by <paramref name="schoolId"/> between dates <paramref name="startDate"/> and <paramref name="endDate"/> inclusive
        /// </summary>
        /// <param name="schoolId" example="F0EDC50F-ED22-DE11-B821-0014221C4264"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        /// <exception cref="AbpAuthorizationException"></exception>
        Task<IEnumerable<ScheduleDto>> GetSchedules(string schoolId, DateTime startDate, DateTime endDate);     
    }
}
