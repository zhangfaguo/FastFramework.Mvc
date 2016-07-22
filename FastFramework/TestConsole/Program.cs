using FastFramework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FastFrameword.AutofacConfig;
using FastFramework.Services.Mains.Contracts;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AppConfig.Instance.UserDb();
            AppConfig.Instance.RegistMainRepository();
            AppConfig.Instance.UserCenterAutofac();

            var b = AppConfig.Instance.Container.Resolve<IUserCenterService>();
            b.Get();
        }
    }
}
