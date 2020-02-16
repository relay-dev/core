using System;

namespace Core.Data.Entity
{
    /// <summary>
    /// A generic representation of an object that represents a readonly record
    /// </summary>
    public class ReadOnlyEntity : IReadEntityOnly
    {
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
