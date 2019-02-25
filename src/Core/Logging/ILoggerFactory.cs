using Core.Framework;

namespace Core.Logging
{
    /// <summary>
    /// Creates <see cref="ILogger"/> instances, using the default (when no name is specified) or the cache instance by name
    /// </summary>
    public interface ILoggerFactory : IFactory<ILogger> { }
}
