using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows
{
    public class AdditionalWindowsPage : BasePage
    {
        private IWebElement NewBrowserWindowButton => FindElement(By.Id("button1"));

        private IWebElement NewMessageWindowButton => FindElement(By.CssSelector("#content > div:nth-child(4) > p > button"));

        private IWebElement NewBrowserTabButton => FindElement(By.CssSelector("#content > div:nth-child(5) > p:nth-child(1) > button"));

        public NewBrowserWindowPage ClickNewBrowserWindowButton()
        {
            NewBrowserWindowButton.Click();

            return new NewBrowserWindowPage();
        }

        public NewMessageWindowPage ClickNewMessageWindowButton()
        {
            NewMessageWindowButton.Click();

            return new NewMessageWindowPage();
        }

        public NewBrowserTabPage ClickNewBrowserTabButton()
        {
            NewBrowserTabButton.Click();

            return new NewBrowserTabPage();
        }

    }

}
