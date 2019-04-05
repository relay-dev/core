using System;

namespace Core.Framework
{
    /// <summary>
    /// Represents a row in a lookup table that follow platform conventions
    /// </summary>
    public class LookupData
    {
        /// <summary>
        /// The unique identifier of the record
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the object
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the object
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A short, unique code that represents the record
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The name to display on a UI
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The order to display this record on a UI
        /// </summary>
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Indicates whether or not the record is considered to be active
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// The person, process or application that created the object
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// The date and time the object was created
        /// </summary>
        public DateTime CreatedDate { get; set; }

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
