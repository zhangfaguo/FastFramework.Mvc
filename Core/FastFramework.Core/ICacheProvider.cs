using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    public interface ICacheProvider
    {
        T Get<T>(string key);

        bool Add(string key, Object source, int timeOut = 0);

        bool Remove(string key);

        bool RemoveAll();

        bool Contains(string key);
    }
}
