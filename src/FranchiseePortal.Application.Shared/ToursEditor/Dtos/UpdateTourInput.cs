using FranchiseePortal.LeadsEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.ToursEditor.Dtos
{
    public class UpdateTourInput : BaseTourInput
    {
        public DateTime? Viewed { get; set; }

        [Required]
        public UpdateLeadInput Lead { get; set; }

        public static void UpdateTourFields(UpdateTourInput input, TourDto tour)
        {
            tour.GuideId = input.GuideId;
            tour.ClassRoom = input.ClassRoom;
            tour.Status = input.Status;
            tour.Notes = input.Notes;
            tour.TourStartDate = input.TourStartDate;
            tour.TourEndDate = input.TourEndDate;
            tour.SchoolTimeZone= input.SchoolTimeZone;
            tour.Viewed = input.Viewed;
        }
    }
}
