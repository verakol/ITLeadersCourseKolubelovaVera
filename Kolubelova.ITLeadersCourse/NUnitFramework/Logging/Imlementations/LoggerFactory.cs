namespace NUnitFramework.Logging.Imlementations
{
    using NUnitFramework.Enums;
    using NUnitFramework.Logging.Interfaces;
    using System;

    public class LoggerFactory : ILoggerFactory
    {
        public override ILoggerInstance GetLogger(LoggerType loggerType)
        {
            return loggerType switch
            {
                LoggerType.Log4Net => new Log4NetInstance(),
                _ => throw new PlatformNotSupportedException($"{loggerType} is not supported.")
            };
        }
    }
}
