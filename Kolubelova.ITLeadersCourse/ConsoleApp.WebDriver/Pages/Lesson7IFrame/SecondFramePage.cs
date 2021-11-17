using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Pages.Lesson7IFrame
{
    public class SecondFramePage : BasePage
    {

        private IWebElement FirstFrameElement => FindElement(By.Id("innerFrame"));
        private IWebElement LastNameTextField => FindElement(By.Id("lastName"));

        public FirstFramePage SwitchToFirstFrameElement()
        {
            Driver.SwitchTo().Frame(FirstFrameElement);

            return new FirstFramePage();

        }


        public string GetNameTextField() => LastNameTextField.Text.Split(": ")[1];
    }
}
