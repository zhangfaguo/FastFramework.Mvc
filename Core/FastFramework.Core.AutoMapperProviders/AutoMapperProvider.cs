using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core.AutoMapperProviders
{
    internal class AutoMapperProvider : IMapper
    {
        public T Map<T>(object obj)
        {
            return AutoMapper.Mapper.Map<T>(obj, (cfg) =>
              {
                  cfg.CreateMissingTypeMaps = true;
              });
        }
    }
}
