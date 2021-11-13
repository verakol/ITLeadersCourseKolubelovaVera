namespace ConsoleApp.WebDriver.Drivers
{
    using ConsoleApp.WebDriver.Drivers.Implementations;
    using ConsoleApp.WebDriver.Enums;
    using OpenQA.Selenium;
    using System;
    using static AppSettings.SettingsCongfigurator;

    public class WebDriverManager
    {
        private static IWebDriver driver;

        private static BrowserType BrowerType => Settings.BrowserType;

        private static string PathToDriver => AppDomain.CurrentDomain.BaseDirectory;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new DriverFactory()
                        .GetDriver(BrowerType)
                        .Setup(PathToDriver);
                }

                return driver;
            }
        }

        public static void DisposeDriver()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
