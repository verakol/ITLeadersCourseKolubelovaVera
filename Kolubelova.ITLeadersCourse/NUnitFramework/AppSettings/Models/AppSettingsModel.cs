using NUnitFramework.Enums;

namespace NUnitFramework.AppSettings.Models
{
    public class AppSettingsModel
    {
        public string BaseUrl { get; set; }

        public BrowserType Browser { get; set; }

        public LoggerType Logger { get; set; }
    }
}
