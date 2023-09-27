using System.Collections.Generic;

namespace FranchiseePortal.ToursSettingsEditor.Dtos
{
    public class AppTourSettingsDto
    {
        public string SchoolId { get; set; }
        public int MaxOpenHouseParticipants { get; set; } = 2;
        public int DefaultTourDuration { get; set; }
        public string DefaultTourGuideId { get; set; }
        public OnlineOptionsDto OnlineOptions { get; set; }
        public IEnumerable<int> AllowedTourDurationOptionsInMinutes { get; set; }
        public static AppTourSettingsDto Default(string schoolId)
        {
            return new AppTourSettingsDto()
            {
                SchoolId= schoolId
            };
        }
    }
}
