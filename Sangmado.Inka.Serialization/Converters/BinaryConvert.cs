using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sangmado.Inka.Serialization
{
    public class BinaryConvert
    {
        public static byte[] SerializeObject(object obj)
        {
            byte[] data;

            BinaryFormatter formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, obj);
                data = stream.ToArray();
            }

            return data;
        }

        public static T DeserializeObject<T>(byte[] data)
        {
            return DeserializeObject<T>(data, data.Length);
        }

        public static T DeserializeObject<T>(byte[] data, int dataLength)
        {
            return DeserializeObject<T>(data, 0, dataLength);
        }

        public static T DeserializeObject<T>(byte[] data, int dataOffset, int dataLength)
        {
            T obj = default(T);

            BinaryFormatter formatter = new BinaryFormatter();
            using (var stream = new MemoryStream(data, dataOffset, dataLength))
            {
                obj = (T)formatter.Deserialize(stream);
            }

            return obj;
        }
    }
}
