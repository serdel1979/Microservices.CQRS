using MediatR;
using OrderService.Models;

namespace OrderService.Services
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly OrderDbContext _context;

        CreateOrderCommandHandler(OrderDbContext context)
        {
            this._context = context;
        }

        public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Order order = new Order()
            {
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                OrderDate = DateTime.UtcNow
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(cancellationToken);

        }


    }
}
