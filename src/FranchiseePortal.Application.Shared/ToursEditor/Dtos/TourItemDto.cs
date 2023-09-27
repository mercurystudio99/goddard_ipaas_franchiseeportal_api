using FranchiseePortal.ToursWebApiClient.Model;
using System;

namespace FranchiseePortal.ToursEditor.Dtos
{
    /// <summary>
    /// DTO for displaying tour info in a item on a list or grid
    /// </summary>
    public class TourItemDto
    {
        public string Id { get; set; }

        public string ClassRoom { get; set; }

        public string Notes { get; set; }

        public TourGuideDto Guide { get; set; }

        public TourItemLeadDto Lead { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public TourStatus Status { get; set; }

        public TourType Type { get; set; }
        
        public FollowUpTimeFrame? FollowUpTimeFrame { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? Viewed { get; set; }

        /// <summary>
        /// The default sort is "newest first" (Not viewed tours), then by Tour Date (ascending order/soonest first)
        /// When tour is marked as Viewed, the green dot is removed and the tour sorts under the by tour date sorting
        /// </summary>
        public bool IsViewed { get { return Viewed != null; } }
    }
}
