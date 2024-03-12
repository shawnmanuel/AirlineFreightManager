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
        public List<IOrder> GetOrders()
        {
            // Logic to read orders from JSON file using path
            string filePath = "coding-assigment-orders.json";
            string json = "";
            using (StreamReader reader = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), filePath)))
            {
                json = reader.ReadToEnd();
            }

            // Parse the JSON into a dictionary with a slightly different structure
            Dictionary<string, Order> ordersDictionary = JsonConvert.DeserializeObject<Dictionary<string, Order>>(json, new JsonConverter[] { new OrderConverter() });

            // Convert the dictionary to a list (optional)
            List<IOrder> orders = new List<IOrder>(ordersDictionary.Values);

            return orders;
        }
    }

}
