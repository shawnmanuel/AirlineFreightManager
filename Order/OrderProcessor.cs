using AirlineFreightManager.Flight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Order
{
    // Flight Order schedulling logic
    public class OrderProcessor
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IFlightRepository _flightRepository;

        public OrderProcessor(IOrderRepository orderRepository, IFlightRepository flightRepository)
        {
            _orderRepository = orderRepository;
            _flightRepository = flightRepository;
        }

        public void ScheduleOrder()
        {
            IEnumerable<IFlight> flights = _flightRepository.GetFlights();
            IEnumerable<IOrder> orders = _orderRepository.GetOrders();
            Console.WriteLine("List Scheduled Order Flights:");

            foreach (Order order in orders)
            {
                // Find the first flight with matching destination and enough space
                IFlight matchingFlight = flights.FirstOrDefault(f => f.ArrivalAirport == order.Destination && f.AvailableSpace > 0);
                if (matchingFlight != null && matchingFlight.AddScheduledOrder(order))
                {
                    order.Flight = matchingFlight;
                    Console.WriteLine($"Order: {order.Id}, flightNumber: {order.Flight.FlightNumber}, departure: {order.Flight.DepartureAirport}, arrival: {order.Flight.ArrivalAirport}, day: {order.Flight.Day}");

                }
                else
                {
                    Console.WriteLine($"order: {order.Id}, flightNumber: not scheduled");
                }
            }
        }

    }
}
