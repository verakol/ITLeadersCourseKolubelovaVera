using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Pages.Lesson7IFrame
{

    public class IFramePage : BasePage
    {
        private IWebElement FirstFrameElement => FindElement(By.Id("frame1"));

        private IWebElement IFrameHeader => FindElement(By.Id("pageHeader"));

        public FirstFramePage SwitchToFirstFrame()
        {
            Driver.SwitchTo().Frame(FirstFrameElement);

            return new FirstFramePage();
        }

        public string GetIFrameHeader() => IFrameHeader.Text;

        public IFramePage SwitchToSelf()
        {
            Driver.SwitchTo().DefaultContent();

            return this;
        }

        /// For Home Task

        private IWebElement SecondFrameElement => FindElement(By.XPath("//iframe[@id='frame2']"));

        private IWebElement InputUserName => FindElement(By.Id("userName"));

        private IWebElement CheckUserNameButton => FindElement(By.Id("checkUserName"));

        private IWebElement Result => FindElement(By.Id("output"));

        public SecondFramePage SwitchToSecondFrame()
        {
            Driver.SwitchTo().Frame(SecondFrameElement);

            return new SecondFramePage();
        }

        public IFramePage InputName(string name)
        {
            InputUserName.SendKeys(name);

            return this;
        }

        public IFramePage ClickUserNameButton()
        {
            CheckUserNameButton.Click();

            return new IFramePage();
        }


        public string GetResult()
        {
            return Result.Text.Split(": ")[1];

        }



    }
}
