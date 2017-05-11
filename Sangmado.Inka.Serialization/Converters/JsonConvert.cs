
namespace Sangmado.Inka.Serialization
{
    public class JsonConvert
    {
        private readonly static Newtonsoft.Json.JsonSerializerSettings _serializerSettings =
            new Newtonsoft.Json.JsonSerializerSettings()
            {
                Formatting = Newtonsoft.Json.Formatting.None,
                ConstructorHandling = Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor,
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.None,
                ContractResolver = GenericJsonIgnoreContractResolver.Singleton(),
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateParseHandling = Newtonsoft.Json.DateParseHandling.DateTime,
                MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include,
            };

        private readonly static Newtonsoft.Json.JsonSerializerSettings _indentedSerializerSettings =
            new Newtonsoft.Json.JsonSerializerSettings()
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                ConstructorHandling = Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor,
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.None,
                ContractResolver = GenericJsonIgnoreContractResolver.Singleton(),
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateParseHandling = Newtonsoft.Json.DateParseHandling.DateTime,
                MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include,
            };

        private readonly static Newtonsoft.Json.JsonSerializerSettings _deserializerSettings =
            new Newtonsoft.Json.JsonSerializerSettings()
            {
                Formatting = Newtonsoft.Json.Formatting.None,
                ConstructorHandling = Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor,
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.None,
                ContractResolver = GenericJsonIgnoreContractResolver.Singleton(),
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateParseHandling = Newtonsoft.Json.DateParseHandling.DateTime,
                MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Include,
            };

        public static string SerializeObject(object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj, _serializerSettings);
        }

        public static string SerializeObject(object obj, Formatting formatting)
        {
            var settings = formatting == Formatting.Indented ? _indentedSerializerSettings : _serializerSettings;
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj, settings);
        }

        public static T DeserializeObject<T>(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json, _deserializerSettings);
        }

        public static string Prettify(string json)
        {
            try
            {
                return Newtonsoft.Json.Linq.JToken.Parse(json).ToString(Newtonsoft.Json.Formatting.Indented);
            }
            catch
            {
                return json;
            }
        }
    }
}
