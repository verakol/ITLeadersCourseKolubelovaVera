namespace ConsoleApp.WebDriver
{
    using ConsoleApp.WebDriver.Pages.Lesson3Forms;
    using System;

    class Program : BaseTest
    {
        public readonly static string url = AppDomain.CurrentDomain.BaseDirectory
            + @"\Appendix\Lessons\Lesson3_Forms\forms.html";

        static void Main(string[] args)
        {
            try
            {
                var formPage = NavigateTo<FormPage>(url);

                formPage.ChooseElement("high school");
            }
            catch (Exception)
            {
            }
            finally
            {
                DisposeTest();
            }
        }
    }
}
