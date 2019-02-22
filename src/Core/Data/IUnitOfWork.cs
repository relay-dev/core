using System;

namespace Core.Data
{
    /// <summary>
    /// A generic abstraction of a unit of work
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Persists all pending changes to the data source
        /// </summary>
        /// <returns>Count of rows affected</returns>
        int Commit();
    }
}
