namespace Core.Framework
{
    /// <summary>
    /// Providers simply provide consumers with something, by way of either a read-only property, or a getter method with no input
    /// </summary>
    /// <typeparam name="TToProvide">The type to provide</typeparam>
    public interface IProvider<TToProvide>
    {
        /// <summary>
        /// Returns the type requested
        /// </summary>
        /// <returns>The type requested</returns>
        TToProvide Get();
    }
}
