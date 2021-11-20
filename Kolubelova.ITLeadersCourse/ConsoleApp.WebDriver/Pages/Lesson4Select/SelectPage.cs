namespace ConsoleApp.WebDriver.Pages.Lesson4Select
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.Collections.Generic;

    public class SelectPage : BasePage
    {
        private IList<IWebElement> GeneralSelectOptions => FindElements(By.XPath("//select[@id='namesList']/option"));

        private IWebElement GeneralSelect => FindElement(By.CssSelector("select#namesList"));

        private IWebElement GroupedSelect => FindElement(By.CssSelector("select#groupedNames"));

        private IWebElement MultipleSelect => FindElement(By.CssSelector("select#multipleNames"));

        private IList<IWebElement> MultipleSelectOptions => FindElements(By.XPath("//select[@id='multipleNames']/option"));


        public void SelectNameInGeneralSelect(string name)
        {
            foreach (var element in GeneralSelectOptions)
            {
                if (name.Equals(element.Text, StringComparison.OrdinalIgnoreCase))
                {
                    element.Click();
                }
            }
        }

        public string GetSelectedNameInGeneralSelect()
        {
            return GeneralSelect.Text;
        }

        public void SelectOptionInGeneralSelect(string name)
        {
            var select = new SelectElement(GeneralSelect);

            select.SelectByText(name);

        }

        public string GetSelectedOptionInGeneralSelect()
        {
            return new SelectElement(GeneralSelect).SelectedOption.Text;
        }

        public void SelectOptionInGroupedSelect(string name)
        {
            var select = new SelectElement(GroupedSelect);

            select.SelectByText(name);
        }

        public string GetSelectedOptionInGroupedSelect()
        {
            return new SelectElement(GroupedSelect).SelectedOption.Text;
        }

        public void SelectOptionsInMultipleSelectByText(params string[] names)
        {
            SelectElement select = new SelectElement(MultipleSelect);

            foreach (var name in names)
            {
                select.SelectByText(name);
            }
        }

        public List<string> GetSelectedOptionsFromMultipleSelect()
        {
            SelectElement select = new SelectElement(MultipleSelect);

            var selectedOptions = new List<string>();

            foreach (var opt in select.AllSelectedOptions)
            {
                selectedOptions.Add(opt.Text);
            }

            return selectedOptions;
        }

        public void DeselectByText(params string[] names)
        {
            SelectElement select = new SelectElement(MultipleSelect);

            foreach (var name in names)
            {
                select.DeselectByText(name);
            }
            
        }

        public void DeselectAll()
        {
            SelectElement select = new SelectElement(MultipleSelect);

            select.DeselectAll();
        }
    }
}
