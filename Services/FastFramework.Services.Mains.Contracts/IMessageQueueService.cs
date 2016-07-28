using FastFramework.Services.Mains.Contracts.Models;

namespace FastFramework.Services.Mains.Contracts
{
    public interface IMessageQueueService
    {
        void Push(MessageObject message);
    }
}
