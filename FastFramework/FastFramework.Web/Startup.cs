using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FastFramework.Web.Startup))]
namespace FastFramework.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
