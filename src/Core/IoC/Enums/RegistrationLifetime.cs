namespace Core.IoC
{
    /// <summary>
    /// Indicates the lifetime to be used when registering types for the container
    /// </summary>
    public enum RegistrationLifetime
    {
        /// <summary>
        /// Not specified
        /// </summary>
        Undefined,

        /// <summary>
        /// Singleton components are instantiated once, and shared between all clients.
        /// </summary>
        Singleton,

        /// <summary>
        /// Transient components are created on demand.
        /// </summary>
        Transient,

        /// <summary>
        /// PerRequest components are created once per Http Request
        /// </summary>
        PerRequest
    }
}
