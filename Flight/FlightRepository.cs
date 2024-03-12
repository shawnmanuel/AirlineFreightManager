using AirlineFreightManager.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Flight
{
    // FlightRepository implementation (reading JSON)
    public class FlightRepository : IFlightRepository
    {
        List<Flight> flights = new List<Flight>();
        public FlightRepository(string filePath)
        {
            // Logic to read orders from JSON file using path
            if (filePath != null && filePath != "")
                filePath = "coding-assigment-flights.json";

            JsonFileReader jsonFileReader = new JsonFileReader();
            string json = jsonFileReader.ReadFile(filePath);

            // Parse the JSON into a dictionary with a slightly different structure
            flights = JsonConvert.DeserializeObject<List<Flight>>(json);
        }
        public IEnumerable<IFlight> GetFlights()
        {
            return flights;
        }
    }
}
