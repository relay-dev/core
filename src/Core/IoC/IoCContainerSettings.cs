using System;

namespace Core.IoC
{
    /// <summary>
    /// Encapsulates all settings that can be used by a <see cref="IIoCContainer"/>
    /// </summary>
    public class IoCContainerSettings
    {
        /// <summary>
        /// Creates a new instance of IoCContainerSettings and sets all properties to reasonable default
        /// </summary>
        public IoCContainerSettings()
        {
            RegistrationLifetime = RegistrationLifetime.Transient;
            DuplicateRegistrationOption = DuplicateRegistrationOption.IgnoreRegistrationRequest;
            RegistrationNameFormat = "{0}";
            IsThrowIfInvalid = true;
            AppDomain = AppDomain.CurrentDomain;
        }

        /// <summary>
        /// Indicates how the IoC Container should manage the lifetime of an object
        /// </summary>
        public RegistrationLifetime RegistrationLifetime { get; set; }

        /// <summary>
        /// Indicates how the IoC Container should behave when it encounters a duplicate before trying to create this registration
        /// </summary>
        public DuplicateRegistrationOption DuplicateRegistrationOption { get; set; }

        /// <summary>
        /// The name which the IoC Container should use to identify this registration
        /// </summary>
        public string RegistrationName { get; set; }

        /// <summary>
        /// The name format which the IoC Container should use to identify this registration
        /// </summary>
        public string RegistrationNameFormat { get; set; }

        /// <summary>
        /// Indicates whether or not the IoC initialization code should throw an exception at the end of its process, should the container be in an invalid state
        /// </summary>
        public bool IsThrowIfInvalid { get; set; }

        /// <summary>
        /// Indicates the AppDomain for which assemblies should be scanned during the auto-registration process
        /// </summary>
        public AppDomain AppDomain { get; set; }
    }
}
