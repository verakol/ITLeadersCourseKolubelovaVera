namespace ConsoleApp.WebDriver
{
    using ConsoleApp.WebDriver.Pages.Lesson4Select;
    using System;
    using System.Collections.Generic;
    using static ConsoleApp.CSharpBasics.IO.Output;

    class Program : BaseTest
    {
        public readonly static string url = AppDomain.CurrentDomain.BaseDirectory
            + @"\Appendix\Lessons\Lesson4_Select\select.html";

        static void Main(string[] args)
        {

            try
            {
                SelectPage selectPage = NavigateTo<SelectPage>(url);

                string[] optionToBeSelected = { "Mike", "Jane", "Michel" };

                selectPage.SelectOptionsInMultipleSelectByText(optionToBeSelected); // 1. In Multiple select make a selection of 3 options.
                List<string> expectedOption = selectPage.GetSelectedOptionsFromMultipleSelect(); // 2. Get all selected options

                //for (int i = 0; i < optionToBeSelected.Length; i++)
                //{
                //    Out.WriteLine($"Actual option: {optionToBeSelected[i]}");
                //}

                //for (int i = 0; i < expectedOption.Count; i++)
                //{
                //    Out.WriteLine($"Expected option: {expectedOption[i]}");
                //}

                Out.WriteLine($"Expected option: " + String.Join(", ", expectedOption));

                //AssertThatSelectedOptionsAreEqual(expectedOption, optionToBeSelected); // 2. check all selected options out if they are all as expected.

                string deselectOption = "Michel";

                selectPage.DeselectByText(deselectOption); // 3. Deselect one option in the multiple select.

                List<string> expectedOptionAfterDeselect = selectPage.GetSelectedOptionsFromMultipleSelect(); // 4. Get left options form Multiple select and check them if they are as expected.

                selectPage.DeselectAll(); // 5.Deselect all options in the multiple select.

                List<string> expectedOptionAfterDeselectAll = selectPage.GetSelectedOptionsFromMultipleSelect(); //6.Check out that all options were deselected.

            }
            catch (Exception)
            {
            }
            finally
            {
                DisposeTest();
            }
        }

        private static void AssertThatSelectedOptionsAreEqual(List<string> expectedOption, string[] optionToBeSelected)
        {
            int expectedOptoinCount = expectedOption.Count;
            int optionToBeSelectedLenth = optionToBeSelected.Length;


            if (expectedOption.Count == optionToBeSelected.Length)

            {
                Out.WriteLine("OK");

                foreach (var actOpt in optionToBeSelected)
                {
                    if (actOpt)
                    {
                        throw new Exception($"");
                    }
                }
            }
            else
            {
                throw new Exception("Lengths of expected and actual lists aren't equal");
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
