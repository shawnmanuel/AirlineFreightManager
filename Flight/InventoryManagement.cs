using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Flight
{
    public class InventoryManagement
    {
        private readonly IFlightRepository _flightRepository;

        public InventoryManagement(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public void LoadFlightSchedule()
        {
            List<IFlight> flights = _flightRepository.GetFlights();
            Console.WriteLine("List Flight Schedule:");
            foreach (Flight flight in flights)
            {
                Console.WriteLine($"Flight: {flight.FlightNumber}, departure: {flight.DepartureAirport}, arrival: {flight.ArrivalAirport}, day: {flight.Day}");
            }
        }
    }
}
