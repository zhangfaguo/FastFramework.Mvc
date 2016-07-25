using FastFramework.DataLib.Models;
using FastFramework.Repositorys.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastFramework.Repositorys.Main.Contracts
{
    public interface IUserRepository : IEfRepository<Users>
    {
    }
}
