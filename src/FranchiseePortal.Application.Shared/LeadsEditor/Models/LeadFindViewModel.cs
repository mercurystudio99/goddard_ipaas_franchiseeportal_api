using System.Linq;
using System.Collections.Generic;
using FranchiseePortal.LeadsWebApiClient.Model;
using FranchiseePortal.ToursWebApiClient.Model;

namespace FranchiseePortal.Application.Shared.LeadsEditor.Models
{

    public class LeadFindResult
    {
        public LeadDto LeadFindResultDto { get; set; }

        public IEnumerable<TourDto> Tours { get; set; }

        public bool HasUpcomingTour
        {
            get
            {
                // Any scheduled tours with a matching lead id
                return Tours?.Any(x => x.LeadId == LeadFindResultDto.SchoolParentLeadId && x.Status == TourStatus.Scheduled) == true;
            }
        }
    }
}
