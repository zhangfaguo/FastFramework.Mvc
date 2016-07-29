namespace FastFramework.Core.Event
{
    public interface ICustomer<T>
    {
        void HandEvent(T message);
    }
}
