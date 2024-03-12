using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineFreightManager.Flight;
using Newtonsoft.Json;

namespace AirlineFreightManager.Order
{

    // Order implementation
    public class Order : IOrder
    {
        [JsonProperty]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; private set; }
        public IFlight Flight { get; set; }

        public Order(string id, string destination)
        {
            Id = id;
            Destination = destination;
        }
    }
}
