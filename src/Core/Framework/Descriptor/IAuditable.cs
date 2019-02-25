namespace Core.Framework.Descriptor
{
    /// <summary>
    /// Indicates this class has properties used to capture the artifacts around the creation and modification of the object
    /// </summary>
    public interface IAuditable : IHaveCreatedFields, IHaveModifiedFields { }
}
