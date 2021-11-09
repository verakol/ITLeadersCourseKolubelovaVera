namespace ConsoleApp.WebDriver.Pages
{
    using ConsoleApp.WebDriver.Drivers;
    using OpenQA.Selenium;
    using System.Collections.Generic;

    public class BasePage
    {
        protected IWebDriver Driver { get; }

        public BasePage()
        {
            this.Driver = WebDriverManager.Driver;
        }

        protected void NavigateBack()
        {
            Driver.Navigate().Back();
        }

        protected IWebElement FindElement(By locator)
        {
            return Driver.FindElement(locator);
        }

        protected IList<IWebElement> FindElements(By locator)
        {
            return Driver.FindElements(locator);
        }
    }
}
