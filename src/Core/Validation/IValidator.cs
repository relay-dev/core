namespace Core.Validation
{
    /// <summary>
    /// A generic abstraction of a validation mechanism
    /// </summary>
    public interface IValidator<TToValidate>
    {
        /// <summary>
        /// Runs a rules validator against the given instance
        /// </summary>
        /// <param name="instance">The object to run the validator on</param>
        /// <returns>The result of the validation</returns>
        ValidatorResult Validate(TToValidate instance);

        /// <summary>
        /// Runs a rules validator against the given instance using the specified rule set
        /// </summary>
        /// <param name="instance">The object to run the validator on</param>
        /// <param name="ruleSet">The name of the ruleSet to run</param>
        /// <returns>The result of the validation</returns>
        ValidatorResult Validate(TToValidate instance, string ruleSet);
    }
}
