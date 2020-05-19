using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Validation
{
    /// <summary>
    /// The result of a validation operation from the <see cref="IValidator{T}"/>
    /// </summary>
    public class ValidatorResult
    {
        /// <summary>
        /// Any failures that occured during validation
        /// </summary>
        private readonly IEnumerable<ValidatorFailure> _validatorFailures;

        /// <summary>
        /// Creates a new instance of a ValidationResult without setting any properties
        /// </summary>
        public ValidatorResult() { }

        /// <summary>
        /// Creates a new instance of a ValidationResult and sets all properties with inline syntax
        /// </summary>
        /// <param name="validatorFailures">Any failures that occured during validation</param>
        public ValidatorResult(IEnumerable<ValidatorFailure> validatorFailures)
        {
            _validatorFailures = validatorFailures;
        }

        /// <summary>
        /// Any failures that occured during validation
        /// </summary>
        public List<ValidatorFailure> Failures
        {
            get { return _validatorFailures.ToList(); }
        }

        /// <summary>
        /// Returns <c>true</c> if there were no validation failures; otherwise, <c>false</c>
        /// </summary>
        public bool IsValid
        {
            get { return _validatorFailures == null || !_validatorFailures.Any(); }
        }

        /// <summary>
        /// Throws a new <see cref="CoreException"/> if the result has any failures
        /// </summary>
        public void ThrowIfInvalid()
        {
            if (!IsValid)
            {
                throw new CoreException(ToString());
            }
        }

        /// <summary>
        /// Returns a string representation of the validation result
        /// </summary>
        /// <returns>A string representation of the validation result</returns>
        public override string ToString()
        {
            if (IsValid)
                return String.Empty;

            return String.Join(Environment.NewLine, GetFormattedErrors());
        }

        private List<string> GetFormattedErrors(bool includeTypeName = true)
        {
            if (IsValid)
                return new List<string>();

            return _validatorFailures.Select(failure =>
                String.Format("{0}{1}{2}{3}",
                    includeTypeName ? failure.TypeName : String.Empty,
                    includeTypeName ? "." : String.Empty,
                    failure.PropertyName,
                    SubstringAfter(SubstringAfter(failure.ErrorMessage, "'"), "'")))
                    .ToList();
        }

        private string SubstringAfter(string str, string removeBefore)
        {
            if (str == null)
                return null;

            if (removeBefore == null || !str.Contains(removeBefore))
                return str;

            try
            {
                return str.Substring(str.IndexOf(removeBefore, StringComparison.Ordinal) + 1);
            }
            catch
            {
                return str;
            }
        }
    }
}
