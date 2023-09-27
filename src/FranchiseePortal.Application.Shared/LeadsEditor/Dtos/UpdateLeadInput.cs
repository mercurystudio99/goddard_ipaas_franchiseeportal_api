using FranchiseePortal.LeadsWebApiClient.Model;

namespace FranchiseePortal.LeadsEditor.Dtos
{
    public class UpdateLeadInput : LeadBaseInput
    {
        public static ApiV1SchoolLeadsIdTourPutRequest CreateLeadUpdateRequest(UpdateLeadInput input)
        {
            return new ApiV1SchoolLeadsIdTourPutRequest(input.SchoolChildLeads, input.DaysOfInterest, input.ProgramsOfInterest, input.TourQuestions);
        }
    }
}
