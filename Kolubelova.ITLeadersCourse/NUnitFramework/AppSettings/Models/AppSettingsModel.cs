﻿using NUnitFramework.Enums;

namespace NUnitFramework.AppSettings.Models
{
    public class AppSettingsModel
    {
        public string BaseUrl { get; set; }

        public BrowserType Browser { get; set; }

        public LoggerType Logger { get; set; }

        public PathsModel Paths { get; set; }

        public class PathsModel
        {
            public string ScreenshotsOutput { get; set; }
        }
    }
}
