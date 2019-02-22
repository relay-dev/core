using System;
using System.Linq.Expressions;

namespace Core.Validation
{
    /// <summary>
    /// Encapsulates everything needed to evaluate string lengths on a given type
    /// </summary>
    /// <typeparam name="T">The type for which the given StringLengthRule should apply</typeparam>
    public class StringLengthRule<T>
    {
        /// <summary>
        /// The maximum length permitted for the string
        /// </summary>
        public int MaxLength { get; set; }

        /// <summary>
        /// An expression that allows consumers to indicate which property on type T the given StringLengthRule is for
        /// </summary>
        public Expression<Func<T, string>> PropertySelector { get; set; }

        /// <summary>
        /// Creates a new instance of a StringLengthRule without setting any properties
        /// </summary>
        public StringLengthRule() { }

        /// <summary>
        /// Creates a new instance of a StringLengthRule and allows consumers to set all properties with inline syntax
        /// </summary>
        /// <param name="propertySelector">An expression that allows consumers to indicate which property on type T the given StringLengthRule is for</param>
        /// <param name="maxLength">Creates a new instance of a StringLengthRule without setting any properties</param>
        public StringLengthRule(Expression<Func<T, string>> propertySelector, int maxLength)
        {
            PropertySelector = propertySelector;
            MaxLength = maxLength;
        }
    }
}
