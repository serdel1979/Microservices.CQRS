using MediatR;
using Microsoft.EntityFrameworkCore;
using OrderService.Models;

namespace OrderService.Services
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, List<Order>>
    {
        private readonly OrderDbContext _context;

        public GetOrdersQueryHandler(OrderDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Orders.ToListAsync(cancellationToken);
        }
    }
}
