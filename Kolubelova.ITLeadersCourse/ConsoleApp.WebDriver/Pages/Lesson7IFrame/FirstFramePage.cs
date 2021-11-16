using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Pages.Lesson7IFrame
{

    public class FirstFramePage : BasePage
    {
        private IWebElement NameTextField => FindElement(By.Id("name"));

        public string GetNameTextField() => NameTextField.Text;

        public string GetNameFromFirstFrame() => NameTextField.Text.Split(": ")[1];
    }
}
