namespace Core.Framework
{
    /// <summary>
    /// Indicates this class has a property called Id of type long that has a public setter and getter. Used by polymorphic methods that need to check for a non-zero Id to know whether to insert or update
    /// </summary>
    public interface IHaveAnId<TId>
    {
        /// <summary>
        /// The Id of the object
        /// </summary>
        TId Id { get; set; }
    }
}
