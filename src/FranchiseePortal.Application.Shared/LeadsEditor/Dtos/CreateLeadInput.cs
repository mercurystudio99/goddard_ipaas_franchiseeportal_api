using FranchiseePortal.LeadsWebApiClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.LeadsEditor.Dtos
{
    public class CreateLeadInput : LeadBaseInput
    {
        public long? SchoolParentLeadId { get; set; }

        [Required]
        public override List<TourLeadChildInput> SchoolChildLeads { get; set; }

        public static ApiV1SchoolLeadsIdTourPutRequest CreateLeadUpdateRequest(CreateLeadInput input)
        {
            List<TourLeadChildInput> childLeads = new List<TourLeadChildInput>();
            foreach (var child in input.SchoolChildLeads)
            {
                childLeads.Add(new TourLeadChildInput(child.SchoolChildLeadId, child.FirstName));
            }

            return new ApiV1SchoolLeadsIdTourPutRequest(childLeads, input.DaysOfInterest, input.ProgramsOfInterest, input.TourQuestions);
        }
    }
}
