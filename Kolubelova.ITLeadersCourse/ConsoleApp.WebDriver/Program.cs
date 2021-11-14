namespace ConsoleApp.WebDriver
{
    using ConsoleApp.WebDriver.Helpers;
    using ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows;
    using System;
    using static ConsoleApp.CSharpBasics.IO.Output;
    using static ConsoleApp.WebDriver.AppSettings.SettingsCongfigurator;

    class Program : BaseTest
    {
        static void Main(string[] args)
        {

            try
            {
                var additionalWindowPage = NavigateTo<AdditionalWindowsPage>(AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson6HomeTask);
                var additionalWindowHandle = WindowHelper.AddWindow();
                var newBrowserWindowPage = additionalWindowPage.ClickNewBrowserWindowButton();

                var newBrowserWindowHandle = WindowHelper.AddWindow();
                WindowHelper.SwitchTo(newBrowserWindowHandle);
                var expUrl = "https://ultimateqa.com/automation";

                // Get New browser window url compare it with expected 
                var actUrl = newBrowserWindowPage.GetUrl();

                AssertCorrectData(expUrl, actUrl);

                WindowHelper.SwitchTo(additionalWindowHandle); // Switch to AdditionalWindows window

                var newMessageWindowPage = additionalWindowPage.ClickNewMessageWindowButton(); // Open New message window
                var newMessageWindowHandle = WindowHelper.AddWindow();
                WindowHelper.SwitchTo(newMessageWindowHandle);
                var expMessage = "Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization.";
                var actMessage = newMessageWindowPage.GetMessage();
                //AssertCorrectData(expMessage, actMessage);

                WindowHelper.SwitchTo(additionalWindowHandle); // 9. Switch to AdditionalWindows window

                var newBrowserTabPage = additionalWindowPage.ClickNewBrowserTabButton(); // 10. Open New browser tab by clicking 
                var newBrowserTabWindowHandle = WindowHelper.AddWindow();
                WindowHelper.SwitchTo(newBrowserTabWindowHandle);

                var actTitle = newBrowserTabPage.GetPageTitle(); //Get New Browser Tab title
                var expTitle = "Automation Practice | Ultimate QA";
                //AssertCorrectData(expTitle, actTitle);

                WindowHelper.SwitchTo(additionalWindowHandle);

                WindowHelper.CloseAllBut(additionalWindowHandle);


            }
            catch (Exception)
            {
            }
            finally
            {
                DisposeTest();
            }
        }


        private static void AssertCorrectData(string expUrl, string actUrl)
        {
            if (expUrl != actUrl)
            {
                throw new Exception($"Actual data {actUrl} is not equal to expected one {expUrl}");
            }

            else
            {
                Out.WriteLine($"Data is correct. Expected data: {expUrl}; Actual data: {actUrl}");
            }
        }
    }
}
