using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides consumers with the current CommandContext
    /// </summary>
    public interface ICommandContextProvider : IProvider<CommandContext>
    {
        /// <summary>
        /// Sets the current CommandContext
        /// </summary>
        /// <param name="context">The current CommandContext</param>
        void Set(CommandContext context);
    }
}
