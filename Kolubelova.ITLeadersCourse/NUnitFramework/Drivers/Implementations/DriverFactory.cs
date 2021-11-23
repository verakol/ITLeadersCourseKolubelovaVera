namespace NUnitFramework.Drivers.Implementations
{
    using NUnitFramework.Drivers.Interfaces;
    using NUnitFramework.Enums;
    using System;

    public class DriverFactory : IDriverFactory
    {
        public override IDriver GetDriver(BrowserType driverType)
        {
            return driverType switch
            {
                BrowserType.Chrome => new Chrome(),
                _ => throw new PlatformNotSupportedException($"{driverType} browser is not supported!")
            };
        }
    }
}
