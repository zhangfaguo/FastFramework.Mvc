using FastFramework.Core;
using FastFramework.Repositorys.Main;
using FastFramework.Repositorys.Main.Contracts;

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
