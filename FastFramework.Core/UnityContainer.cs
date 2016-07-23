using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShowTime.Core
{
    /// <summary>
    /// Unity管理工具
    /// </summary>
    public class UnityContaint
    {
        UnityContainer container;
        
        #region 构造函数

        private UnityContaint()
            : base()
        {
            container = new UnityContainer();
        }

        static UnityContaint _intanse;

        public static UnityContaint Instance
        {
            get
            {
                if (_intanse == null)
                    _intanse = new UnityContaint();
                return _intanse;
            }
        }

        #endregion

        #region  Reloser
        public T Reloser<T>() where T : class
        {
            return container.Resolve<T>();
        }

        public T Reloser<T>(string name) where T : class
        {
            return container.Resolve<T>(name);
        }

        public object Reloser(Type type)
        {
            return container.Resolve(type);
        }

        public IEnumerable<object> ReloserAll(Type type)
        {
            return container.ResolveAll(type);
        }

        #endregion

        public void RegistType(Type from, Type to)
        {
            container.RegisterType(from, to);
        }

        public void RegistType<T1, T2>(string name = "")
            where T1 : class
            where T2 : T1
        {

            if (string.IsNullOrEmpty(name))
                container.RegisterType<T1, T2>();
            else
                container.RegisterType<T1, T2>(name);
        }

        public void RegistTypeByThreadLife<T1, T2>()
            where T1 : class
            where T2 : T1
        {
            container.RegisterType<T1, T2>(new PerRequestLifetimeManager());
        }

        public ILogHelper GetLoger()
        {
            return container.Resolve<ILogHelper>();
        }

        #region 加载配置

        public void LoadConfig()
        {
            var sections = (UnityConfigurationSection)System.Configuration.ConfigurationManager.GetSection("unity");
            sections.Configure(container);

        }

        public void LoadConfig(string name)
        {
            var sections = (UnityConfigurationSection)System.Configuration.ConfigurationManager.GetSection("unity");
            sections.Configure(container, name);

        }
        #endregion

        public IUnityContainer GetContainer()
        {
            return container;

        }
    }
}
