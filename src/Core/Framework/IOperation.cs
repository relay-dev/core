namespace Core.Framework
{
    /// <summary>
    /// Represents an operation that can be executed
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Executes the operation
        /// </summary>
        void Execute();
    }

    /// <summary>
    /// Represents an operation that can be executed
    /// </summary>
    /// <typeparam name="TResult">Output type to be returned by this operation</typeparam>
    public interface IOperation<out TResult>
    {
        /// <summary>
        /// Executes the operation
        /// </summary>
        /// <returns>Result of the operation</returns>
        TResult Execute();
    }

    /// <summary>
    /// Represents an operation that can be executed
    /// </summary>
    /// <typeparam name="TInput">Input type to be returned by this operation</typeparam>
    /// <typeparam name="TResult">Output type to be returned by this operation</typeparam>
    public interface IOperation<in TInput, out TResult>
    {
        /// <summary>
        /// Executes the operation
        /// </summary>
        /// <param name="input">The input to the operation</param>
        /// <returns>Result of the operation</returns>
        TResult Execute(TInput input);
    }
}
