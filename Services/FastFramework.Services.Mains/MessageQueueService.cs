using FastFramework.Core;
using FastFramework.Services.Mains.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFramework.Services.Mains.Contracts.Models;

namespace FastFramework.Services.Mains
{
    public class MessageQueueService : IMessageQueueService
    {
        protected IMessageQueueProvider queueProvider;

        public MessageQueueService(IMessageQueueProvider provider)
        {
            queueProvider = provider;
        }

        public void Push(MessageObject message)
        {
            queueProvider.Push(message);
        }
    }
}
