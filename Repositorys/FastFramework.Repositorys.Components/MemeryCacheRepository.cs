using FastFramework.Repositorys.Core.Contracts;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using Microsoft.Practices.EnterpriseLibrary.Caching.Expirations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Repositorys.Components
{
    public class MemeryCacheRepository : ICacheRepository
    {
        private ICacheManager cache;

        /// <param name="managerName">缓存对象名称</param>
        public MemeryCacheRepository(string managerName = "")
        {
            cache = CacheFactory.GetCacheManager(managerName);
        }

        public bool Add(string key, object source, int timeOut = 0)
        {
            if (timeOut == 0)
                cache.Add(key, source);
            else
            {
                cache.Add(key, source, CacheItemPriority.Normal, null, new AbsoluteTime(DateTime.Now.AddMilliseconds(timeOut)));
            }
            return true;
        }

        public T Get<T>(string key)
        {
            return (T)cache.GetData(key);
        }

        public bool Remove(string key)
        {
            cache.Remove(key);
            return true;
        }

        public bool RemoveAll()
        {
            cache.Flush();
            return true;
        }

        public  bool Contains(string key)
        {
            return cache.Contains(key);
        }
    }
}
