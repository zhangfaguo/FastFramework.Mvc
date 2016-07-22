using FastFramework.Repositorys.Main.Contracts;
using FastFramework.Services.Mains.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastFramework.Services.Mains
{
    public class UserCenterService : IUserCenterService
    {
        protected IUserRepository userProvider;

        public UserCenterService(IUserRepository user)
        {
            userProvider = user;
        }

        public void Get()
        {
            userProvider.Query.ToList();
        }
    }
}
