using FastFramework.Core;
using NLog;
using System;

namespace FastFrameword.Core.NLogProviders
{
    public class NLogProviders : ILogProvider
    {
        public void Log(string logName, string msg)
        {
            LogManager.GetLogger(logName).Info(msg);
        }

        public void Log(string logName, Exception ex)
        {
            LogManager.GetLogger(logName).Error(ex);
        }
    }
}
