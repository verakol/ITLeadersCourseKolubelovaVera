﻿namespace ConsoleApp.WebDriver.AppSettings.Models
{
    using ConsoleApp.WebDriver.Enums;

    public class AppSettingsModel
    {
        public BrowserType BrowserType { get; set; }

        public UrlsModel Urls { get; set; }

        public class UrlsModel
        {
            public string UrlLesson6 { get; set; }
            public string UrlLesson6HomeTask { get; set; }
            public string UrlLesson7 { get; set; }
            public string Url1Lesson8 { get; set; }
            public string Url2Lesson8 { get; set; }
            public string UrlLesson8HomeTask { get; set; }
        }
    }
}
