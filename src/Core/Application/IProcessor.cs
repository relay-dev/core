using System.Threading;
using System.Threading.Tasks;

namespace Core.Application
{
    /// <summary>
    /// Represents a simple class that runs a process
    /// </summary>
    public interface IProcessor
    {
        /// <summary>
        /// Invokes the process
        /// </summary>
        Task ProcessAsync(CancellationToken cancellationToken = default);
    }
}
