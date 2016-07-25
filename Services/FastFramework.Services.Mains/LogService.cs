using FastFramework.Repositorys.Core.Contracts;
using FastFramework.Services.Mains.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Services.Mains
{
    public class LogService : ILogService
    {
        protected ILogRepository log;

        public LogService(ILogRepository _log)
        {
            log = _log;
        }

        public void Log(string logName, string msg)
        {
            log.Log(logName, msg);
        }


        public void Log(string logName, Exception ex)
        {
            log.Log(logName, ex);
        }
    }
}
