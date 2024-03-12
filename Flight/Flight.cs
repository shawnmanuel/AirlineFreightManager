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
        public int FlightNumber { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public int Day { get; set; }
        public int Capacity { get; set; } // Replace with actual plane capacity (20 in this example)
        public int AvailableSpace { get; set; } // Remaining space for orders

        public Flight(int flightNumber, string departureAirport, string arrivalAirport, int day)
        {
            FlightNumber = flightNumber;
            DepartureAirport = departureAirport;
            ArrivalAirport = arrivalAirport;
            Day = day;
            Capacity = 20; // Replace with actual plane capacity
            AvailableSpace = Capacity;
        }
    }
}
