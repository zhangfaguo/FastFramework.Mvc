namespace FastFramework.Core
{
    public interface IMapper
    {
        T Map<T>(object obj);
    }
}
