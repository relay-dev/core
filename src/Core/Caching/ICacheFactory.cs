using Core.Framework;

namespace Core.Caching
{
    /// <summary>
    /// Creates <see cref="ICache"/> instances, using the default (when no name is specified) or the cache instance by name
    /// </summary>
    public interface ICacheFactory : IFactory<ICache> { }
}
