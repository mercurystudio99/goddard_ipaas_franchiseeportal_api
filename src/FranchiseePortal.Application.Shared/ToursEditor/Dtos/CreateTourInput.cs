using FranchiseePortal.ToursWebApiClient.Model;
using FranchiseePortal.LeadsWebApiClient.Model;
using System;
using System.ComponentModel.DataAnnotations;
using FranchiseePortal.LeadsEditor.Dtos;

namespace FranchiseePortal.ToursEditor.Dtos
{
    public class CreateTourInput : BaseTourInput
    {
        [Required]
        public TourTypes Type { get; set; } = TourTypes.InPerson;

        public FollowUpTimeFrame FollowUpTimeFrame { get; set; } = FollowUpTimeFrame.ASAP;


        [Required]
        public CreateLeadInput Lead { get; set; }

        public static TourDto CreateTourDto(CreateTourInput input)
        {
            return new TourDto(
                Guid.NewGuid().ToString(),
                input.Lead.SchoolParentLeadId.ToString(),
                input.Notes,
                input.TourStartDate,
                input.TourEndDate,
                DateTime.UtcNow,
                input.Type,
                input.SchoolId,
                input.Status,
                input.GuideId,
                null,
                input.ClassRoom,
                input.FollowUpTimeFrame,
                null,
                input.SchoolTimeZone);
        }
    }
}
