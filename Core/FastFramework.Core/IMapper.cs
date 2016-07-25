using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    public interface IMapper
    {
        T Map<T>(object obj);
    }
}
