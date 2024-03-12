using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Flight
{
    // Interface for Flights
    public interface IFlight
    {
        int FlightNumber { get; }
        string DepartureAirport { get; }
        string ArrivalAirport { get; }
        int Day { get; }
        int Capacity { get; }
        int AvailableSpace { get; set; }
    }
}
