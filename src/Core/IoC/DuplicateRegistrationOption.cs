namespace Core.IoC
{
    /// <summary>
    /// Used by the IoC auto-wiring process. This enum indicates how the IoC initialization process should behave when it encounters a duplicate registration.
    /// </summary>
    public enum DuplicateRegistrationOption
    {
        /// <summary>
        /// Not specified
        /// </summary>
        Undefined,

        /// <summary>
        /// When a call is made to register and a duplicate registration exists, consider it an error and throw an exception
        /// </summary>
        ThrowException,

        /// <summary>
        /// When a call is made to register and a duplicate registration exists, consider the request to be the correct registration and override the existing registration
        /// </summary>
        OverrideExistingRegistration,

        /// <summary>
        /// When a call is made to register and a duplicate registration exists, consider the existing registration to be correct and ignore the requested registration
        /// </summary>
        IgnoreRegistrationRequest
    }
}
