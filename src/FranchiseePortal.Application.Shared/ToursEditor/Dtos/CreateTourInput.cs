using FranchiseePortal.LeadsEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Model;
using FranchiseePortal.Validation;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.ToursEditor.Dtos
{
    public class CreateTourInput : BaseTourInput
    {
        [RequiredIf(nameof(Type), TourTypes.InPerson, ErrorMessage = "Tour Guide is required for In-Person Tour")]
        public override string GuideId { get; set; }

        public FollowUpTimeFrame FollowUpTimeFrame { get; set; } = FollowUpTimeFrame.ASAP;


        [Required]
        public CreateLeadInput Lead { get; set; }

        public static TourInputDto CreateApiTourInputDto(CreateTourInput input)
        {
            return new TourInputDto(
                leadId: input.Lead.SchoolParentLeadId.ToString(),
                notes: input.Notes,
                startDateTime: input.StartDateTime,
                endDateTime: input.EndDateTime,
                type: input.Type,
                status: input.Status,
                guideId: input.GuideId,
                classRoom: input.ClassRoom,
                followUpTimeFrame: input.FollowUpTimeFrame,
                cancellationReasonId: null,
                viewed: null);
        }
    }
}
