using System.Collections.Generic;

namespace Core.Application
{
    /// <summary>
    /// Parses a connection string into segments
    /// </summary>
    public interface IConnectionStringParser
    {
        /// <summary>
        /// Parses a connection string into segments by splitting it on the delimiter
        /// </summary>
        /// <param name="connectionString">The connection string to parse</param>
        /// <returns>All segments in the connection string</returns>
        Dictionary<string, string> Parse(string connectionString);
    }
}
