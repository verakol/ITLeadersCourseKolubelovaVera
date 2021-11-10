﻿namespace ConsoleApp.WebDriver
{
    using ConsoleApp.WebDriver.Pages.Lesson5Modals;
    using System;
    using static ConsoleApp.CSharpBasics.IO.Output;

    class Program : BaseTest
    {
        public readonly static string url = AppDomain.CurrentDomain.BaseDirectory
            + @"\Appendix\Lessons\Lesson5_Modals\modals.html";

        static void Main(string[] args)
        {

            try
            {
                ModalsPage modalsPage = NavigateTo<ModalsPage>(url);

                var expectedEmail = "john@gmail.com";

                modalsPage.ClickSubmitEmailButton();

                modalsPage.InputEmailAndAcceptAlert(expectedEmail); // 3, 4. Enter email in Promt modal and accept the Promt

                var actualEmail = modalsPage.GetEmailSubmittedMessage().Split(":")[1].TrimStart(); // 6. Get promted message

                AssertThatEmailIsCorrect(expectedEmail, actualEmail); // 7. compare promted message with expected one


                modalsPage.ClickSubmitEmailButton();

                modalsPage.InputEmailAndDismissAlert(expectedEmail); // step 8, 9. Dismiss Promt modal

                var expectedDismissMes = "Email submission canceled!";

                var actualDismissMes = modalsPage.GetEmailSubmittedMessage(); // 10. Get promted dismissed message

                AssertThatDismissedMesIsCorrect(expectedDismissMes, actualDismissMes); // 10. compare promted dismissed message with expected one



                var emptyString = string.Empty;

                modalsPage.ClickSubmitEmailButton();

                modalsPage.InputEmailAndAcceptAlert(emptyString); // 12. Input empty string in Promt modal and accept the Promt

                var expectedEmptyStringMes = "Please, input your email!";

                var actualEmptyStringMes = modalsPage.GetEmailSubmittedMessage(); // 13. Get emty string message

                AssertThatEmptyEmailMesIsCorrect(expectedEmptyStringMes, actualEmptyStringMes); // 10. compare emty string message with expected one

            }
            catch (Exception)
            {
            }
            finally
            {
                DisposeTest();
            }
        }


        private static void AssertThatEmailIsCorrect(string expectedEmail, string actualEmail)
        {
            if (expectedEmail != actualEmail)
            {
                throw new Exception($"Actual email {actualEmail} is not equal to expected one {expectedEmail}");
            }

            else
            {
                Out.WriteLine($"Emails are equal. Expected email: {expectedEmail}; Actual email: {actualEmail}");
            }
        }

        private static void AssertThatDismissedMesIsCorrect(string expectedDismissMes, string actualDismissMes)
        {
            if (expectedDismissMes != actualDismissMes)
            {
                throw new Exception($"Actual mes {actualDismissMes} is not equal to expected one {expectedDismissMes}");
            }

            else
            {
                Out.WriteLine($"Messages are equal. Expected mes: {expectedDismissMes}; Actual mes: {actualDismissMes}");
            }
        }

        private static void AssertThatEmptyEmailMesIsCorrect(string expectedEmptyStringMes, string actualEmptyStringMes)
        {
            if (expectedEmptyStringMes != actualEmptyStringMes)
            {
                throw new Exception($"Actual mes {actualEmptyStringMes} is not equal to expected one {expectedEmptyStringMes}");
            }

            else
            {
                Out.WriteLine($"Messages are equal. Expected mes: {expectedEmptyStringMes}; Actual mes: {actualEmptyStringMes}");
            }
        }
    }
}
