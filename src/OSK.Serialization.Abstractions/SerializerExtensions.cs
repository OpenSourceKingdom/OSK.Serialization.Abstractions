using System.Threading;
using System.Threading.Tasks;

namespace OSK.Serialization.Abstractions
{
    public static class SerializerExtensions
    {
        public static async Task<T> DeserializeAsync<T>(this ISerializer serializer, byte[] data, CancellationToken cancellationToken = default)
        {
            return (T)await serializer.DeserializeAsync(data, typeof(T), cancellationToken);
        }
    }
}
