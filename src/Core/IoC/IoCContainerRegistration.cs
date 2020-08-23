using System;

namespace Core.IoC
{
    /// <summary>
    /// A generic abstraction of an IoC container registration
    /// </summary>
    public class IoCContainerRegistration
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serviceType">The type of service for this registration</param>
        /// <param name="implementationType">The implementation type for this registration</param>
        /// <param name="registrationLifetime">The lifetime for this registration</param>
        /// <param name="name">The name of the registration</param>
        /// <param name="isFactory">Indicates this service should exhibit the behavior of a factory</param>
        public IoCContainerRegistration(
            Type serviceType, 
            Type implementationType, 
            RegistrationLifetime registrationLifetime, 
            string name, 
            bool isFactory)
        {
            ServiceType = serviceType;
            ImplementationType = implementationType;
            RegistrationLifetime = registrationLifetime;
            Name = name;
            IsFactory = isFactory;
        }

        /// <summary>
        /// The type of service for this registration
        /// </summary>
        public Type ServiceType { get; }

        /// <summary>
        /// The implementation type for this registration
        /// </summary>
        public Type ImplementationType { get; }

        /// <summary>
        /// The lifetime for this registration
        /// </summary>
        public RegistrationLifetime RegistrationLifetime { get; }

        /// <summary>
        /// The name of the registration
        /// </summary>
        public string Name { get; }

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
                $"ServiceType          : {ServiceType.FullName}{Environment.NewLine}" +
                $"ImplementationType   : {ImplementationType.FullName}{Environment.NewLine}" +
                $"RegistrationLifetime : {RegistrationLifetime}{Environment.NewLine}" +
                $"Name                 : {Name}{Environment.NewLine}" +
                $"IsFactory            : {IsFactory}";
        }
    }
}
