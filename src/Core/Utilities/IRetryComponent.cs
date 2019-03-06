using System;
using System.Collections.Generic;

namespace Core.Utilities
{
    /// <summary>
    /// A generic utility to retry a given delegate if it fails
    /// </summary>
    public interface IRetryComponent
    {
        /// <summary>
        /// Retries an Action if it fails
        /// </summary>
        /// <param name="timesToRetry">The number of times to retry</param>
        /// <param name="retryInterval">How long to wait in between each try</param>
        /// <param name="action">The Action to invoke</param>
        /// <returns>The result of the operation</returns>
        RetryResult RetryAction(int timesToRetry, TimeSpan retryInterval, Action action);

        /// <summary>
        /// Retries a Func{T} if it fails
        /// </summary>
        /// <typeparam name="TResult">The type to return as the result</typeparam>
        /// <param name="timesToRetry">The number of times to retry</param>
        /// <param name="retryInterval">How long to wait in between each try</param>
        /// <param name="func">The Func{T} to tinvoke</param>
        /// <returns>The result of the operation</returns>
        RetryResult<TResult> RetryFunc<TResult>(int timesToRetry, TimeSpan retryInterval, Func<TResult> func);
    }

    /// <summary>
    /// The result of a retry operation
    /// </summary>
    public class RetryResult<TResult> : RetryResult
    {
        /// <summary>
        /// The result of the operation
        /// </summary>
        public TResult Result { get; set; }
    }

    /// <summary>
    /// The result of a retry operation
    /// </summary>
    public class RetryResult
    {
        /// <summary>
        /// Indicates the retry operation was overall successful
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Indicates the count of times tried before the overall operation of considered completed
        /// </summary>
        public int TimesTried { get; set; }

        /// <summary>
        /// A list of exceptions that occured during the operation
        /// </summary>
        public List<Exception> Exceptions { get; set; }
    }
}
