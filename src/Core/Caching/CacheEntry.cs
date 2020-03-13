using System;

namespace Core.Caching
{
    /// <summary>
    /// A generic representation of an entry in a cache
    /// </summary>
    /// <typeparam name="TToCache">The type of object to cache</typeparam>
    internal class CacheEntry<TToCache>
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
        /// The lookup key for the entry in the cache
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// The value of the cache entry
        /// </summary>
        public TToCache Value { get; }

        /// <summary>
        /// The Type of the object in the Value field
        /// </summary>
        public Type Type { get; }

        /// <summary>
        /// Returns <c>true</c> if the cache entry has not expired; otherwise, <c>false</c>
        /// </summary>
        public bool IsValid { get; private set; }

        public void Invalidate()
        {
            IsValid = false;
        }
    }
}
