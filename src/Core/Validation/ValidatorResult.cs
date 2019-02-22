using Core.Exceptions;
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
        private readonly IEnumerable<ValidatorFailure> _failures;

        /// <summary>
        /// Creates a new instance of a RulesValidatorResult without setting any properties
        /// </summary>
        public ValidatorResult() { }

        /// <summary>
        /// Creates a new instance of a RulesValidatorResult and allows consumers to set all properties with inline syntax
        /// </summary>
        /// <param name="failures">Any failures that occured during validation</param>
        public ValidatorResult(IEnumerable<ValidatorFailure> failures)
        {
            _failures = failures;
        }

        /// <summary>
        /// Any failures that occured during validation
        /// </summary>
        public List<ValidatorFailure> Failures
        {
            get { return _failures.ToList(); }
        }

        /// <summary>
        /// Returns <c>true</c> if there were no validation failures; otherwise, <c>false</c>
        /// </summary>
        public bool IsValid
        {
            get { return _failures == null || !_failures.Any(); }
        }

        /// <summary>
        /// Throws a new <see cref="CoreException"/> if the result has any failures
        /// </summary>
        public void ThrowIfInvalid()
        {
            if (IsValid)
            {
                throw new CoreException(ToString());
            }
        }

        /// <summary>
        /// Returns a string representation of the validation result
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // ValidateAndReturnResultString() code to go here
            return base.ToString();
        }
    }
}
