namespace Core.Communication.Smtp
{
    /// <summary>
    /// Creates <see cref="ISmtpClient"/> instances using the connectionName
    /// </summary>
    public interface ISmtpClientFactory
    {
        /// <summary>
        /// Creates a new ISmtpClient instance
        /// </summary>
        /// <param name="connectionName">The name of the connection string in the IConnectionStringProvider</param>
        /// <returns>A new ISmtpClient instance</returns>
        ISmtpClient Create(string connectionName);
    }
}
