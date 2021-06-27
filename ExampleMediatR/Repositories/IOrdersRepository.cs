using System;
using System.Collections.Generic;
using ExampleMediatR.Dtos;

namespace ExampleMediatR.Repositories
{
    public interface IOrdersRepository
    {
        List<Order> GetOrdersAsync();
        
    }
}
