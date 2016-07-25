using FastFramework.Core.AutofacContainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    public static class AutofacContainerExtentions
    {
        public static AppConfig UseAutofac(this AppConfig cfg)
        {
            cfg.Container = new AutofacContainerProvider();
            return cfg;
        }
    }
}
