namespace Core.Application
{
    /// <summary>
    /// Represents a simple class that runs a process
    /// </summary>
    public interface IProcessor
    {
        /// <summary>
        /// Invokes the process
        /// </summary>
        void Process();
    }
}
