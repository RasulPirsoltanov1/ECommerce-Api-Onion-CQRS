using E_Commerce_Api.Application.Interfaces.RedisCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Behaviors
{
    public class RedisCacheBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        IRedisService redisService;

        public RedisCacheBehavior(IRedisService redisService)
        {
            this.redisService = redisService;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (request is IChacheableQuery query)
            {
                var cacheKey = query.CacheKey;
                var cacheTime = query.CacheTime;
                var cacheData = await redisService.GetAsync<TResponse>(cacheKey);
                if (cacheData is not null)
                    return cacheData;
                var response = await next();
                if (response is not null)
                    await redisService.SetAsync(cacheKey, response,DateTime.Now.AddMinutes(cacheTime));
            }
           return await next();
        }
    }
}
