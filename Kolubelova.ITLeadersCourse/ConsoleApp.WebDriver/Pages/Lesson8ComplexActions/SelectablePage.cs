using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using static ConsoleApp.CSharpBasics.IO.Output;

namespace ConsoleApp.WebDriver.Pages.Lesson8ComplexActions
{
    public class SelectablePage : BasePage
    {
        private IWebElement DemoFrame => FindElement(By.ClassName("demo-frame"));

        private IList<IWebElement> OptionsForSelect => FindElements(By.ClassName("ui-selectee")); 


        public SelectablePage SwitchToDemoFrame()
        {
            Driver.SwitchTo().Frame(DemoFrame);

            return this;
        }

        public SelectablePage SwitchToSelf()
        {
            Driver.SwitchTo().DefaultContent();

            return this;

        }
        private IWebElement Item1 => FindElement(By.XPath("//li[text()='Item 1']"));
        public SelectablePage ChooseItem()
        {
            Actions actions = new Actions(Driver);
            actions.ClickAndHold(Item1)
                .Build()
                .Perform();

            return this;

        }

        
        public void SelectItems() //// selecting of every odd option in the list
        {
            Actions actions = new Actions(Driver);

            actions.KeyDown(Keys.LeftControl);

            for (int i = 0; i < OptionsForSelect.Count; i++)
            {
                if ((i % 2) == 0)
                {
                    actions.Click(OptionsForSelect[i]);
                }
            }

            actions.KeyUp(Keys.LeftControl)

                .Build()
                .Perform();

        }

        private IList<IWebElement> ListOptions => FindElements(By.XPath("//ol[@id='selectable']/li")); //Get selected options names
        public List<string> GetSelectedItems()
        {
            List<string> chosenOptions = new List<string>();

            foreach (var opt in ListOptions)
            {
                var attribute = opt.GetAttribute("class");

                if (attribute.Contains("ui-selected"))
                {
                    chosenOptions.Add(opt.Text);
                }
            }

            return chosenOptions;
        }
    }
}
