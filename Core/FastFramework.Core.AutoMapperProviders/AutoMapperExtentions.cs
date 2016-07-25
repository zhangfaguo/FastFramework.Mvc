using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core.AutoMapperProviders
{
    public static class AutoMapperExtentions
    {
        public static AppConfig UseAutoMapper(this AppConfig cfg)
        {
            cfg.Mapper = new AutoMapperProvider();
            return cfg;
        }
    }
}
