using E_Commerce_Api.Application.Interfaces.RedisCache;
using Microsoft.Extensions.Options;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace E_Commerce_Api.Infrastructure.RedisCache
{
    public class RedisService : IRedisService
    {
        ConnectionMultiplexer redisConnection;
        IDatabase database;
        RedisCacheSettings settings;
        public RedisService(IOptions<RedisCacheSettings> options)
        {
            settings = options.Value;
            var opt = ConfigurationOptions.Parse(settings.ConnectionString);
            redisConnection = ConnectionMultiplexer.Connect(opt);
            database = redisConnection.GetDatabase();
        }
        public async Task<T> GetAsync<T>(string key)
        {
            var value = await database.StringGetAsync(key);
            if (value.HasValue)
                return JsonSerializer.Deserialize<T>(value);
            return default;
        }

        public async Task SetAsync<T>(string key, T value, DateTime? expirationTime)
        {
            TimeSpan timeUntilExpiration = expirationTime.Value - DateTime.Now;
            await database.StringSetAsync(key, JsonSerializer.Serialize(value), timeUntilExpiration);
        }
    }
    public class RedisCacheSettings
    {
        public string ConnectionString { get; set; }
        public string InstanceName { get; set; }
    }
}
