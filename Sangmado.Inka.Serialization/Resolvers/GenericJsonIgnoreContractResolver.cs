using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sangmado.Inka.Serialization
{
    internal class GenericJsonIgnoreContractResolver : DefaultContractResolver
    {
        private static GenericJsonIgnoreContractResolver _instance = new GenericJsonIgnoreContractResolver();

        public static GenericJsonIgnoreContractResolver Singleton()
        {
            return _instance;
        }

        public GenericJsonIgnoreContractResolver()
            : base()
        {
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            var attributes = member.GetCustomAttributes(true);
            if (attributes != null
                && (attributes.Any(a => a.GetType().Name.StartsWith(@"XmlIgnore"))
                    || attributes.Any(a => a.GetType().Name.StartsWith(@"JsonIgnore"))
                    || attributes.Any(a => a.GetType().Name.StartsWith(@"NonSerialized"))))
            {
                property.Ignored = true;
            }

            return property;
        }
    }
}
