using System.Threading;
using System.Threading.Tasks;

namespace Core.Framework
{
    /// <summary>
    /// Represents a simple class that runs a process
    /// </summary>
    public interface IProcessor
    {
        /// <summary>
        /// Invokes the process
        /// </summary>
        /// <param name="cancellationToken">The current cancellation token</param>
        Task ProcessAsync(CancellationToken cancellationToken);
    }

    /// <summary>
    /// Represents a simple class that runs a process
    /// </summary>
    /// <typeparam name="TInput">The input to the processor</typeparam>
    public interface IProcessor<TInput>
    {
        /// <summary>
        /// Invokes the process
        /// </summary>
        /// <param name="input">The input to the processor</param>
        /// <param name="cancellationToken">The current cancellation token</param>
        Task ProcessAsync(TInput input, CancellationToken cancellationToken);
    }

    /// <summary>
    /// Represents a simple class that runs a process
    /// </summary>
    /// <typeparam name="TInput">The input to the processor</typeparam>
    /// <typeparam name="TOutput">The output of the processor</typeparam>
    public interface IProcessor<TInput, TOutput>
    {
        /// <summary>
        /// Invokes the process
        /// </summary>
        /// <param name="input">The input to the processor</param>
        /// <param name="cancellationToken">The current cancellation token</param>
        /// <returns>The output of the processor</returns>
        Task<TOutput> ProcessAsync(TInput input, CancellationToken cancellationToken);
    }
}
