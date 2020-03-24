using Core.Validation;

namespace Core.Exceptions
{
    /// <summary>
    /// Used to encapsulate and throw a validation failure as an exception
    /// </summary>
    public class ValidationException : CoreException
    {
        /// <summary>
        /// Details about the validation failure
        /// </summary>
        public ValidationFailureResult ValidationFailureResult { get; protected set; }

        /// <summary>
        /// Simple overload for providing a message as part of the exception
        /// </summary>
        /// <param name="message">A brief description of what the <see cref="LogEntry"/> is. This is not meant to be formatted in a specific way and is not intended to be search on. It's a human-readble descriptive note of what happened. There are other classes for providing more structure to log entries for the sake of searching and grouping</param>
        public ValidationException(string message) : base(message)
        {
            ErrorCode = Exceptions.ErrorCode.BADR;
        }

        /// <summary>
        /// Simple overload for providing an <see cref="ErrorCode"/> as well as a message as part of the exception
        /// </summary>
        /// <param name="errorCode">The Error Code string to be logged; Error Codes can be found in Core.Constants.ErrorCode.* and are 4 character strings</param>
        /// <param name="message">A brief description of the <see cref="LogEntry"/>. This is not meant to be formatted in a specific way and is not intended to be search on. It's a human-readble descriptive note of what happened. There are other classes (i.e. <see cref="LogEntry"/>) for providing more structure to log entries for the sake of searching and grouping</param>
        public ValidationException(string errorCode, string message) : base(errorCode, message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Simple overload for providing a <see cref="Validation.ValidationFailureResult"/> as part of the exception
        /// </summary>
        /// <param name="validationFailureResult">Details about the validation failure</param>
        public ValidationException(ValidationFailureResult validationFailureResult)
            : base("Input validation failed")
        {
            ValidationFailureResult = validationFailureResult;
        }
    }
}
