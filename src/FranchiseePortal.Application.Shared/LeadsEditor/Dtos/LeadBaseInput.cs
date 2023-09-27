using FranchiseePortal.LeadsWebApiClient.Model;
using System;
using System.Collections.Generic;

namespace FranchiseePortal.LeadsEditor.Dtos
{
    public abstract class LeadBaseInput 
    {
        public virtual Guid GuidId { get; set; }

        public virtual List<DaysOfInterest> DaysOfInterest { get; set; }

        public virtual List<string> ProgramsOfInterest { get; set; }

        public virtual string TourQuestions { get; set; }

        public virtual List<TourLeadChildInput> SchoolChildLeads { get; set; }
    }
}
