using FastFramework.Repositorys.Core.Contracts;
using FastFramework.Services.Mains.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Services.Mains
{
    public class CacheService : ICacheService
    {
        protected ICacheRepository cacheReposiotry;

        public CacheService(ICacheRepository cache)
        {
            cacheReposiotry = cache;
        }

        public bool Add(string key, object source, int timeOut = 0)
        {
            return cacheReposiotry.Add(key, source, timeOut);
        }

        public bool Contains(string key)
        {
            return cacheReposiotry.Contains(key);
        }

        public T Get<T>(string key)
        {
            return cacheReposiotry.Get<T>(key);
        }

        public bool Remove(string key)
        {
            return cacheReposiotry.Remove(key);
        }

        public bool RemoveAll()
        {
            return cacheReposiotry.RemoveAll();
        }
    }
}
