using FastFramework.Core.AutofacContainers;

namespace FastFramework.Core
{
    public static class AutofacContainerExtentions
    {
        /// <summary>
        /// 使用AUTOFAC IOC容器
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns></returns>
        public static AppConfig UseAutofac(this AppConfig cfg)
        {
            cfg.Container = new AutofacContainerProvider();
            return cfg;
        }
    }
}
