using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Utilities
{
    /// <summary>
    /// A generic abstraction of an inline validation mechanism
    /// </summary>
    public interface IInlineValidator
    {
        /// <summary>
        /// Validate against a generic expression
        /// </summary>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator Not(Expression<Func<bool>> expression);

        /// <summary>
        /// Validate against the default value for the given type
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator NotDefault<T>(Expression<Func<T>> expression);

        /// <summary>
        /// Validate against enums where Undefined is set
        /// </summary>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator NotEnumUndefined(Expression<Func<Enum>> expression);

        /// <summary>
        /// Validate against greater than
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <param name="value">The object or property to validate against</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator NotGreaterThan<T>(Expression<Func<T>> expression, T value) where T : IComparable;

        /// <summary>
        /// Validate against greater than or equal to
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <param name="value">The object or property to validate against</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator NotGreaterThanOrEqual<T>(Expression<Func<T>> expression, T value) where T : IComparable;

        /// <summary>
        /// Validate against an invalidate Id
        /// </summary>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator NotInvalidID(Expression<Func<long>> expression);

        /// <summary>
        /// Validate against not less than
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <param name="value">The object or property to validate against</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator NotLessThan<T>(Expression<Func<T>> expression, T value) where T : IComparable;

        /// <summary>
        /// Validate against less than or equal to
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <param name="value">The object or property to validate against</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator NotLessThanOrEqual<T>(Expression<Func<T>> expression, T value) where T : IComparable;

        /// <summary>
        /// Validate against a null object
        /// </summary>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator NotNull(Expression<Func<object>> expression);

        /// <summary>
        /// Validate against a null or empty string
        /// </summary>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator NotNullOrEmpty(Expression<Func<string>> expression);

        /// <summary>
        /// Validate against a null or empty collection
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IInlineValidator NotNullOrEmptyCollection<T>(Expression<Func<ICollection<T>>> expression);

        /// <summary>
        /// Runs the validation and throws a <see cref="CoreException"/> if the validation fails
        /// </summary>
        void Validate();
    }
}
