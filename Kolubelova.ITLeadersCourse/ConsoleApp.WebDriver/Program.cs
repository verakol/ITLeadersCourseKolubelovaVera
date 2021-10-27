using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;

namespace ConsoleApp.WebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new InternetExplorerDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://google.com");

            driver.Close();
            driver.Quit();
        }
    }
}
