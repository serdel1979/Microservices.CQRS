using MediatR;

namespace InventoryService.Services
{
    public class UpdateInventoryCommand : IRequest
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
