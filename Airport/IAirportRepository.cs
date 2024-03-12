using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Airport
{

    // Interface for Airport data access
    public interface IAirportRepository
    {
        IEnumerable<IAirport> GetAirports();
        IAirport GetAirport(string code);
    }
}
