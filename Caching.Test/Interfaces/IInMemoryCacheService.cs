namespace Caching.Test.Interfaces
{
    public interface IInMemoryCacheService
    {
        object Get(string key);
        void Set(string key,object value);
    }
}
