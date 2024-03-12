using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Airport
{
    // Interface for Airport
    public interface IAirport
    {
        string Code { get; }
        string Name { get; }
    }
}
