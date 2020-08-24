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
        dynamic Segment { get; }

        /// <summary>
        /// Attempts to get a segment value by key
        /// </summary>
        /// <param name="key">The key of the segment</param>
        /// <returns>The value of the segment, if the segment key is present</returns>
        string TryGet(string key);
    }
}
