using Core.Framework.Descriptor;

namespace Core.Data.Entity
{
    /// <summary>
    /// A generic representation of an object that represents a readonly record
    /// </summary>
    public interface IReadOnlyEntity : IHaveAnID, IHaveCreatedFields { }
}
