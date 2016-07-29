using System;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Microsoft.Practices.Unity.Mvc;
using Microsoft.Practices.Unity.Configuration;

namespace FastFramework.Core.UnityContainers
{
    public class UnityContainerProvider : IAppContianer
    {
        IUnityContainer container;
        public UnityContainerProvider()
        {
            container = new UnityContainer();
        }

        public T Reloser<T>()
        {
            return container.Resolve<T>();
        }

        public T Reloser<T>(string name)
        {
            return container.Resolve<T>(name);
        }

        public object Reloser(Type type)
        {
            return container.Resolve(type);
        }


        public void RegistType(Type from, Type to)
        {
            container.RegisterType(from, to);
        }

        public void RegistType<T1, T2>(string name = "")
             where T2 : T1
        {
            container.RegisterType<T1, T2>(name);
        }

        public void RegistTypeByThreadLife<T1, T2>()
             where T2 : T1
        {
            container.RegisterType<T1, T2>(new PerRequestLifetimeManager());
        }

        public void RegistSingle<T1, T2>(string name = "")
             where T2 : T1
        {
            container.RegisterType<T1, T2>(name, new ContainerControlledLifetimeManager());
        }

        public object GetContainer()
        {
            return container;
        }

        public void UseMvcContianer()
        {
            DependencyResolver.SetResolver(new UnityDependencyResolver(this.container));
        }

        public void LoadConfig()
        {
            try
            {
                var sections = (UnityConfigurationSection)System.Configuration.ConfigurationManager.GetSection("unity");
                sections.Configure(container);
            }
            catch (Exception)
            {
            }
        }
    }
}
