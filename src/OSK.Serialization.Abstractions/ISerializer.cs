using System;
using System.Threading;
using System.Threading.Tasks;

namespace OSK.Serialization.Abstractions
{
    public interface ISerializer
    {
        ValueTask<object> DeserializeAsync(byte[] data, Type type, CancellationToken cancellationToken = default);

        ValueTask<byte[]> SerializeAsync(object data, CancellationToken cancellationToken = default);
    }
}
