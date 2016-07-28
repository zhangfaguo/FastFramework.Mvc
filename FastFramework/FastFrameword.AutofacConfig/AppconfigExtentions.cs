using FastFramework.Core;
using FastFramework.Core.AutoMapperProviders;
using FastFramework.Core.CacheProviders;
using FastFramework.Core.JsonProvders;
using FastFramework.Core.LogNetProvider;

namespace FastFrameword.AutofacConfig
{
    public static class AppconfigExtentions
    {
        public static AppConfig Config(this AppConfig cfg)
        {
            cfg.Container.RgeistSingle<ICacheProvider, MemeryCacheProvider>();
            cfg.Container.RgeistSingle<IJsonProvider, NetJsonProvider>();
            cfg.Container.RgeistSingle<IMapper, AutoMapperProvider>();
            cfg.Container.RegistType<ILogProvider, LogNetProvider>();
     

            cfg.Mapper = cfg.Container.Reloser<IMapper>();
            cfg.JsonConvert = cfg.Container.Reloser<IJsonProvider>();

            return cfg;
        }
    }
}
