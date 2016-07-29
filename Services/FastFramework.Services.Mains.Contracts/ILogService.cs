using System;

namespace FastFramework.Services.Mains.Contracts
{
    public interface ILogService
    {
        void Log(string logName, string msg);

        void Log(string logName, Exception ex);
    }
}
