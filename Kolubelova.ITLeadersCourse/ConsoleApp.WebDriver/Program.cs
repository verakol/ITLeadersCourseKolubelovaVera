
using ConsoleApp.WebDriver.Pages.Lesson7IFrame;
using System;
using static ConsoleApp.CSharpBasics.IO.Output;
using static ConsoleApp.WebDriver.AppSettings.SettingsCongfigurator;

namespace ConsoleApp.WebDriver
{

    class Program : BaseTest
    {
        private static readonly string url = AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson7;
        static void Main(string[] args)
        {

            try
            {
                IFramePage iFramePage = NavigateTo<IFramePage>(url); // Go to iframe.html

                SecondFramePage secondFramePage = iFramePage.SwitchToSecondFrame(); // Go to Frame2

                FirstFramePage firstFramePage = secondFramePage.SwitchToFirstFrameElement(); // Go to Frame1

                string firstName = firstFramePage.GetNameFromFirstFrame(); //Get a name

                secondFramePage.SwitchToSelfFrameTwo(); // Return to Frame2


                string lastName = secondFramePage.GetNameTextField(); // Get Last Name

                iFramePage.SwitchToSelf(); // Go to parent page

                string fullName = String.Concat(firstName, " ", lastName);

                iFramePage.InputName(fullName);

                iFramePage.ClickUserNameButton();

                string actFullName = iFramePage.GetResult();


                AssertCorrectData(fullName, actFullName);






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


        private static void AssertCorrectData(string expectedString, string actualString)
        {
            if (expectedString != actualString)
            {
                throw new Exception($"Actual data {actualString} is not equal to expected one {expectedString}");
            }

            else
            {
                Out.WriteLine($"Data is correct. Expected data: {expectedString}; Actual data: {actualString}");
            }
        }
    }
}
