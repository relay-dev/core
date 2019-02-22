using System;

namespace Core.Data.Entity
{
    /// <summary>
    /// A generic representation of an object that represents a readonly record
    /// </summary>
    public class ReadOnlyEntity : IReadOnlyEntity
    {
        /// <summary>
        /// The ID of the object
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// The person, process or application that created the object
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// The date and time the object was created
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
