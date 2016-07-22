using Autofac;
using Autofac.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    public class ObjectContainer
    {
        IContainer container;

        #region coust
        static ObjectContainer()
        {
            _instance = new ObjectContainer();
        }

        public ObjectContainer()
        {
            var builder = new ContainerBuilder();
            container = builder.Build();
        }

        #endregion

        static ObjectContainer _instance;
        public static ObjectContainer Instance
        {
            get
            {
                return _instance;
            }
        }

        public IContainer AutofacContainer
        {
            get
            {
                return container;
            }
        }

        public void InitConfig()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            builder.Update(this.container);
        }

        public void Regeister<T, F>(string name = "")
        {
            var builder = new ContainerBuilder();
            if (string.IsNullOrEmpty(name))
                builder.RegisterType<T>().As<F>();
            else
                builder.RegisterType<T>().Named<F>(name);
            builder.Update(container);
        }

        /// <summary>
        /// 注册全局单例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="F"></typeparam>
        /// <param name="name"></param>
        public void RegisterSingle<T, F>(string name = "")
        {
            var builder = new ContainerBuilder();
            if (string.IsNullOrEmpty(name))
                builder.RegisterType<T>().As<F>().SingleInstance();
            else
                builder.RegisterType<T>().Named<F>(name).SingleInstance();
            builder.Update(container);
        }


        public T Resolve<T>(string name = "")
        {
            if (string.IsNullOrEmpty(name))
                return container.Resolve<T>();
            else
                return container.ResolveNamed<T>(name);
        }
    }
}
