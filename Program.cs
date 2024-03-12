using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineFreightManager;
using AirlineFreightManager.Order;
using AirlineFreightManager.Flight;
using AirlineFreightManager.Airport;
using Newtonsoft.Json;

namespace AirlineFreightManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "";
            //USER STORY #1  
            if(args!=null && args.Length > 0)
            {
                filePath = args[0];
            }
            FlightRepository flightRepository = new FlightRepository(filePath);
            FlightScheduler inventoryManagement = new FlightScheduler(flightRepository);
            inventoryManagement.LoadFlightSchedule();

            //USER STORY #2  
            if (args != null && args.Length > 1)
            {
                filePath = args[1];
            }
            OrderRepository orderRepository = new OrderRepository(filePath);
            OrderProcessor orderProcessor = new OrderProcessor(orderRepository, flightRepository);
            orderProcessor.ScheduleOrder();
            Console.ReadLine();
        }
    }
}
