using Caching.Test.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace Caching.Test.Services
{
    public class InMemoryCache : IInMemoryCacheService
    {
        private readonly IMemoryCache _memoryCache;

        public InMemoryCache(IMemoryCache memoryCache) => _memoryCache = memoryCache;

        public object Get(string key) => _memoryCache.Get(key);

        public void Set(string key, object value) => _memoryCache.Set(key, value);

    }
}
