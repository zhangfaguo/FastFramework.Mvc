using FastFramework.Core;
using FastFramework.Services.Mains.Contracts;
using FastFrameword.AutofacConfig;
using FastFramework.Services.Mains.Contracts.Models;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AppConfig.Instance.UseAutofac()
                              .Config();


            AppConfig.Containers.RegisterDB()
                .RegistMainRepository()
                .RegisterService();

            var mdeol = new { UserName = "zhangfaguo" }.To<UserModel>();
            AppConfig.Containers.Reloser<ILogService>().Log("test", "test");

        }
    }
}
