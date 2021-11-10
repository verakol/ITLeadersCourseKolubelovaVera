namespace ConsoleApp.WebDriver.AppSettings
{
    using ConsoleApp.WebDriver.AppSettings.Models;
    using System.IO;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public static class SettingsCongfigurator
    {
        private static readonly string PathToAppSettings = @"AppSettings\Files\appsettings.json";

        private static AppSettingsModel GetAppSettings()
        {
            var settings = File.ReadAllText(PathToAppSettings);

            return JsonSerializer.Deserialize<AppSettingsModel>(settings, new JsonSerializerOptions()
            {
                IgnoreNullValues = true,
                WriteIndented = false,
                Converters = { new JsonStringEnumConverter() }
            });
        }

        public static AppSettingsModel Settings { get; } = GetAppSettings();
    }
}
