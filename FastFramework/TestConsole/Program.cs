using FastFramework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FastFramework.Services.Mains.Contracts;
using FastFrameword.AutofacConfig;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AppConfig.Instance.UseUnity();

            AppConfig.Containers.UserDb()
                .RegistMainRepository()
                .UseCenter();

            AppConfig.Containers.Reloser<IUserCenterService>().Get();

        }
    }
}
