using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides Commands with sequential longs
    /// </summary>
    public interface ISequenceProvider : IProvider<long>
    {
        /// <summary>
        /// Gets the next long in the sequence, using the sequence name
        /// </summary>
        /// <param name="sequenceName">The name of the sequence to use</param>
        /// <returns>The next long in the sequence</returns>
        long Get(string sequenceName);
    }
}
