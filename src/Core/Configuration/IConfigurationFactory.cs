using Core.Framework;

namespace Core.Configuration
{
    /// <summary>
    /// Creates <see cref="IConfiguration"/> instances, using the default (when no name is specified) or the configuration instance by name
    /// </summary>
    public interface IConfigurationFactory : IFactory<IConfiguration> { }
}
