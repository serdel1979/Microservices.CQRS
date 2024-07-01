using MediatR;

namespace OrderService.Services.Commands
{
    public class CreateOrderCommand : IRequest
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
