using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides objects with connection strings
    /// </summary>
    public interface IConnectionStringProvider : IProvider<string>
    {
        /// <summary>
        /// Gets a connection string by the connection name and throws an exception if the connection string is not found
        /// </summary>
        /// <param name="connectionName">The name of the connection string in the configuration</param>
        /// <returns>The connection string</returns>
        string Get(string connectionName);

        /// <summary>
        /// Gets a connection string by the connection name and returns null if the connection string is not found
        /// </summary>
        /// <param name="connectionName">The name of the connection string in the configuration</param>
        /// <returns>The connection string</returns>
        string GetOptional(string connectionName);
    }
}
