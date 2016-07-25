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

        public static IAppContianer UserDb(this IAppContianer cfg)
        {

            cfg.RgeistSingle<DbContext, Context>();

            return cfg;

        }
    }
}
