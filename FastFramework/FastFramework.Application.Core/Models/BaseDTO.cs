using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Application.Core.Models
{
    public class BaseDTO<T>
        where T : class, new()
    {
        public T Source
        {
            get;
            set;
        }

        public BaseDTO()
        {
            Source = new T();
        }
    }
}
