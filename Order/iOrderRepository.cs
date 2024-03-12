using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Order
{
    // Interface for Order data access
    public interface IOrderRepository
    {
        IEnumerable<IOrder> GetOrders();
    }
}
