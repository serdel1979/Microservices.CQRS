using MediatR;

namespace OrderService.Services
{
    public class CreateOrderCommand : IRequest
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
