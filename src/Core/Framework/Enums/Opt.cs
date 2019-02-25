namespace Core.Framework.Enums
{
    /// <summary>
    /// Provides clients with an option to Opt In or Out of a process (this is currently used by the IoC bootstrapper assembly scanner)
    /// </summary>
    public enum Opt
    {
        /// <summary>
        /// Not specified
        /// </summary>
        Undefined,

        /// <summary>
        /// Opt-in to an automated process
        /// </summary>
        In,

        /// <summary>
        /// Opt-out of an automated process
        /// </summary>
        Out
    }
}
