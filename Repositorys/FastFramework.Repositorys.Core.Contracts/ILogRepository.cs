using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Repositorys.Core.Contracts
{
    public interface ILogRepository : IRepository
    {
        void Log(string logName, string msg);

        void Log(string logName, Exception ex);
    }
}
