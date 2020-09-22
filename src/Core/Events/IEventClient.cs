using System.Threading;
using System.Threading.Tasks;

namespace Core.Events
{
    /// <summary>
    /// A generic abstraction of a client that raises events
    /// </summary>
    public interface IEventClient
    {
        /// <summary>
        /// Raises an event
        /// </summary>
        /// <param name="subscriptionEventType">The event subscription's event type name</param>
        /// <param name="data">The payload for the event</param>
        /// <param name="cancellationToken">The current <see cref="CancellationToken"/></param>
        /// <returns>The unique identifier of the event</returns>
        Task<string> RaiseEventAsync(string subscriptionEventType, object data, CancellationToken cancellationToken);

        /// <summary>
        /// Raises an event
        /// </summary>
        /// <param name="subscriptionEventType">The event subscription's event type name</param>
        /// <param name="subject">The subject of the event</param>
        /// <param name="data">The payload for the event</param>
        /// <param name="cancellationToken">The current <see cref="CancellationToken"/></param>
        /// <returns>The unique identifier of the event</returns>
        Task<string> RaiseEventAsync(string subscriptionEventType, string subject, object data, CancellationToken cancellationToken);

        /// <summary>
        /// Raises an event
        /// </summary>
        /// <param name="e">The event to raise</param>
        /// <param name="cancellationToken">The current <see cref="CancellationToken"/></param>
        /// <returns>The unique identifier of the event</returns>
        Task<string> RaiseEventAsync(Event e, CancellationToken cancellationToken);
    }
}