using Core.Data;

namespace Core.Validation
{
    /// <summary>
    /// Creates types that implement the IValidator interface for Commands
    /// </summary>
    public interface IValidatorFactory : IFactory
    {
        /// <summary>
        /// Creates the Rules Validator type requested
        /// </summary>
        /// <typeparam name="TToValidate">Type for which the Rules Validator will be acting on</typeparam>
        /// <returns>A new instance of an object of type IRulesValidator</returns>
        new IValidator<TToValidate> Create<TToValidate>();
    }
}
