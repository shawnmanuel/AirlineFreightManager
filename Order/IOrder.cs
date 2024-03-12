using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineFreightManager.Flight;

namespace AirlineFreightManager.Order
{
    // Interface for Orders
    public interface IOrder
    {
        string Id { get; }
        string Destination { get; }
        IFlight Flight { get; set; }
    }
}
