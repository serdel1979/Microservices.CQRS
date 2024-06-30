using MediatR;
using OrderService.Models;

namespace OrderService.Services
{
    public class GetOrdersQuery : IRequest<List<Order>>
    {
    }
}
