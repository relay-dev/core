namespace Core.Data
{
    /// <summary>
    /// Providers simply provide consumers with something, by way of either a read-only property, or a getter method with no input
    /// </summary>
    public interface IProvider<TToProvide>
    {
        /// <summary>
        /// Returns the type requested
        /// </summary>
        /// <returns>The type requested</returns>
        TToProvide Get();
    }
}
