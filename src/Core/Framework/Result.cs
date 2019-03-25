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
    public class Result<TValue> : Result
    {
        /// <summary>
        /// The result of the Operation
        /// </summary>
        public TValue Value { get; }

        #region ctor

        public Result(bool isSuccess, string errorMessage, string errorCode, TValue value)
            : base(isSuccess, errorMessage, errorCode)
        {
            Value = value;
        }

        #endregion
    }
}
