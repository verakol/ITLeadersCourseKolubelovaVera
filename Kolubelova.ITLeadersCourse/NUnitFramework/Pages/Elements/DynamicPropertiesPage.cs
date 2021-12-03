using NUnitFramework.Helpers;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements
{
    public class DynamicPropertiesPage : BasePage
    {
        private IWebElement EnableAfterButton => FindElement(By.CssSelector("button#enableAfter"));

        public bool IsEnableAfterButtonEnabled()
        {
            return Waiter.WaitUntilElementToBeEnabled(EnableAfterButton);
        }
    }
}
