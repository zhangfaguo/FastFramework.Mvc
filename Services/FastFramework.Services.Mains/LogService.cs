using FastFramework.Core;
using FastFramework.Services.Mains.Contracts;
using System;

namespace FastFramework.Services.Mains
{
    public class LogService : ILogService
    {
        protected ILogProvider logProvider { get; set; }

        public LogService(ILogProvider _log)
        {
            logProvider = _log;
        }

        public void Log(string logName, string msg)
        {
            logProvider.Log(logName, msg);
        }


        public void Log(string logName, Exception ex)
        {
            logProvider.Log(logName, ex);
        }
    }
}
