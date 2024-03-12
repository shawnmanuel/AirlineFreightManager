using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Flight
{
    public class FlightConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IFlight);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                // Read the order object properties
                long id = -1, day = -1;
                string departure = "", arrival = "";
                while (reader.TokenType != JsonToken.EndObject)
                {
                    reader.Read(); // Skip the start object token
                    reader.Read(); // Skip the flightNumber token
                    id = (long)reader.Value;
                    reader.Read(); // Skip the start object token
                    reader.Read(); // Skip the departure token
                    departure = (string)reader.Value;
                    reader.Read(); // Skip the start object token
                    reader.Read(); // Skip the arrival token
                    arrival = (string)reader.Value;
                    reader.Read(); // Skip the start object token
                    reader.Read(); // Skip the day token
                    day = (long)reader.Value;
                    reader.Read(); // Skip the start object token
                }


                // Read the order object properties
                Flight flightData = flightData = new Flight((int)id, departure, arrival, (int)day);
                // Create a new Flight object with the parsed data
                return flightData; 
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
