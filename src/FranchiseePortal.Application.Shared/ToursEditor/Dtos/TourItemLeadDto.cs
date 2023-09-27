using FranchiseePortal.LeadsWebApiClient.Model;
using System;
using System.Linq;

namespace FranchiseePortal.ToursEditor.Dtos
{
    /// <summary>
    /// DTO for displaying lead info for a tour item on a list or grid
    /// </summary>
    public class TourItemLeadDto
    {
        public long? SchoolParentLeadId { get; set; }

        public Guid GuidId { get; set; }

        public TourItemLeadChildDto[] SchoolChildLeads { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public LevelOfInterest? LevelOfInterest { get; set; }

        public string MobilePhone { get; set; }

        public string EmailAddress { get; set; }

        public string TourQuestions { get; set; }
        public string FirstChildName => SchoolChildLeads is null || SchoolChildLeads.Length == 0
            ? null
            : SchoolChildLeads.First().FirstName;

        public int? FirstChildAgeMonths
        {
            get
            {
                if (SchoolChildLeads is null || SchoolChildLeads.Length == 0)
                {
                    return null;
                }

                var now = DateTime.Now;

                var firstChildBornDate = SchoolChildLeads.First().DateOfBirth;
                if (firstChildBornDate.Equals(default(DateTime)))
                {
                    return null;
                }

                int months = ((now.Year - firstChildBornDate.Year) * 12) + now.Month - firstChildBornDate.Month;

                // Subtracting one month if the month is the same, but the day isn't.
                if (firstChildBornDate.Day > now.Day)
                {
                    months--;
                }

                return Math.Max(0, months);
            }
        }
    }
}
