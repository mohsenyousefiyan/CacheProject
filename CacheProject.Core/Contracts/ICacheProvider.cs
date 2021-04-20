namespace CacheProject.Core.Contracts
{
    public interface ICacheProvider
    {
        void Set<T>(string keyName, T value);
        T Get<T>(string keyName);
        void Remove(string keyName);
    }
}
