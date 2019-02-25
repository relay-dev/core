using System.Collections.Generic;

namespace Core.Framework.Plugins
{
    /// <summary>
    /// Provides the ability to recieve a read-only collection that represents the current state of all pending IoC container registrations
    /// </summary>
    public class PluginContext : IContext
    {
        /// <summary>
        /// Informs the Plugins which Components were selected to load
        /// </summary>
        public IReadOnlyDictionary<string, string> ComponentsToLoad { get; }
    }
}
