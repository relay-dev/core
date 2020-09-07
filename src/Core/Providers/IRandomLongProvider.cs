using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides Commands with a random long
    /// </summary>
    public interface IRandomLongProvider : IProvider<long>
    {
        /// <summary>
        /// Provides Commands with a random long
        /// </summary>
        /// <param name="minValue">The lower limit of the number</param>
        /// <param name="maxValue">The upper limit of the number</param>
        /// <returns></returns>
        long Get(long minValue, long maxValue);
    }
}
