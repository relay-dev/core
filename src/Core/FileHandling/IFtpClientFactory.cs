namespace Core.FileHandling
{
    /// <summary>
    /// Creates <see cref="IFtpClient"/> instances, using the default (when no name is specified) or the database instance by name
    /// </summary>
    public interface IFtpClientFactory
    {
        /// <summary>
        /// Creates a new IFtpClient instance
        /// </summary>
        /// <param name="connectionName">The name of the connection string in the IConnectionStringProvider</param>
        /// <returns>A new IFtpClient instance</returns>
        IFtpClient Create(string connectionName);
    }
}
