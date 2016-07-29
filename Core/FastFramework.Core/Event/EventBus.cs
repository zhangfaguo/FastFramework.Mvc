using System;

namespace FastFramework.Core.Event
{
    public class EventBus
    {
        public void Push<T>(T message)
        {
            var events = AppConfig.Containers.ReloserAll<ICustomer<T>>();

            if (events == null)
            {
                throw new ArgumentException("ICustomer未注册");
            }

            foreach (var bus in events)
            {
                CodeHelper.SafeRun(() =>
                {
                    bus.HandEvent(message);
                    return true;
                });
            }
        }
    }
}
