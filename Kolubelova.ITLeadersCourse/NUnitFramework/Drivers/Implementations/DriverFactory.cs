﻿namespace NUnitFramework.Drivers.Implementations
{
    using NUnitFramework.Drivers.Interfaces;
    using NUnitFramework.Enums;
    using System;

    public class DriverFactory : IDriverFactory
    {
        public override IDriver GetDriver(BrowserType browserType)
        {
            return browserType switch
            {
                BrowserType.Chrome => new Chrome(),
                _ => throw new PlatformNotSupportedException($"{browserType} browser is not supported!")
            };
        }
    }
}
