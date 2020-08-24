using Core.IoC;

namespace Core.Framework
{
    /// <summary>
    /// The result of the boostrapper Startup operation
    /// </summary>
    public class StartupResult : Result
    {
        /// <summary>
        /// The IoC container, fully initialized by the boostrapper
        /// </summary>
        public IIoCContainer IoCContainer { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="isSuccess">Indicates if the operation was successful</param>
        /// <param name="errorMessage">Provides details regarding why the Operation was not successful (will be null when Operations are successful)</param>
        /// <param name="errorCode">Provides a specific code regarding why the Operation was not successful (will be null when Operations are successful)</param>
        /// <param name="iocContainer">The IoC that was initialized by the boostrapper process</param>
        public StartupResult(bool isSuccess, string errorMessage, string errorCode, IIoCContainer iocContainer)
            : base(isSuccess, errorMessage, errorCode)
        {
            IoCContainer = iocContainer;
        }
    }

    /// <summary>
    /// The result of the boostrapper Startup operation
    /// </summary>
    /// <typeparam name="TResult">The result of the startup operation</typeparam>
    public class StartupResult<TResult> : Result<TResult>
    {
        /// <summary>
        /// The generic result of the boostrapper Startup operation
        /// </summary>
        public TResult Result { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="isSuccess">Indicates if the operation was successful</param>
        /// <param name="errorMessage">Provides details regarding why the Operation was not successful (will be null when Operations are successful)</param>
        /// <param name="errorCode">Provides a specific code regarding why the Operation was not successful (will be null when Operations are successful)</param>
        /// <param name="result">The result of the operation</param>
        public StartupResult(bool isSuccess, string errorMessage, string errorCode, TResult result)
            : base(isSuccess, errorMessage, errorCode, result)
        {
            Result = result;
        }
    }
}
