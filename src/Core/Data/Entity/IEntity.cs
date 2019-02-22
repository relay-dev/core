using Core.Data.Descriptor;

namespace Core.Data.Entity
{
    /// <summary>
    /// A generic representation of an object that represents a record
    /// </summary>
    public interface IEntity : IHaveAnID, IAuditable { }
}
