using System.IO;
using System.Reflection;

namespace Sangmado.Inka.Serialization.UnitTests
{
    public static class EmbeddedResourceLoader
    {
        public static string LoadAsString(string resourcePath)
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
