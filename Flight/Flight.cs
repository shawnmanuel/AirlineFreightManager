using AirlineFreightManager.Airport;
using AirlineFreightManager.Order;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Flight
{
    // Flight implementation
    public class Flight : IFlight
    {
        [JsonProperty(PropertyName = "flightNumber")]
        public int FlightNumber { get; set; }
        [JsonProperty(PropertyName = "departure")]
        public string DepartureAirport { get; set; }
        
        public IAirport departureAirport { get; set; }

        [JsonProperty(PropertyName = "arrival")]
        public string ArrivalAirport { get; set; }
        public IAirport arrivalAirport { get; set; }
        [JsonProperty(PropertyName = "day")]
        public int Day { get; set; }
        public DateTime ScheduledDeparture { get; set; }

        [JsonProperty(PropertyName = "capacity")]
        public int Capacity { get; set; } // Replace with actual plane capacity (20 in this example)

        public int AvailableSpace { get; private set; } // Remaining space for orders
        List<IOrder> Orders { get; set; }

        public Flight(int flightNumber, string departureAirport, string arrivalAirport, int day)
        {
            Orders = new List<IOrder>();
            FlightNumber = flightNumber;
            Capacity = 20; // Replace with actual plane capacity
            AvailableSpace = Capacity;
            Day = day;
            DateTime current = DateTime.Now;
            current = current.AddDays(day-1);
            ScheduledDeparture = current;
            DepartureAirport = departureAirport;
            ArrivalAirport = arrivalAirport;
            AirportRepository airportRepository = new AirportRepository();
            airportRepository.GetAirports();
            this.departureAirport = airportRepository.GetAirport(DepartureAirport);
            this.arrivalAirport = airportRepository.GetAirport(ArrivalAirport);
        }

        public bool AddScheduledOrder(IOrder order)
        {
            if (AvailableSpace > 0)
            {
                AvailableSpace--;
                Orders.Add(order);
                return true;
            }
            else
            {
                Console.WriteLine($"Cannot add Order: {order.Id} to flight: {order.Flight.FlightNumber} already at full capacity");
                return false;
            }
        }

    }
}
