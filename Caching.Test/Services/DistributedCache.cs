using Caching.Test.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;

namespace Caching.Test.Services
{
    public class DistributedCache : IDistributedCacheService
    {
        private readonly IDistributedCache _distributedCache;
        public DistributedCache(IDistributedCache distributedCache) => _distributedCache = distributedCache;

        public byte[] Get(string key) => _distributedCache.Get(key);
        public void Set(string key, byte[] value) => _distributedCache.Set(key, value);

        public async Task<byte[]> GetAsync(string key) => await _distributedCache.GetAsync(key);
        public async Task SetAsync(string key, byte[] value)
        {
            await _distributedCache.SetAsync(key, value, new()
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(10)
            });
        }

        public async Task<string> GetStringAsync(string key) => await _distributedCache.GetStringAsync(key);
        public async Task SetStringAsync(string key, string value)
        {
            await _distributedCache.SetStringAsync(key, value, options: new()
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(10)
            });
        }

        public async Task RemoveAsync(string key) => await _distributedCache.RemoveAsync(key);
    }
}
