using log4net;
using System;

namespace FastFramework.Core.LogNetProvider
{
    public class LogNetProvider : ILogProvider
    {
        public void Log(string logName, string msg)
        {
            LogManager.GetLogger(logName).Info(msg);
        }

        public void Log(string logName, Exception ex)
        {
            LogManager.GetLogger(logName).Error(ex.Message, ex);
        }
    }
}
