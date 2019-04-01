using System;

namespace Core.Caching
{
    /// <summary>
    /// A generic abstraction of a caching mechanism
    /// </summary>
    public interface ICache
    {
        /// <summary>
        /// Indicates whether or not the cache contains a specific key
        /// </summary>
        /// <param name="key">The key of the cache entry</param>
        /// <returns><c>true</c> if the provided string is found in the cache, which inheritly means there is a value cached for it; otherwise, <c>false</c></returns>
        bool ContainsKey(string key);

        /// <summary>
        /// Calls the GetOrAdd() overload using the applications default CacheExpirationInHours
        /// </summary>
        /// <typeparam name="TReturn">The Type of object you are expecting to receive from the cache</typeparam>
        /// <param name="key">Lookup key for the cache entry</param>
        /// <param name="valueFactory">Function to set the value of the cache entry if it does not exist or has expired</param>
        /// <returns>The entry in the cache for the given key</returns>
        TReturn GetOrAdd<TReturn>(string key, Func<TReturn> valueFactory);

        /// <summary>
        /// Gets an entry from the cache if it exists. If it does not exist (or it has expired) it will use the Func you pass in to set a value in the cache for the key you specified.
        /// </summary>
        /// <typeparam name="TReturn">The Type of object you are expecting to receive from the cache</typeparam>
        /// <param name="key">Lookup key for the cache entry</param>
        /// <param name="valueFactory">Function to set the value of the cache entry if it does not exist or has expired</param>
        /// <param name="expirationInHours">Specifies how long the cache should live for before using the Func parameter to refresh the cache entrys value</param>
        /// <returns>The entry in the cache for the given key</returns>
        TReturn GetOrAdd<TReturn>(string key, Func<TReturn> valueFactory, int expirationInHours = 2);

        /// <summary>
        /// Given n input arguments, this method will return a string ready to be used as a key using all standard conventions
        /// </summary>
        /// <param name="args">A set of objects to be used to create a unique cache key</param>
        /// <returns>The key to use</returns>
        string FormatKey(params object[] args);

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
    }
}
