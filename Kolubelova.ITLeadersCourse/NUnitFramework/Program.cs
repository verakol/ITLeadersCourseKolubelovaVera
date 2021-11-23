using NUnitFramework.Drivers;
using NUnitFramework.Logging;
using static NUnitFramework.AppSettings.SettingsConfigurator;

namespace NUnitFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = Settings;

            Logger.Log.Info("Info message");
            Logger.Log.Info("Info message {0}", Settings.Logger);
            Logger.Log.Worn("Warning message");
            Logger.Log.Worn("Warning message {0}", Settings.Browser);
            Logger.Log.Error("Error message");
            Logger.Log.Error("Error message {0}", Settings.BaseUrl);

            WebDriverManager.Driver.Navigate().GoToUrl(Settings.BaseUrl);
            WebDriverManager.DisposeDriver();


        }

    }
}
