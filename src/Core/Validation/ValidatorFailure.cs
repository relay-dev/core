namespace Core.Validation
{
    /// <summary>
    /// The result of a single rule failure
    /// </summary>
    public class ValidatorFailure
    {
        private readonly string _typeName;
        private readonly string _propertyName;
        private readonly string _errorMessage;

        /// <summary>
        /// Creates a new instance of a RulesValidatorFailure without setting any properties
        /// </summary>
        public ValidatorFailure() { }

        /// <summary>
        /// Creates a new instance of a RulesValidatorFailure and allows consumers to set all properties with inline syntax
        /// </summary>
        /// <param name="typeName">The name of the type on which the validation failure occured</param>
        /// <param name="propertyName">The name of the property on which the validation failure occured</param>
        /// <param name="errorMessage">An error message string that represents the RulesValidatorFailure</param>
        public ValidatorFailure(string typeName, string propertyName, string errorMessage)
        {
            _typeName = typeName;
            _propertyName = propertyName;
            _errorMessage = errorMessage;
        }
        
        /// <summary>
        /// The name of the type on which the validation failure occured
        /// </summary>
        public string TypeName
        {
            get { return _typeName; }
        }

        /// <summary>
        /// The name of the property on which the validation failure occured
        /// </summary>
        public string PropertyName
        {
            get { return _propertyName; }
        }

        /// <summary>
        /// An error message string that represents the RulesValidatorFailure
        /// </summary>
        public string ErrorMessage
        {
            get { return _errorMessage; }
        }
    }
}
