using Core.Framework;
using Core.IoC;

namespace Core.Application
{
    /// <summary>
    /// The result of the Boostrapper Startup operation
    /// </summary>
    public class StartupResult : Result
    {
        /// <summary>
        /// The IoC container, fully initizalized by the Boostrapper
        /// </summary>
        public IIoCContainer IoCContainer { get; }

        #region ctor

        public StartupResult(bool isSuccess, string errorMessage, string errorCode, IIoCContainer iocContainer)
            : base(isSuccess, errorMessage, errorCode)
        {
            IoCContainer = iocContainer;
        }

        #endregion
    }

    /// <summary>
    /// The result of the Boostrapper Startup operation
    /// </summary>
    public class StartupResult<TResult> : Result<TResult>
    {
        /// <summary>
        /// The generic result of the Boostrapper Startup operation
        /// </summary>
        public TResult Result { get; }

        #region ctor

        public StartupResult(bool isSuccess, string errorMessage, string errorCode, TResult result)
            : base(isSuccess, errorMessage, errorCode, result)
        {
            Result = result;
        }

        #endregion
    }
}
