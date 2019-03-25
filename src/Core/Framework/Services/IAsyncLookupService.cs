using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Framework.Services
{
    /// <summary>
    /// A generic abstraction of an asyncronous service that retuns static lookup data
    /// </summary>
    /// <typeparam name="TItem">The type of item to be returned</typeparam>
    public interface IAsyncLookupService<TItem> : IService
    {
        /// <summary>
        /// Returns all lookup data items
        /// </summary>
        /// <returns>A collection of all items</returns>
        Task<IEnumerable<TItem>> GetAll();
    }
}
