using System.Collections.Generic;

namespace Core.Application
{
    /// <summary>
    /// Parses a connection string into segments
    /// </summary>
    public interface IConnectionStringParser
    {
        /// <summary>
        /// The value of the segment, if the segment key is present
        /// </summary>
        dynamic Segments { get; }

        /// <summary>
        /// All segments in the connection string
        /// </summary>
        Dictionary<string, string> SegmentDictionary { get; }

        /// <summary>
        /// Parses a connection string into segments by splitting it on the delimiter
        /// </summary>
        /// <param name="connectionString">The connection string to parse</param>
        /// <returns>A dynamic object that can be used to obtain the value of one segment</returns>
        dynamic Parse(string connectionString);

        /// <summary>
        /// Attempts to get a segment value by key
        /// </summary>
        /// <param name="key">The key of the segment</param>
        /// <returns>The value of the segment, if the segment key is present</returns>
        string TryGet(string key);
    }
}
