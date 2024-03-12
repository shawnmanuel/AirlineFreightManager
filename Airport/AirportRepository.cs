using AirlineFreightManager.Order;
using AirlineFreightManager.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Airport
{
    // OrderRepository implementation (reading JSON)
    public class AirportRepository : IAirportRepository
    {
        public List<Airport> airports {  get; private set; }

        public AirportRepository()
        {
            // Logic to read orders from JSON file using path
            string filePath = "coding-assigment-airports.json";
            JsonFileReader jsonFileReader = new JsonFileReader();
            string json = jsonFileReader.ReadFile(filePath);
            // Parse the JSON into a dictionary with a slightly different structure
            airports = JsonConvert.DeserializeObject<List<Airport>>(json);
        }

        public IEnumerable<IAirport> GetAirports()
        { 
            return airports;
        }

        public IAirport GetAirport(string code)
        {
            return airports.FirstOrDefault(x=> x.Code == code);
        }
    }
}
