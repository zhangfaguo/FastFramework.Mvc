using FastFramework.Core;
using FastFramework.Services.Mains.Contracts;

namespace FastFramework.Services.Mains
{
    public class CacheService : ICacheService
    {
        protected ICacheProvider cacheReposiotry;

        public CacheService(ICacheProvider cache)
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
