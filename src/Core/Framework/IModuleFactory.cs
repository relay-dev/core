namespace Core.Data
{
    /// <summary>
    /// Creates types that implement the IModule interface for Commands
    /// </summary>
    public interface IModuleFactory : IFactory
    {
        /// <summary>
        /// Creates the Module type requested
        /// </summary>
        /// <typeparam name="IModule">Type of the Module to be returned</typeparam>
        /// <returns>A new instance of an object of type IModule</returns>
        new IModule Create<IModule>();
    }
}
