using System;

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
        /// <param name="key"></param>
        /// <param name="value"></param>
        public CacheEntry(string key, TToCache value)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("key cannot be null", nameof(key));

            if (value == null)
                throw new ArgumentException("value cannot be null", nameof(value));

            Key = key;
            Value = value;
            IsValid = true;
            TypeName = value.GetType().FullName;
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
        /// The name of the type of the object in the Value field
        /// </summary>
        public string TypeName { get; }

        /// <summary>
        /// Returns <c>true</c> if the cache entry has not expired; otherwise, <c>false</c>
        /// </summary>
        public bool IsValid { get; private set; }

        /// <summary>
        /// Invalidates this cache entry
        /// </summary>
        public void Invalidate()
        {
            IsValid = false;
        }
    }
}
