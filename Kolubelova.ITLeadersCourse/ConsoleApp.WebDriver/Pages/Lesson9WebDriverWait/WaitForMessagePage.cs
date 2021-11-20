using OpenQA.Selenium;
using ExpectedCondition = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.WebDriver.Pages.Lesson9WebDriverWait
{
    public class WaitForMessagePage : BasePage
    {
        private IWebElement LaunchCideExecutionButton => FindElement(By.Id("launchButton"));

        private IWebElement TryToClickButton => FindElement(By.Id("messageButton"));

        private By MessageLocator => By.Id("message");
        private IWebElement MessageElement => FindElement(MessageLocator);

        public WaitForMessagePage ClickOnLaunchButton()
        {
            LaunchCideExecutionButton.Click();

            return this;
        }

        public WaitForMessagePage ClickOnTryToClickButton()
        {
            base.WebDriverWait.Until(ExpectedCondition.ElementToBeClickable(TryToClickButton));

            TryToClickButton.Click();

            return this;
        }

        public string GetMessage()
        {
            base.WebDriverWait.Until(ExpectedCondition.ElementIsVisible(MessageLocator));

               string message = MessageElement.Text;

            return message;
        }

    }
}
