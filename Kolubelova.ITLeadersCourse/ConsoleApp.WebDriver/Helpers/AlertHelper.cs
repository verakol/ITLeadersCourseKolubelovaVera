namespace ConsoleApp.WebDriver.Helpers
{
    using ConsoleApp.WebDriver.Drivers;

    public static class AlertHelper
    {
        public static string AcceptAlert()
        {
            var alert = WebDriverManager.Driver.SwitchTo().Alert();

            var alertMessage = alert.Text;
            alert.Accept();

            WebDriverManager.Driver.SwitchTo().DefaultContent();

            return alertMessage;
        }

        public static void DismissAlert()
        {
            WebDriverManager.Driver.SwitchTo().Alert().Dismiss();
            WebDriverManager.Driver.SwitchTo().DefaultContent();
        }

        //email input method implemention
        public static void InputEmailAndAcceptAlert(string text)
        {
            var alert = WebDriverManager.Driver.SwitchTo().Alert();

            alert.SendKeys(text);
            alert.Accept();

            WebDriverManager.Driver.SwitchTo().DefaultContent();
        }

        public static void InputEmailAndDismissAlert(string text)
        {
            var alert = WebDriverManager.Driver.SwitchTo().Alert();

            alert.SendKeys(text);
            alert.Dismiss();

            WebDriverManager.Driver.SwitchTo().DefaultContent();
        }
    }
}
