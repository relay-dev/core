using System;

namespace Core.IoC
{
    /// <summary>
    /// A generic abstraction of an IoC container registration
    /// </summary>
    public class IoCContainerRegistration
    {
        public IoCContainerRegistration(Type serviceType, Type implementationType, RegistrationLifetime registrationLifetime, string name, bool isFactory)
        {
            ServiceType = serviceType;
            ImplementationType = implementationType;
            RegistrationLifetime = registrationLifetime;
            Name = name;
            IsFactory = isFactory;
        }

        /// <summary>
        /// The name of the registration
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The type of service for this registration
        /// </summary>
        public Type ServiceType { get; }

        /// <summary>
        /// The implementation type for this registration
        /// </summary>
        public Type ImplementationType { get; }

        /// <summary>
        /// The lifetime for this registation
        /// </summary>
        public RegistrationLifetime RegistrationLifetime { get; }

        /// <summary>
        /// Indicates this service should exhibit the behavior of a factory
        /// </summary>
        public bool IsFactory { get; }

        /// <summary>
        /// A string representation of an IoCContainerRegistration
        /// </summary>
        /// <returns>The IoCContainerRegistration</returns>
        public override string ToString()
        {
            return
                $"ServiceType          : {ServiceType.FullName}" +
                $"ImplementationType   : {ImplementationType.FullName}" +
                $"RegistrationLifetime : {RegistrationLifetime.ToString()}" +
                $"Name                 : {Name}" +
                $"IsFactory            : {IsFactory}";
        }
    }
}
