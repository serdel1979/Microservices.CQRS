using InventoryService.Models;
using MediatR;

namespace InventoryService.Services
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly InventoryDbContext _context;

        public GetProductByIdQueryHandler(InventoryDbContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.FindAsync(request.ProductId);
        }
    
    }
}
