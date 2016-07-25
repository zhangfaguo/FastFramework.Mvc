using FastFramework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using FastFramework.Repositorys.Main;
using FastFramework.Repositorys.Main.Contracts;
using System.Data.Entity;
using FastFramework.Repositorys.Core;

namespace FastFrameword.AutofacConfig
{
    public static class MainRepositortyExtentions
    {
        public static IAppContianer RegistMainRepository(this IAppContianer cfg)
        {
            cfg.RegistType<IUserRepository, UserRepository>();

            return cfg;
        }

    }
}
