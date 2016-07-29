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

        /// <summary>
        /// 装修JSON字符串转换成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T ToObject<T>(this string source)
        {
            return AppConfig.JsonConverts.ToObject<T>(source);
        }

        /// <summary>
        /// 将对象转换成JSON字符串
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToJson(this object source)
        {
            return AppConfig.JsonConverts.ToJson(source);
        }
    }
}
