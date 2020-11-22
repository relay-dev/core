using System.Threading;
using System.Threading.Tasks;

namespace Core.Framework
{
    /// <summary>
    /// Runs any configured warmup tasks
    /// </summary>
    public interface IWarmupTaskExecutor
    {
        /// <summary>
        /// Runs the warmup tasks
        /// </summary>
        /// <param name="cancellationToken">The current <see cref="CancellationToken"/></param>
        Task RunAsync(CancellationToken cancellationToken);
    }
}