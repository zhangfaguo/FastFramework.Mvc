using FastFramework.Core;
using FastFramework.Services.Mains.Contracts;
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
