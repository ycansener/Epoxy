namespace Epoxy.Redis
{
    public class CacheHelper : ICacheHelper
    {
        public Task<bool> AddCache<T>(T model, TimeSpan ttl)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetCache<T>(string key)
        {
            throw new NotImplementedException();
        }
    }
}
