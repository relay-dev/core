using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides objects with connection strings
    /// </summary>
    public interface IConnectionStringProvider : IProvider<string>
    {
        /// <summary>
        /// Gets a connection string by the connection name
        /// </summary>
        /// <param name="connectionName">The name of the connection string in the configuration</param>
        /// <returns>The connection string</returns>
        string Get(string connectionName);
    }
}
