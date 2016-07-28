using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    public interface ILogProvider
    {
        void Log(string logName, string msg);

        void Log(string logName, Exception ex);
    }
}
