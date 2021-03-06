using ConsoleApp.WebDriver.Pages.Lesson9WebDriverWait;
using System;
using static ConsoleApp.CSharpBasics.IO.Output;
using static ConsoleApp.WebDriver.AppSettings.SettingsCongfigurator;

namespace ConsoleApp.WebDriver
{
    class Program : BaseTest
    {
        private static string url = AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson9HomeTask;
        static void Main(string[] args)
        {
            try
            {
                var waitForMessagePage = NavigateTo<WaitForMessagePage>(url);

                waitForMessagePage.ClickOnLaunchButton();

                waitForMessagePage.ClickOnTryToClickButton();

                var message = waitForMessagePage.GetMessage();

                Out.WriteLine($"Message is: {message}");

            }
            catch (Exception ex)
            {
                Out.WriteLine(ex);
            }
            finally
            {
                DisposeTest();
            }
        }
    }
}
