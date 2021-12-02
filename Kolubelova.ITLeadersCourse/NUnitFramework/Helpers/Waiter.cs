using NUnitFramework.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace NUnitFramework.Helpers
{
    public static class Waiter
    {
        private static TimeSpan DefaultTimeout { get; } = TimeSpan.FromSeconds(15);

        private static WebDriverWait WebDriverWait =>
            new(WebDriverManager.Driver, DefaultTimeout);

        public static IAlert WaitUntilAlertIsDisplayed() =>
            WebDriverWait.Until(ExpectedConditions.AlertIsPresent());
    }
}
