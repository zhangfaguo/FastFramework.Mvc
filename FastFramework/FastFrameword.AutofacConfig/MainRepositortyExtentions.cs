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
        public static AppConfig RegistMainRepository(this AppConfig cfg)
        {
            var buliber = new ContainerBuilder();

            Regist<UserRepository, IUserRepository>(buliber);
            buliber.Update(cfg.Container.AutofacContainer);

            return cfg;
        }

        private static void Regist<T, F>(ContainerBuilder buliber)
            where T : BaseRepository
        {
            buliber.RegisterType<T>().As<F>().OnActivated(e => e.Instance.Provider = e.Context.Resolve<DbContext>());
        }
    }
}
