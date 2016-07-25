using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Services.Mains.Contracts
{
    public interface ILogService
    {
        void Log(string logName, string msg);

        void Log(string logName, Exception ex);
    }
}
