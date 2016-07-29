using FastFramework.DataLib.Models;
using FastFramework.Repositorys.Main.Contracts;
using FastFramework.Services.Mains.Contracts;
using FastFramework.Services.Mains.Contracts.Models;
using System.Linq;
using FastFramework.Core;

namespace FastFramework.Services.Mains
{
    public class UserCenterService : IUserCenterService
    {
        protected IUserRepository userProvider;

        public UserCenterService(IUserRepository user)
        {
            userProvider = user;
        }

        public UserModel Get()
        {
            var user = new Users()
            {
                UserName = "zhangfaguo"
            };
            userProvider.Query.ToList();
            return user.To<UserModel>();
        }
    }
}
