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

        public SecondFramePage SwitchToSelfFrameTwo()
        {
            Driver.SwitchTo().DefaultContent();

            return new SecondFramePage();
        }



        public string GetNameTextField() => LastNameTextField.Text.Split(": ")[1];
    }
}
