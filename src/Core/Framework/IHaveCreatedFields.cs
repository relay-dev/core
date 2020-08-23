using System;

namespace Core.Framework
{
    /// <summary>
    /// Indicates this class has properties used to capture the artifacts around the creation of the object
    /// </summary>
    public interface IHaveCreatedFields
    {
        /// <summary>
        /// The person, process or application that created the object
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// The date and time the object was created
        /// </summary>
        DateTime CreatedDate { get; set; }
    }
}
