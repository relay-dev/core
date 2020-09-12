using System.Threading;
using System.Threading.Tasks;

namespace Core.Utilities
{
    /// <summary>
    /// A generic abstraction of a JSON serializer
    /// </summary>
    public interface IJsonSerializer
    {
        /// <summary>
        /// Serializes an object to a JSON string
        /// </summary>
        /// <param name="objectToSerialize">The object to serialize</param>
        /// <param name="options">Options to be used by the serializer</param>
        /// <returns>The serialized object as a JSON string</returns>
        string Serialize(object objectToSerialize, SerializerOptions options = null);

        /// <summary>
        /// Serializes an object to a JSON string
        /// </summary>
        /// <param name="objectToSerialize">The object to serialize</param>
        /// <param name="cancellationToken">The current <see cref="CancellationToken"/></param>
        /// <param name="options">Options to be used by the serializer</param>
        /// <returns>The serialized object as a JSON string</returns>
        Task<string> SerializeAsync(object objectToSerialize, CancellationToken cancellationToken, SerializerOptions options = null);

        /// <summary>
        /// Deserializes a JSON string to an object
        /// </summary>
        /// <typeparam name="TReturn">The object type to deserialize the string to</typeparam>
        /// <param name="json">The JSON string to use as a source in the deserialization</param>
        /// <param name="options">Options to be used by the serializer</param>
        /// <returns>The deserialization result</returns>
        TReturn Deserialize<TReturn>(string json, SerializerOptions options = null);

        /// <summary>
        /// Deserializes a JSON string to an object
        /// </summary>
        /// <typeparam name="TReturn">The object type to deserialize the string to</typeparam>
        /// <param name="json">The JSON string to use as a source in the deserialization</param>
        /// <param name="cancellationToken">The current <see cref="CancellationToken"/></param>
        /// <param name="options">Options to be used by the serializer</param>
        /// <returns>The deserialization result</returns>
        Task<TReturn> DeserializeAsync<TReturn>(string json, CancellationToken cancellationToken, SerializerOptions options = null);
    }
}