using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows
{
    public class NewMessageWindowPage : BasePage
    {
        private IWebElement MessageText => FindElement(By.XPath("//body('Knowledge increases by sharing but not by saving.Please share this website with your friends and in your organization.')"));

        public string GetMessage()
        {
            return MessageText.Text;
        }
    }
}
