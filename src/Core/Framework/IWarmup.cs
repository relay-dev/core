using System.Threading;
using System.Threading.Tasks;

namespace Core.Framework
{
    /// <summary>
    /// A generic abstraction of a class that serves to warmup an application
    /// </summary>
    public interface IWarmup
    {
        /// <summary>
        /// Runs the warmup process
        /// </summary>
        /// <param name="cancellationToken">The current <see cref="CancellationToken"/></param>
        /// <returns>The task</returns>
        Task RunAsync(CancellationToken cancellationToken);
    }
}