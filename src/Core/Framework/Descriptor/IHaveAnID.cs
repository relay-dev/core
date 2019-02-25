namespace Core.Framework.Descriptor
{
    /// <summary>
    /// Indicates this class has a property called Id of type long that has a public setter and getter. Used by polymorphic methods that need to check for a non-zero Id to know whether to insert or update
    /// </summary>
    public interface IHaveAnID
    {
        /// <summary>
        /// The ID of the object
        /// </summary>
        long ID { get; set; }
    }
}
