using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Flight
{

    // Interface for Flight data access
    public interface IFlightRepository
    {
        List<IFlight> GetFlights();
    }
}
