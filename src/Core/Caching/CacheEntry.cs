namespace Core.Caching
{
    /// <summary>
    /// A generic representation of an entry in a cache
    /// </summary>
    /// <typeparam name="TToCache">The type of object to cache</typeparam>
    public class CacheEntry<TToCache>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value"></param>
        public CacheEntry(TToCache value)
        {
            Value = value;
        }

        /// <summary>
        /// The value of the cache entry
        /// </summary>
        public TToCache Value { get; }
    }
}
