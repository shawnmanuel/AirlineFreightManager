using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Order
{
    public class OrderConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Order);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                // Read the order object properties
                Dictionary<string, object> orderData = new Dictionary<string, object>();
                string id = (string)reader.Path;
                reader.Read(); // Skip the start object token

                while (reader.TokenType != JsonToken.EndObject)
                {
                    string key = (string)reader.Value;
                    reader.Read(); // Skip the key token
                    object value = (string)reader.Value;
                    reader.Read(); // Skip the value token

                    orderData.Add(key, value);
                }

                // Create a new Order object with the parsed data
                return new Order(id, orderData); // Consider adding ID if needed
            }
            else
            {
                throw new JsonSerializationException("Unexpected token type while reading Order object.");
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); // We don't need to implement serialization yet
        }
    }

}
