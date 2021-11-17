using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows
{
    public class NewMessageWindowPage : BasePage
    {
        private IWebElement MessageText => FindElement(By.XPath("//body/p"));

        public string GetMessage()
        {
            char quotes = '"';
            return MessageText.Text.Trim(quotes);
        }
    }
}
