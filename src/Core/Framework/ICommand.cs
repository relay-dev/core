namespace Core.Data
{
    /// <summary>
    /// Represents a single unit of work that can be executed
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes the command
        /// </summary>
        void Execute();
    }

    /// <summary>
    /// Represents a single unit of work that can be executed
    /// </summary>
    /// <typeparam name="TResult">Output type needed for the command</typeparam>
    public interface ICommand<TResult>
    {
        /// <summary>
        /// Executes the command
        /// </summary>
        /// <returns>Result of the command</returns>
        TResult Execute();
    }
}
