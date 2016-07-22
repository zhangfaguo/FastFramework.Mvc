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
        public static AppConfig UserCenterAutofac(this AppConfig cfg)
        {
            cfg.Container.Regeister<UserCenterService, IUserCenterService>();
            return cfg;
        }
    }
}
