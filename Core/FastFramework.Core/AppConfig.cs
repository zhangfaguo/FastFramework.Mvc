using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    public class AppConfig
    {
        static AppConfig _ins;
       
        static AppConfig()
        {
            _ins = new AppConfig();
        }

        public static AppConfig Instance
        {
            get
            {
                return _ins;
            }
        }

        public IAppContianer Container
        {
            get;
            set;
        }

        public static IAppContianer Containers
        {
            get
            {
                return _ins.Container;
            }
            set
            {
                _ins.Container = value;
            }
        }
    }
}
