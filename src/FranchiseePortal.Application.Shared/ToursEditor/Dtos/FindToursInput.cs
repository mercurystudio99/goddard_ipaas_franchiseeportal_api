using FranchiseePortal.ToursWebApiClient.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FranchiseePortal.ToursEditor.Dtos
{
    public class FindToursInput
    {
        public const string DEFAULT_SORTING = "Newest";

        [Required]
        public string SchoolId { get; set; } = string.Empty;

        public List<TourStatus> Statuses { get; set; }

        /// <summary>
        /// Gets or sets optional start UTC date and time query filter
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets optional end UTC date and time query filter
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        public List<TourType> Types { get; set; }

        public List<string> GuideIds { get; set; }
        public string LeadName { get; set; }
        public int? ChildAge { get; set; }
        public DateTime? LeadStartDate { get; set; }
        public DateTime? LeadEndDate { get; set; }
        public List<string> ProgramsOfInterest { get; set; }
        [Range(1, int.MaxValue)]
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 100;

        private string _sorting;
        public string Sorting
        {
            get
            {       
                if (_sorting != null) return _sorting;

                return DEFAULT_SORTING;
            } 
            set
            {
                _sorting = value;
            }
        }

        public bool HasAdvancedLeadFilters()
        {
            return !string.IsNullOrEmpty(LeadName) ||
                ChildAge.HasValue ||
                LeadStartDate.HasValue ||
                LeadEndDate.HasValue ||
                (ProgramsOfInterest != null && ProgramsOfInterest.Any());
        }

        public bool HasLeadBasedSorting()
        {
            return !string.IsNullOrEmpty(Sorting) && Sorting.Contains("Lead");
        }


        public string GetSortField()
        {                        
            var result = Sorting?.Replace(" ASC", string.Empty).Replace(" DESC", string.Empty);
            return result;            
        }

        public ListSortDirection GetSortDirection()
        {
            var result = Sorting.Contains("ASC")
                ? ListSortDirection.Ascending : ListSortDirection.Descending;
            return result;

        }
    }
}
