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
using System.Web;

namespace FastFramework.Core.AutofacContainers
{
    public class AutofacContainerProvider : IAppContianer
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

        public IEnumerable<T> ReloserAll<T>()
        {
            return container.Resolve<IEnumerable<T>>();
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
            if (HttpContext.Current != null)
                builder.RegisterType<T2>().As<T1>().InstancePerRequest().PropertiesAutowired();
            else
                builder.RegisterType<T2>().As<T1>().SingleInstance().PropertiesAutowired();

            builder.Update(container);
        }

        public void RegistSingle<T1, T2>(string name = "") where T2 : T1
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
            try
            {
                var builder = new Autofac.ContainerBuilder();
                builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
                builder.Update(container);
            }
            catch (Exception)
            {
            }
        }

        public void UseMvcContianer(Assembly assembly)
        {
            var builder = new Autofac.ContainerBuilder();
            builder.RegisterControllers(assembly).PropertiesAutowired();
            builder.Update(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }



    }
}
