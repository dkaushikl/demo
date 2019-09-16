﻿namespace Demo.API.Common.LoggerService
{
    public interface ILoggerManager
    {
        void LogDebug(string message);

        void LogError(string message);

        void LogInfo(string message);

        void LogWarn(string message);
    }
}