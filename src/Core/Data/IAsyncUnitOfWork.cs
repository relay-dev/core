using System.Threading.Tasks;

namespace Core.Data
{
    /// <summary>
    /// A generic abstraction of an asyncronous unit of work
    /// </summary>
    public interface IAsyncUnitOfWork
    {
        /// <summary>
        /// Asyncronously persists all pending changes to the data source
        /// </summary>
        /// <returns>Count of rows affected</returns>
        Task<int> Commit();
    }
}
