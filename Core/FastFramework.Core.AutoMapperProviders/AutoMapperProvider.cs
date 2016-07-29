namespace FastFramework.Core.AutoMapperProviders
{
    public class AutoMapperProvider : IMapper
    {
        public T Map<T>(object obj)
        {
            return AutoMapper.Mapper.Map<T>(obj);
        }
    }
}
