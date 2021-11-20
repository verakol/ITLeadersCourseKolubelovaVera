﻿using ConsoleApp.WebDriver.Pages.Lesson8ComplexActions;
using System;
using System.Collections.Generic;
using static ConsoleApp.CSharpBasics.IO.Output;
using static ConsoleApp.WebDriver.AppSettings.SettingsCongfigurator;


namespace ConsoleApp.WebDriver
{
    class Program : BaseTest
    {
        private static string url = AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.Url1Lesson8;
        static void Main(string[] args)
        {
            try
            {
                url = Settings.Urls.UrlLesson8HomeTask;

                var selectablePage = NavigateTo<SelectablePage>(url);

                selectablePage.SwitchToDemoFrame();

                //selectablePage.ChooseItem();

                selectablePage.SelectItems(); // selecting of every odd option in the list

                List<string> chosenOptions = selectablePage.GetSelectedItems(); // Get selected options names

                Out.WriteLine($"Chosen options are: " + String.Join(", ", chosenOptions)); //Print them in console

            }
            catch (Exception ex)
            {
                Out.WriteLine(ex);
            }
            finally
            {
                DisposeTest();
            }
        }
    }
}
