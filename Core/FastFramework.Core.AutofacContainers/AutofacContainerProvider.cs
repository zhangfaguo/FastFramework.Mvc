using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using System.Data.Entity;
using Autofac.Configuration;
using Autofac.Integration.Mvc;
using System.Reflection;
using System.Web.Mvc;

namespace FastFramework.Core.AutofacContainers
{
    internal class AutofacContainerProvider : IAppContianer
    {
        IContainer container;
        public AutofacContainerProvider()
        {
            var builder = new Autofac.ContainerBuilder();
            container = builder.Build();
        }

        public T Reloser<T>()
        {
            return container.Resolve<T>();
        }

        public T Reloser<T>(string name)
        {
            return container.ResolveNamed<T>(name);
        }

        public object Reloser(Type type)
        {
            return container.Resolve(type);
        }

        public void RegistType(Type from, Type to)
        {
            var builder = new Autofac.ContainerBuilder();
            var exp = builder.RegisterType(from).As(to);


            exp.PropertiesAutowired();

            builder.Update(container);
        }

        public void RegistType<T1, T2>(string name = "") where T2 : T1
        {
            var builder = new Autofac.ContainerBuilder();
            var exp = builder.RegisterType<T2>().As<T1>();
            exp.PropertiesAutowired();
            builder.Update(container);
        }

        public void RegistTypeByThreadLife<T1, T2>() where T2 : T1
        {
            var builder = new Autofac.ContainerBuilder();
            var exp = builder.RegisterType<T2>().As<T1>().SingleInstance();
            exp.PropertiesAutowired();

            builder.Update(container);
        }

        public void RgeistSingle<T1, T2>(string name = "") where T2 : T1
        {
            var builder = new Autofac.ContainerBuilder();
            var exp = builder.RegisterType<T2>().As<T1>().SingleInstance();
            var to = typeof(T1);
            exp.PropertiesAutowired();
            builder.Update(container);
        }

        public object GetContainer()
        {
            return container;
        }

        public void LoadConfig()
        {
            var builder = new Autofac.ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            builder.Update(container);
        }

        public void UseMvcContianer()
        {
            var builder = new Autofac.ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.Update(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }



    }
}
