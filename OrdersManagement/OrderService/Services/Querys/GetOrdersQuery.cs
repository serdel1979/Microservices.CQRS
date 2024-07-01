using MediatR;
using OrderService.Models;

namespace OrderService.Services.Querys
{
    public class GetOrdersQuery : IRequest<List<Order>>
    {
    }
}
