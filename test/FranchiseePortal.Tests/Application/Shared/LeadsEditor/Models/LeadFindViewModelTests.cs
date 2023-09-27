using Xunit;
using System.Collections.Generic;
using FranchiseePortal.Tests.Common;
using FranchiseePortal.ToursWebApiClient.Model;
using FranchiseePortal.Application.Shared.LeadsEditor.Models;
using FranchiseePortal.LeadsWebApiClient.Model;

namespace FranchiseePortal.Tests.HostDashboard.Dto
{
    public class LeadFindResultTests
    {
        [Fact()]
        public void Has_upcoming_tour()
        {
            // Arrange
            var leadId = "58";
            var leadFindDto = new LeadDto()
            {
                SchoolParentLeadId = leadId,
            };

            var sut = new LeadFindResult
            {
                LeadFindResultDto = leadFindDto,
            };

            sut.Tours = new List<TourDto>
                {
                    new TourDto(schoolId: KnownSchoolIds.NJ_Randolph, leadId: leadId, status: TourStatus.Scheduled)
                };

            // Act
            var hasTour = sut.HasUpcomingTour;

            // Assert
            Assert.True(hasTour);
        }

        [Fact]
        public void Has_no_upcoming_tour_when_there_are_no_scheduled_tours()
        {
            // Arrange
            var leadId = "58";
            var leadFindDto = new LeadDto()
            {
                SchoolParentLeadId = leadId,
            };

            var sut = new LeadFindResult
            {
                LeadFindResultDto = leadFindDto,
            };

            sut.Tours = new List<TourDto>
            {
                new TourDto(schoolId: KnownSchoolIds.NJ_Randolph, leadId: leadId, status: TourStatus.Completed),
                new TourDto(schoolId: KnownSchoolIds.NJ_Randolph, leadId: leadId, status: TourStatus.Cancelled)
            };
            // Act

            // Act
            var hasTour = sut.HasUpcomingTour;

            // Assert
            Assert.False(sut.HasUpcomingTour);
        }

        [Fact]
        public void Has_no_upcoming_tour_when_lead_has_no_tour()
        {
            // Arrange
            var leadId = "58";
            var leadFindDto = new LeadDto()
            {
                SchoolParentLeadId = leadId,
            };

            var sut = new LeadFindResult
            {
                LeadFindResultDto = leadFindDto,
            };

            // Act
            var hasTour = sut.HasUpcomingTour;

            // Assert
            Assert.False(hasTour);
        }
    }
}
