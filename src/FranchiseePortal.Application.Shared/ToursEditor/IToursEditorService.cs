﻿using Abp.Application.Services.Dto;
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
        Task<PagedResultDto<TourItemDto>> FindTours(FindToursInput input);
        Task CreateTour(CreateTourInput input);
        Task UpdateTour(string id, UpdateTourInput tourDto);
        Task<List<TourGuideDto>> GetSchoolGuides(string crmId);
        Task<ScheduleDto> GetSchedule(string schoolId, DateTime? startDate, DateTime? endDate);
        Task<List<SchoolTourAvailabilityDto>> GetSchoolTourAvailabilities(string schoolId, CancellationToken cancellationToken = default);
        Task<List<SchoolTourAvailabilityDto>> GetSchoolDefaultTourAvailabilities(string schoolId, CancellationToken cancellationToken = default);
        Task SaveSchoolTourAvailabilitySettings(string schoolId, List<SchoolTourAvailabilityDto> tourAvailabilities, CancellationToken cancellationToken = default);

        Task DeleteSchoolTourAvailabilitySettings(string schoolId, List<SchoolTourAvailabilityDto> tourAvailabilities, CancellationToken cancellationToken = default);
    }
}
