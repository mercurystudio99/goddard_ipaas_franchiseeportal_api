using FranchiseePortal.ToursWebApiClient.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.ToursEditor.Dtos
{
    public abstract class BaseTourInput
    {
        [Required]
        public virtual string SchoolId { get; set; }

        [Required]
        public DateTime TourStartDate { get; set; }

        [Required]
        public DateTime TourEndDate { get; set; }

        [Required]
        public TourStatus Status { get; set; } = TourStatus.Scheduled;

        [Required]
        public virtual string GuideId { get; set; }

        public virtual string ClassRoom { get; set; } = string.Empty;

        public virtual string Notes { get; set; } = string.Empty;

        public string SchoolTimeZone { get; set; } = string.Empty;
    }
}
