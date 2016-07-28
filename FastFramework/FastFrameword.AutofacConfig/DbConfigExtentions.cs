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

        public static IAppContianer RegisterDB(this IAppContianer cfg)
        {

            cfg.RgeistSingle<DbContext, Context>();

            return cfg;

        }
    }
}
