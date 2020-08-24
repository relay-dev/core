using Core.Framework;

namespace Core.Providers
{
    /// <summary>
    /// Provides consumers with the current CommandContext
    /// </summary>
    public interface ICommandContextProvider
    {
        /// <summary>
        /// Gets the current CommandContext
        /// </summary>
        /// <returns>The current CommandContext</returns>
        CommandContext Get();

        /// <summary>
        /// Sets the current CommandContext
        /// </summary>
        /// <param name="context">The current CommandContext</param>
        void Set(CommandContext context);
    }
}
