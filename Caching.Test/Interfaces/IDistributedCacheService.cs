using Microsoft.Extensions.Caching.Distributed;

namespace Caching.Test.Interfaces
{
    public interface IDistributedCacheService
    {
        Task SetStringAsync(string key, string value);
        Task<string> GetStringAsync(string key);
        Task SetAsync(string key, byte[] value);
        Task<byte[]> GetAsync(string key);
    }
}
