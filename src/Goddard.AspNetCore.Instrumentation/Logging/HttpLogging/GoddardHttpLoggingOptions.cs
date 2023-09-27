namespace Goddard.AspNetCore.Logging.HttpLogging
{
    public class GoddardHttpLoggingOptions
    {
        public const string DEFAULT_CONFIGURATION_SECTION = "Goddard:Logging:HttpLogging";

        /// <summary>
        /// Maximum body size to log (in bytes). Defaults to 32 KB.
        /// </summary>
        public int BodyLogLimit { get; set; } = 32_768;
    }
}
