using NUnitFramework.Drivers;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace NUnitFramework.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver { get; }

        public BasePage()
        {
            Driver = WebDriverManager.Driver;
        }

        protected IWebElement FindElement(By by) => Driver.FindElement(by);

        protected IList<IWebElement> FindElements(By by) => Driver.FindElements(by);
    }
}
