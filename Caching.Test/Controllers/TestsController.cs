using Caching.Test.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace Caching.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly IDistributedCacheService _cacheService;
        private readonly IInMemoryCacheService _inmemoryCache;
        public TestsController(IDistributedCacheService cacheService, IInMemoryCacheService inmemoryCache)
        {
            _cacheService = cacheService;
            _inmemoryCache = inmemoryCache;
        }

        [HttpGet]
        public async Task<IActionResult> Set(string key, string value)
        {
            await _cacheService.SetStringAsync(key, value);
            return Ok();
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get(string key)
        {
            string cachedValue = await _cacheService.GetStringAsync(key);
            return Ok(cachedValue);
        }

        [HttpGet("inmemory_set")]
        public IActionResult SetInMemory(string key,string value)
        {
            _inmemoryCache.Set(key,value);
            return Ok();
        }

        [HttpGet("inmemory_get")]
        public IActionResult GetInMemory(string key)
        {
            object value = _inmemoryCache.Get(key);
            return Ok(value);
        }

    }
}
