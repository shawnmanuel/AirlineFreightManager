using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineFreightManager;
using AirlineFreightManager.Order;
using AirlineFreightManager.Flight;
using Newtonsoft.Json;

namespace AirlineFreightManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //USER STORY #1  

            FlightRepository flightRepository = new FlightRepository();
            InventoryManagement inventoryManagement = new InventoryManagement(flightRepository);
            inventoryManagement.LoadFlightSchedule();

            //USER STORY #2  

            OrderRepository orderRepository = new OrderRepository();
            OrderProcessor orderProcessor = new OrderProcessor(orderRepository, flightRepository);
            orderProcessor.AssignOrdersToFlights();
            Console.ReadLine();
        }
    }
}
