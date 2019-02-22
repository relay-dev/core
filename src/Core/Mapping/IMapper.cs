namespace Core.Mapping
{
    /// <summary>
    /// A generic abstraction of a mapper mechanism
    /// </summary>
    public interface IMapper
    {
        /// <summary>
        /// Maps an object to a new instance of the destination type
        /// </summary>
        /// <typeparam name="TDestination">The type which should be mapped to and returned</typeparam>
        /// <param name="source">The input object, expected to be non-null and fully hydrated</param>
        /// <returns>A new instance of type TDestination, fully hydrated using the values from the source object</returns>
        TDestination MapToNew<TDestination>(object source);

        /// <summary>
        /// Maps an object over an existing instance of the destination type
        /// </summary>
        /// <typeparam name="TSource">The type which should be mapped from</typeparam>
        /// <typeparam name="TDestination">The type which should be mapped to</typeparam>
        /// <param name="source">The input object, expected to be non-null and fully hydrated</param>
        /// <param name="destination">The destination object</param>
        void MapOver<TSource, TDestination>(TSource source, TDestination destination);
    }
}
