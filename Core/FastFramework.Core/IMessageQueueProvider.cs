using System;

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
