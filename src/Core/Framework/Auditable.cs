using System;

namespace Core.Framework
{
    /// <summary>
    /// A generic representation of an object that represents a record
    /// </summary>
    public class Auditable : ReadOnly, IAuditable
    {
        /// <summary>
        /// The person, process or application that modified the object
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// The date and time the object was modified
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
    }
}
