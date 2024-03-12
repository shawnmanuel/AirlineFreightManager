using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Airport
{
    public class AirportManagement
    {
        private readonly IAirportRepository _airportRepository;

        public AirportManagement(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        public void LoadAirportSchedule()
        {
            IEnumerable<IAirport> airports = _airportRepository.GetAirports();
            Console.WriteLine("List Flight Schedule:");
            foreach (Airport airport in airports)
            {
                Console.WriteLine($"Airport Code: {airport.Code}, name: {airport.Name}");
            }
        }
    }
}
