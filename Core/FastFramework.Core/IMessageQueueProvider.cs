using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Core
{
    /// <summary>
    /// 消息队列提供
    /// </summary>
    public interface IMessageQueueProvider
    {
        void Push(Object message);
    }
}
