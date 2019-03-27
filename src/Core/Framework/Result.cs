namespace Core.Framework
{
    /// <summary>
    /// The Result of an Operation
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Returns <c>true</c> if the Operation was successful; otherwise <c>false</c>
        /// </summary>
        public bool IsSuccess { get; }

        /// <summary>
        /// Provides details regarding why the Operation was not successful (will be null when Operations are successful)
        /// </summary>
        public string ErrorMessage { get; }

        /// <summary>
        /// Provides a specific code regarding why the Operation was not successful (will be null when Operations are successful)
        /// </summary>
        public string ErrorCode { get; }

        #region ctor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="isSuccess">Indicates if the operation was successful</param>
        /// <param name="errorMessage">Provides details regarding why the Operation was not successful (will be null when Operations are successful)</param>
        /// <param name="errorCode">Provides a specific code regarding why the Operation was not successful (will be null when Operations are successful)</param>
        public Result(bool isSuccess, string errorMessage, string errorCode)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
        }

        #endregion
    }

    /// <summary>
    /// The Result of an Operation
    /// </summary>
    /// <typeparam name="TValue">The type of the Value of the result</typeparam>
    public class Result<TValue> : Result
    {
        /// <summary>
        /// The result of the Operation
        /// </summary>
        public TValue Value { get; }

        #region ctor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="isSuccess">Indicates if the operation was successful</param>
        /// <param name="errorMessage">Provides details regarding why the Operation was not successful (will be null when Operations are successful)</param>
        /// <param name="errorCode">Provides a specific code regarding why the Operation was not successful (will be null when Operations are successful)</param>
        /// <param name="value">The output of the operation</param>
        public Result(bool isSuccess, string errorMessage, string errorCode, TValue value)
            : base(isSuccess, errorMessage, errorCode)
        {
            Value = value;
        }

        #endregion
    }
}
