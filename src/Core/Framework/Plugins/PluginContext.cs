using System.Collections.Generic;

namespace Core.Framework.Plugins
{
    /// <summary>
    /// Provides the ability to receive a read-only collection that represents the current state of all pending IoC container registrations
    /// </summary>
    public class PluginContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="componentsToLoad">The components that should be loaded</param>
        public PluginContext(IReadOnlyDictionary<string, string> componentsToLoad = null)
        {
            ComponentsToLoad = componentsToLoad;
        }

        /// <summary>
        /// Informs the Plugins which Components were selected to load
        /// </summary>
        public IReadOnlyDictionary<string, string> ComponentsToLoad { get; }
    }
}
