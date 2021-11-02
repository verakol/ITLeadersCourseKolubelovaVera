namespace ConsoleApp.WebDriver.Pages.Lesson3Forms
{
    using OpenQA.Selenium;
    using System.Collections.Generic;

    public class FormPage : BasePage
    {
        private IWebElement NameInput => Driver.FindElement(By.Id("firstlast"));

        private IWebElement EmailInput => Driver.FindElement(By.Id("email"));

        private IWebElement SubmitButton => Driver.FindElement(By.CssSelector("input[type='submit']"));

        private IWebElement ResetButton => Driver.FindElement(By.CssSelector("fieldset input[type='reset']"));

        private IWebElement EduLevelInput => Driver.FindElement(By.CssSelector("input[name='education']")); //Education completed dropdown

        private IList<IWebElement> DropDownList => Driver.FindElements(By.CssSelector("datalist#edulevel option")); // create list with values


        private IWebElement EducationCompletedResetButton => Driver.FindElement(By.CssSelector("form p input[type='reset']")); //Reset button near Education completed dropdown

        
        // method that perform chosing an option from Education completed dropdown and insert it in its text input field
        public void ChooseElement(string option)
        {
            foreach (var opt in DropDownList)
            {
                var optionValue = opt.GetAttribute("value");

                if (option.Equals(optionValue, System.StringComparison.OrdinalIgnoreCase))
                {
                    EduLevelInput.SendKeys(optionValue);
                    EduLevelInput.SendKeys(Keys.Tab);
                }
            }
        }
        public FormPage InputName(string name)
        {
            NameInput.SendKeys(name);

            return this;
        }

        public FormPage InputEmail(string email)
        {
            EmailInput.SendKeys(email);

            return this;
        }

        public string GetName()
        {
            return NameInput.GetAttribute("value");
        }

        public string GetEmail()
        {
            return EmailInput.GetAttribute("value");
        }

        public SubmitPage ClickSubmitButton()
        {
            SubmitButton.Click();

            return new SubmitPage();
        }

        public FormPage ClickResetButton()
        {
            ResetButton.Click();

            return this;
        }



    }
}
