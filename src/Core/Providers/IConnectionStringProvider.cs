using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides objects with connection strings
    /// </summary>
    public interface IConnectionStringProvider : IProvider<string>
    {
        string Get(string connectionName);
    }
}
