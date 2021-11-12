using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows
{
    public class NewBrowserTabPage : BasePage
    {
        private IWebElement TitleText => FindElement(By.XPath("//head/title['Automation Practice | Ultimate QA']"));

        public string GetTitle()
        {
            return TitleText.Text;
        }
    }
}