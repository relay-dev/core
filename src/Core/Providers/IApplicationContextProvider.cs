using Core.Application;
using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides consumers with the current ApplicationContext
    /// </summary>
    public class IApplicationContextProvider : IProvider<ApplicationContext>
    {
        private readonly ApplicationContext _applicationContext;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="applicationContext">The current ApplicationContext</param>
        public IApplicationContextProvider(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        /// <summary>
        /// Gets the current ApplicationContext
        /// </summary>
        /// <returns>The current ApplicationContext</returns>
        public ApplicationContext Get()
        {
            return _applicationContext;
        }
    }
}
