using Core.Application;
using Core.Framework.Plugins;
using System.Collections.Generic;

namespace Core.IoC.Plugins
{
    /// <summary>
    /// Provides the ability to receive a read-only collection that represents the current state of all pending IoC container registrations
    /// </summary>
    public class IoCContainerPluginContext : PluginContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="iocContainerRegistrations">Current IoC container registrations</param>
        /// <param name="iocContainerSettings">Current IoC container settings</param>
        /// <param name="applicationComposition">Current application composition</param>
        public IoCContainerPluginContext(
            IReadOnlyList<IoCContainerRegistration> iocContainerRegistrations,
            IoCContainerSettings iocContainerSettings,
            ApplicationComposition applicationComposition)
        {
            IoCContainerRegistrations = iocContainerRegistrations;
            IoCContainerSettings = iocContainerSettings;
            ApplicationComposition = applicationComposition;
        }

        /// <summary>
        /// A read-only collection that represents the current state of all pending IoC container registrations
        /// </summary>
        public IReadOnlyList<IoCContainerRegistration> IoCContainerRegistrations { get; }

        /// <summary>
        /// A read-only copy of the current IoCContainerSettings
        /// </summary>
        public IoCContainerSettings IoCContainerSettings { get; }

        /// <summary>
        /// A read-only copy of the current ApplicationComposition
        /// </summary>
        public ApplicationComposition ApplicationComposition { get; }
    }
}
