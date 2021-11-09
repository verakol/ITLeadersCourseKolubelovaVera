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

        public void SelectOptionsInMultipleSelectByText(params string[] name)
        {
            SelectElement select = new SelectElement(MultipleSelect);

            foreach (var opt in name)
            {
                select.SelectByText(opt);
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

        public void DeselectByText(string name)
        {
            SelectElement select = new SelectElement(MultipleSelect);

            foreach (var opt in select.AllSelectedOptions)
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
