using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    /// <summary>
    /// Json操作提供
    /// </summary>
    public interface IJsonProvider
    {

        string ToJson(object source);


        T ToObject<T>(string sourceStr);
    }
}
