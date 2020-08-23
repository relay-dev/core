using System;

namespace Core.Framework
{
    /// <summary>
    /// Indicates this class has properties used to capture the artifacts around the modification of the object
    /// </summary>
    public interface IHaveModifiedFields
    {
        /// <summary>
        /// The person, process or application that modified the object
        /// </summary>
        string ModifiedBy { get; set; }

        /// <summary>
        /// The date and time the object was modified
        /// </summary>
        DateTime? ModifiedDate { get; set; }
    }
}
