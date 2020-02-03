namespace Core.Data.Pager
{
    /// <summary>
    /// Creates an <see cref="IPager"/> instance for the pagination of views
    /// </summary>
    public interface IPagerFactory
    {
        /// <summary>
        /// Creates an instance of an IPager
        /// </summary>
        /// <param name="connectionName">The name of the connection string in your configuration which the Pager use to connect to the resource</param>
        /// <returns>A new instance of an IPager with the proper connection string</returns>
        IPager Create(string connectionName);
    }
}
