using FastFramework.Core;
using FastFramework.DataLib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace FastFrameword.AutofacConfig
{
    public
        static class DbConfigExtentions
    {

        public static AppConfig UserDb(this AppConfig cfg)
        {

            cfg.Container.RegisterSingle<Context, DbContext>();

            return cfg;

        }
    }
}
