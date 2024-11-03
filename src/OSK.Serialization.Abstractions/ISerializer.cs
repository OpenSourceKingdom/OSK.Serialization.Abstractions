using System;
using System.Threading;
using System.Threading.Tasks;

namespace OSK.Serialization.Abstractions
{
    public interface ISerializer
    {
        /// <summary>
        /// Deserializes a byte array of data into an object using the specified type.
        /// </summary>
        /// <param name="data">The byte array where the data is stored.</param>
        /// <param name="type">The expected type of the deserialized object.</param>
        /// <param name="cancellationToken">The token to cancel the operation</param>
        /// <returns>The object deserialized into the expected typed.</returns>
        ValueTask<object> DeserializeAsync(byte[] data, Type type, CancellationToken cancellationToken = default);

        /// <summary>
        /// Serializes an object into an array of bytes for storage.
        /// </summary>
        /// <param name="data">The object being serialized.</param>
        /// <param name="cancellationToken">The token to cancel the operation.</param>
        /// <returns>The byte representation of the serialized object.</returns>
        ValueTask<byte[]> SerializeAsync(object data, CancellationToken cancellationToken = default);
    }
}
