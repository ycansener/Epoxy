namespace Epoxy.Redis
{
    public interface ICacheHelper
    {
        Task<bool> AddCache<T>(T model, TimeSpan ttl);
        Task<T> GetCache<T>(string key);
    }
}
