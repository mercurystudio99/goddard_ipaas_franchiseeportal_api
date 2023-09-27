using System;

namespace FranchiseePortal.LeadsEditor.Dtos
{
    public partial class LeadFindDto
    {
        public string SchoolParentLeadId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string MobilePhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 20230922RBP - This is nullable from the Leads API as of today
        /// because I see null values in this field in the PROD DB
        /// </remarks>
        public DateTime? CreatedOn { get; set; }

        public bool HasUpcomingTour { get; set; } 
    }

}
