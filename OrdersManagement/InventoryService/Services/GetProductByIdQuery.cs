using InventoryService.Models;
using MediatR;

namespace InventoryService.Services
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public string ProductId { get; set; }

        public GetProductByIdQuery(string productId)
        {
            ProductId = productId;
        }
    }
}
