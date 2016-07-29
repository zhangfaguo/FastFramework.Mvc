﻿using FastFramework.Core;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FastFrameword.AutofacConfig;
using Autofac.Integration.Mvc;
using Autofac;
using System.Reflection;
using System;
using System.IO;
using System.Linq;

namespace FastFramework.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            AppConfig.Instance.UseAutofac()
                              .UseAutoMapper()
                              .Config();

            AppConfig.Containers
                .RegisterDB()
                .RegistMainRepository()
                .RegisterService();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AppConfig.Containers.UseMvcContianer(Assembly.GetExecutingAssembly());
        }
    }
}