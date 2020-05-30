using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplication1.Interface;

namespace WebApplication1.Controllers
{
    public class ResponceCacheService:IResponseCacheService
    {
        private readonly IDistributedCache _distributedCache;
            public ResponceCacheService(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }
        public async Task CacheResponseAsync(string cachekey, object response, TimeSpan timeToLive)
        {
            if (response == null) return;
            
                var serializeResponce = JsonConvert.SerializeObject(response);
            await _distributedCache.SetStringAsync(cachekey, serializeResponce, new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = timeToLive
            });
                    
            
        }

        public async Task<string> GetCachedResponseAsync(string cacheKey)
        {
            var cachedResponse = await _distributedCache.GetStringAsync(cacheKey);
            return string.IsNullOrWhiteSpace(cachedResponse) ? null : cachedResponse;
        }

    }
}