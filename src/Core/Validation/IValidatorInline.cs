using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Validation
{
    /// <summary>
    /// A generic abstraction of an inline validation mechanism
    /// </summary>
    public interface IValidatorInline
    {
        /// <summary>
        /// Validate against a generic expression
        /// </summary>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline Not(Expression<Func<bool>> expression);

        /// <summary>
        /// Validate against the default value for the given type
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline NotDefault<T>(Expression<Func<T>> expression);

        /// <summary>
        /// Validate against enums where Undefined is set
        /// </summary>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline NotEnumUndefined(Expression<Func<Enum>> expression);

        /// <summary>
        /// Validate against greater than
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <param name="value">The object or property to validate against</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline NotGreaterThan<T>(Expression<Func<T>> expression, T value) where T : IComparable;

        /// <summary>
        /// Validate against greater than or equal to
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <param name="value">The object or property to validate against</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline NotGreaterThanOrEqual<T>(Expression<Func<T>> expression, T value) where T : IComparable;

        /// <summary>
        /// Validate against an invalidate ID
        /// </summary>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline NotInvalidID(Expression<Func<long>> expression);

        /// <summary>
        /// Validate against not less than
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <param name="value">The object or property to validate against</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline NotLessThan<T>(Expression<Func<T>> expression, T value) where T : IComparable;

        /// <summary>
        /// Validate against less than or equal to
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <param name="value">The object or property to validate against</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline NotLessThanOrEqual<T>(Expression<Func<T>> expression, T value) where T : IComparable;

        /// <summary>
        /// Validate against a null object
        /// </summary>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline NotNull(Expression<Func<object>> expression);

        /// <summary>
        /// Validate against a null or empty string
        /// </summary>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline NotNullOrEmpty(Expression<Func<string>> expression);

        /// <summary>
        /// Validate against a null or empty collection
        /// </summary>
        /// <typeparam name="T">The input type for the Func{T} within the expression</typeparam>
        /// <param name="expression">An expression that represents the rule which should trigger a validation failure</param>
        /// <returns>This validator, for the sake of a fluent API</returns>
        IValidatorInline NotNullOrEmptyCollection<T>(Expression<Func<ICollection<T>>> expression);

        /// <summary>
        /// Runs the validation and throws a <see cref="CoreException"/> if the validation fails
        /// </summary>
        void Validate();
    }
}
