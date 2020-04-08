namespace Core.Data
{
    /// <summary>
    /// Creates <see cref="IDatabase"/> instances, using the default (when no name is specified) or the database instance by name
    /// </summary>
    public interface IDatabaseFactory
    {
        /// <summary>
        /// Creates a new IDatabase instance
        /// </summary>
        /// <param name="connectionName">The name of the connection string in the IConnectionStringProvider</param>
        /// <returns>A new IDatabase instance</returns>
        IDatabase Create(string connectionName = null);
    }
}
