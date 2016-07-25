using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    public static class ObjectExtention
    {
        public static T To<T>(this object source)
        {
            return AppConfig.Mappers.Map<T>(source);
        }
    }
}
