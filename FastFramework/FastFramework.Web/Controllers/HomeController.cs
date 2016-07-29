using FastFramework.Services.Mains.Contracts;
using System.Web.Mvc;
using FastFramework.Services.Mains.Contracts.Models;
using FastFramework.Core;

namespace FastFramework.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserCenterService userProvider;
        public HomeController(IUserCenterService user)
        {
            userProvider = user;
        }

        public ActionResult Index()
        {
            var mdeol = new { UserName = "zhangfaguo" }.To<UserModel>();
            userProvider.Get();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var tag = this.Resolver.GetService<IUserCenterService>();
            return View();
        }
    }
}