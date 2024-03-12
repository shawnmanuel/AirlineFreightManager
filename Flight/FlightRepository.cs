using AirlineFreightManager.Order;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Flight
{
    // OrderRepository implementation (reading JSON)
    public class FlightRepository : IFlightRepository
    {
        public List<IFlight> GetFlights()
        {
            List<IFlight> flights = new List<IFlight>();

            // Logic to read orders from JSON file using path
            string filePath = "coding-assigment-flights.json";
            string json = "";
            using (StreamReader reader = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), filePath)))
            {
                json = reader.ReadToEnd();
            }

            // Parse the JSON into a dictionary with a slightly different structure
            flights = JsonConvert.DeserializeObject<List<IFlight>>(json, new JsonConverter[] { new FlightConverter() });

            return flights;
        }
    }
}
