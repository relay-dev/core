using Core.Framework.Plugins;
using System.Collections.Generic;

namespace Core.IoC.Plugins
{
    /// <summary>
    /// Provides the ability to recieve a read-only collection that represents the current state of all pending IoC container registrations
    /// </summary>
    public class IoCContainerPluginContext : PluginContext
    {
        /// <summary>
        /// A read-only collection that represents the current state of all pending IoC container registrations
        /// </summary>
        public IReadOnlyList<IoCContainerRegistration> IoCContainerRegisterations { get; }

        /// <summary>
        /// A copy of the current IoCContainerSettings
        /// </summary>
        public IoCContainerSettings IoCContainerSettings { get; }
    }
}
