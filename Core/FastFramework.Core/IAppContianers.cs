using System;
using System.Collections.Generic;
using System.Reflection;

namespace FastFramework.Core
{
    public interface IAppContianer
    {

        #region  Reloser
        T Reloser<T>();

        T Reloser<T>(string name);

        IEnumerable<T> ReloserAll<T>();

        object Reloser(Type type);
        #endregion


        #region Register
        void RegistType(Type from, Type to);

        void RegistType<T1, T2>(string name = "") where T2 : T1;

        void RegistTypeByThreadLife<T1, T2>() where T2 : T1;

        void RegistSingle<T1, T2>(string name = "") where T2 : T1;

        #endregion

        /// <summary>
        /// 获取IOC原始容器
        /// </summary>
        /// <returns></returns>
        object GetContainer();

        /// <summary>
        /// 加载配置文件 
        /// </summary>
        /// <returns></returns>
        void LoadConfig();

        void UseMvcContianer(Assembly assembly);
    }
}
