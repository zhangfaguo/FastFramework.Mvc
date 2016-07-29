using FastFramework.Core.UnityContainers;

namespace FastFramework.Core
{
    public static class UnityContainerExtentions
    {
        /// <summary>
        /// 使用Unity Ioc容器
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns></returns>
        public static AppConfig UseUnity(this AppConfig cfg)
        {
            cfg.Container = new UnityContainerProvider();
            return cfg;
        }
    }
}
