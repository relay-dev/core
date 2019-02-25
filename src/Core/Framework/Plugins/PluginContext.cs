using Core.IoC;
using System.Collections.Generic;

namespace Core.Framework.Plugins
{
    /// <summary>
    /// Provides the ability for consumers to recieve a read-only collection that represents the current state of all pending IoC container registrations
    /// </summary>
    public class PluginContext : IContext
    {
        /// <summary>
        /// A read-only collection that represents the current state of all pending IoC container registrations
        /// </summary>
        public IReadOnlyList<IoCContainerRegistration> ExistingRegisterations { get; set; }
    }
}
