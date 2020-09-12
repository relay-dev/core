using Core.Framework;

namespace Core.Security
{
    /// <summary>
    /// Creates <see cref="IHashingService"/> instances, using the default (when no name is specified) or the configuration instance by name
    /// </summary>
    public interface IHashingServiceFactory : IFactory<IHashingService> { }
}
