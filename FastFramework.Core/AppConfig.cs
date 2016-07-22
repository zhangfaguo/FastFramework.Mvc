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

        public ObjectContainer Container
        {
            get
            {
                return ObjectContainer.Instance;
            }
        }
    }
}
