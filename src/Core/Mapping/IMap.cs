namespace Core.Mapping
{
    /// <summary>
    /// A generic abstraction of a class that specifies mapping details
    /// </summary>
    public interface IMap
    {
        /// <summary>
        /// Called by the framework at application startup to initialize an IMap to be used by the IMapper
        /// </summary>
        void Configure();
    }
}
