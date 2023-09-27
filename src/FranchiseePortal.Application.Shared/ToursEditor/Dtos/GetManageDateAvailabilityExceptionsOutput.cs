using FranchiseePortal.ToursWebApiClient.Model;
using System;

namespace FranchiseePortal.ToursEditor.Dtos
{
    public class GetManageDateAvailabilityExceptionsOutput
    {
        public string SchoolId
        {
            get;
            set;
        }

        /// <summary>
        /// Date of exceptions being managed
        /// </summary>
        public DateTime Date
        {
            get;
            set;

        }

        /// <summary>
        /// Gets or sets whether all day is blocked
        /// </summary>
        public bool IsAllDayBlocked
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets schedule for date
        /// </summary>
        public ScheduleItemDto[] Availability
        {
            get;
            set;
        }
    }
}
