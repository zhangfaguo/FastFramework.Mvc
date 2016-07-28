using FastFramework.Repositorys.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace FastFramework.Repositorys.Components
{
 
    public class LogRepository : ILogRepository
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
