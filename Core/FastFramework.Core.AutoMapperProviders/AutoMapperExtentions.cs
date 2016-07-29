using AutoMapper.Configuration;
using FastFramework.Core.AutoMapperProviders;

namespace FastFramework.Core
{
    public static class AutoMapperExtentions
    {
        /// <summary>
        /// 初始化AUTOMapper组件
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns></returns>
        public static AppConfig UseAutoMapper(this AppConfig cfg)
        {
            AutoMapper.Mapper.Initialize(new MapperConfigurationExpression()
            {
                CreateMissingTypeMaps = true
            });

            cfg.Mapper = new AutoMapperProvider();
            return cfg;
        }
    }
}
