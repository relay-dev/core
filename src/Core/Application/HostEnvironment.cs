namespace Core.Application
{
    /// <summary>
    /// Specifies the Environment under which an application is running (usually obtained from a Context type object)
    /// </summary>
    public enum HostEnvironment
    {
        /// <summary>
        /// Not specified
        /// </summary>
        [HostEnvironment]
        Undefined,

        /// <summary>
        /// A Mock environment is setup to auto-mock all dependencies of all classes, and is often driven by a formatted text file to inject sets of mocked data for an application demo to run offline, or for running mock tests
        /// </summary>
        [HostEnvironment(IsMockInstance = true, IsDevelopmentInstance = true)]
        Mock,

        /// <summary>
        /// The Development environment belongs to the Development Team and is the least restrictive in the environment stack
        /// </summary>
        [HostEnvironment(IsDevelopmentInstance = true, IsBetaInstance = true)]
        Development,

        /// <summary>
        /// The Test environment belongs to the Testing Team and is slightly more restrictive than the Development environment
        /// </summary>
        [HostEnvironment(IsTestingInstance = true, IsBetaInstance = true)]
        Test,

        /// <summary>
        /// The Stage environment belongs to the Business Team and is slightly more restrictive than the QA environment
        /// </summary>
        [HostEnvironment(IsTestingInstance = true)]
        Stage,

        /// <summary>
        /// The Beta environment belongs to the IT and Business Team and is available for testing beta applications side-by-side with an existing version of the same application
        /// </summary>
        [HostEnvironment(IsTestingInstance = true, IsBetaInstance = true)]
        Beta,

        /// <summary>
        /// The Production environment belongs to the Production Management Team and is very restrictive
        /// </summary>
        [HostEnvironment(IsProductionInstance = true)]
        Production
    }
}
