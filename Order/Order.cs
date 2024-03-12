using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineFreightManager.Flight;

namespace AirlineFreightManager.Order
{

    // Order implementation
    public class Order : IOrder
    {
        public string Id { get; set; }
        public string Destination { get; private set; }
        public IFlight Flight { get; set; }

        public Order(string id, Dictionary<string, object> orderData)
        {
            Id = id;
            Destination = (string)orderData["destination"];
        }
    }
}
