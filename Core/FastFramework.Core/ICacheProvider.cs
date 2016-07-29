using System;

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
