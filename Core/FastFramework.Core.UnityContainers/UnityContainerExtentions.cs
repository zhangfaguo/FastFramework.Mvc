using FastFramework.Core.UnityContainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    public static class UnityContainerExtentions
    {
        public static AppConfig UseUnity(this AppConfig cfg)
        {
            cfg.Container = new UnityContainerProvider();
            return cfg;
        }
    }
}
