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
            string expectedEduLevelInput = "High School";
            try
            {
                var formPage = NavigateTo<FormPage>(url);

                formPage.ChooseElement("high school");

                string actualEduLevelInput = formPage.GetEduLevelOption();
                

                AssertThatEduLevelInputIsCorrect(expectedEduLevelInput, actualEduLevelInput);
                
                formPage.ClickResetEduLevelButton();

                string actualEduLevelInputAfterReset = formPage.GetEduLevelOption();

                AssertThatEduLevelResetInputIsCorrect("", actualEduLevelInputAfterReset);
            }
            catch (Exception)
            {
            }
            finally
            {
                DisposeTest();
            }
        }

        private static void AssertThatEduLevelInputIsCorrect(string expectedEduLevelInput, string actualEduLevelInput)
        {
            if (expectedEduLevelInput != actualEduLevelInput)
            {
                throw new Exception($"Actual message {actualEduLevelInput} is not equal to expected one {expectedEduLevelInput}");
            }
        }

        private static void AssertThatEduLevelResetInputIsCorrect(string expectedEduLevelInputAfterReset, string actualEduLevelInputAfterReset)
        {
            if (expectedEduLevelInputAfterReset != actualEduLevelInputAfterReset)
            {
                throw new Exception($"Actual message {actualEduLevelInputAfterReset} is not equal to expected one {expectedEduLevelInputAfterReset}");
            }
        }
    }
}
