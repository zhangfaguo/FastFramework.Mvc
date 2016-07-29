using FastFramework.Core;
using FastFramework.DataLib;
using System.Data.Entity;

namespace FastFrameword.AutofacConfig
{
    public
        static class DbConfigExtentions
    {

        public static IAppContianer RegisterDB(this IAppContianer cfg)
        {

            cfg.RegistTypeByThreadLife<DbContext, Context>();

            return cfg;

        }
    }
}
