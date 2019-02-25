using Core.Data;
using System.Collections.Generic;

namespace Core.Providers
{
    /// <summary>
    /// Provides Commands with resources
    /// </summary>
    public interface IResourceProvider : IProvider<IDictionary<string, IDictionary<string, string>>>
    {
        /// <summary>
        /// Gets a resource by string
        /// </summary>
        /// <param name="resourceName">The name of the resource (usually the file name, without the extension)</param>
        /// <param name="key">The key of the resource</param>
        /// <returns>The resource, as a string</returns>
        string GetString(string resourceName, string key);

        /// <summary>
        /// Gets a resource by string, assuming the resourceName is Messages
        /// </summary>
        /// <param name="key">The key of the resource</param>
        /// <returns>The resource, as a string</returns>
        string GetMessage(string key);
    }
}
