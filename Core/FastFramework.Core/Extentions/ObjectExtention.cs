using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    public static class ObjectExtention
    {
        /// <summary>
        /// 对象类型转换 
        /// 
        /// 使用前  请在程序启动时调用 AutoMapperExtentions.UseAutoMapper方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T To<T>(this object source)
        {
            return AppConfig.Mappers.Map<T>(source);
        }
    }
}
