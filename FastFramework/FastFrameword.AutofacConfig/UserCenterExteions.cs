using FastFramework.Core;
using FastFramework.Services.Mains;
using FastFramework.Services.Mains.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastFrameword.AutofacConfig
{
    public static class UserCenterExteions
    {
        public static IAppContianer RegisterService(this IAppContianer cfg)
        {
            cfg.RegistType<IUserCenterService, UserCenterService>();

            cfg.RegistType<ILogService, LogService>();
            cfg.RegistType<ICacheService, CacheService>();

            return cfg;
        }
    }
}
