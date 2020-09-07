using System;
using System.Collections.Generic;

namespace Core.Caching
{
    /// <summary>
    /// A generic abstraction of a caching mechanism
    /// </summary>
    public interface ICacheHelper
    {
        /// <summary>
        /// Gets an entry from the cache if it exists. If it does not exist (or it has expired) it will use the Func you pass in to set a value in the cache for the key you specified.
        /// </summary>
        /// <typeparam name="TReturn">The Type of object you are expecting to receive from the cache</typeparam>
        /// <param name="key">Lookup key for the cache entry</param>
        /// <param name="valueFactory">Function to set the value of the cache entry if it does not exist or has expired</param>
        /// <param name="expirationInHours">Specifies how long the cache should live for before using the Func parameter to refresh the cache entry's value</param>
        /// <returns>The entry in the cache for the given key</returns>
        TReturn GetOrSet<TReturn>(string key, Func<TReturn> valueFactory, int expirationInHours = 2);

        /// <summary>
        /// Retrieves all keys in the current cache
        /// </summary>
        /// <returns>The keys available in the cache</returns>
        List<string> GetAllKeys();

        /// <summary>
        /// Removes a single cache entry, by key
        /// </summary>
        /// <param name="key">Lookup key for the cache entry</param>
        /// <returns>The object that was cache</returns>
        object Remove(string key);

        /// <summary>
        /// Removes all cache entries, effectively clearing out the cache completely
        /// </summary>
        void RemoveAll();

        /// <summary>
        /// Formats the cache key using a consistent delimiter
        /// </summary>
        /// <param name="args">Objects used as strings to format the key in a predictable way</param>
        /// <returns>The formatted string, ready to be used as a cache key</returns>
        string FormatKey(params object[] args);
    }
}
