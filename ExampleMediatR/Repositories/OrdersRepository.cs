using System;
using System.Collections.Generic;
using ExampleMediatR.Dtos;

namespace ExampleMediatR.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        

        private readonly List<Order> _orders = new List<Order>
        {
            new Order{ID = 1, DeliveryDate = DateTime.Now, Delivered = false },
            new Order{ID = 2, DeliveryDate = DateTime.Now, Delivered = true },
            new Order{ID = 3, DeliveryDate = DateTime.Now, Delivered = false },
        };


        public List<Order> GetOrdersAsync()
        {
            return _orders;
        }
    }
}
