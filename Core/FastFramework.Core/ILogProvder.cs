using System;

namespace FastFramework.Core
{
    public interface ILogProvider
    {
        void Log(string logName, string msg);

        void Log(string logName, Exception ex);
    }
}
