using System.Data;

namespace Core.Data
{
    /// <summary>
    /// A generic abstraction of a database command parameter
    /// </summary>
    public class DatabaseCommandParameter
    {
        /// <summary>
        /// The name of the database parameter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The value that should be passed as part of this Command
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// The direction of the parameter (Input, Output, InputOutput or Return)
        /// </summary>
        public ParameterDirection Direction { get; set; }
    }
}
