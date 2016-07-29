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
            cfg.Container.RegistSingle<ICacheProvider, MemeryCacheProvider>();
            cfg.Container.RegistType<ILogProvider, LogNetProvider>();
            cfg.Container.RegistSingle<IJsonProvider, NetJsonProvider>();

            cfg.JsonConvert = cfg.Container.Reloser<IJsonProvider>();
            cfg.LogProvider = cfg.Container.Reloser<ILogProvider>();
            return cfg;
        }
    }
}
