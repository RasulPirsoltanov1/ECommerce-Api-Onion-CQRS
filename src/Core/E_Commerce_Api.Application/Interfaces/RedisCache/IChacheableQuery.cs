namespace E_Commerce_Api.Application.Interfaces.RedisCache
{
    public interface IChacheableQuery 
    {
        string CacheKey { get; }
        double CacheTime { get; }
    }
}
