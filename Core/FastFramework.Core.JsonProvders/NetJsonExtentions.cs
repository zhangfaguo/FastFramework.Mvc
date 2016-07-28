using FastFramework.Core.JsonProvders;
using System;

namespace FastFramework.Core
{
    public static class NetJsonExtentions
    {
        /// <summary>
        /// 使用newtosoft Json组件
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns></returns>
        public static AppConfig UseJson(this AppConfig cfg)
        {
            cfg.JsonConvert = new NetJsonProvider();
            return cfg;
        }
    }
}
