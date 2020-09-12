using System;

namespace Core.Events
{
    /// <summary>
    /// A generic abstraction of an event
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Event()
        {
            Id = Guid.NewGuid().ToString();
            Subject = "Event-Raised";
            DataVersion = "1.01";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="topic">The unique identifier of the event</param>
        /// <param name="eventType">The event type (ex. in Azure, this is the Subscription Event Type)</param>
        /// <param name="data">The payload of the event</param>
        public Event(string topic, string eventType, object data) : this()
        {
            Topic = topic;
            EventType = eventType;
            Data = data;
        }

        /// <summary>
        /// The unique identifier of the event
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The topic to publish the event to
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// The subject of the event
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The payload of the event
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// The event type (ex. in Azure, this is the Subscription Event Type)
        /// </summary>
        public string EventType { get; set; }

        /// <summary>
        /// The version of the schema for this event
        /// </summary>
        public string DataVersion { get; set; }
    }
}
