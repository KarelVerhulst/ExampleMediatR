using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ExampleMediatR.Dtos;
using ExampleMediatR.Queries;
using ExampleMediatR.Repositories;
using MediatR;

namespace ExampleMediatR.Handlers
{
    public class GetAllOrdersHandler: IRequestHandler<GetAllOrdersQuery, List<Order>>
    {
        private readonly IOrdersRepository _ordersRepository;
        //private readonly IMapper _mapper;

        public GetAllOrdersHandler(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public Task<List<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            //var orders = _ordersRepository.GetOrdersAsync();
            //return _mapper.MapOrderDtosToOrderResponses(orders);

            return Task.FromResult(_ordersRepository.GetOrdersAsync());
        }
    }
}
