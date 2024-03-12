using AirlineFreightManager.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Order
{
    // OrderRepository implementation (reading JSON)
    public class OrderRepository : IOrderRepository
    {
        public List<Order> orders { get; private set; }
        public OrderRepository(string filePath)
        {
            this.orders = new List<Order>();
            // Logic to read orders from JSON file using path
            if (filePath != null && filePath != "")
                filePath = "coding-assigment-orders.json";
            JsonFileReader jsonFileReader = new JsonFileReader();
            string json = jsonFileReader.ReadFile(filePath);
            // Parse the JSON into a dictionary with a slightly different structure
            Dictionary<string, Order> ordersDictionary = JsonConvert.DeserializeObject<Dictionary<string, Order>>(json);

            foreach (KeyValuePair<string, Order> order in ordersDictionary)
            {
                order.Value.Id = order.Key;
                this.orders.Add(order.Value);
            }
        }

        public IEnumerable<IOrder> GetOrders()
        {
            return orders;
        }
    }

}
