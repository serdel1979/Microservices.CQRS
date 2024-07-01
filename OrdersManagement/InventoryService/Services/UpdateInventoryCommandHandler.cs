using MediatR;

namespace InventoryService.Services
{
    public class UpdateInventoryCommandHandler : IRequestHandler<UpdateInventoryCommand>
    {
        private readonly InventoryDbContext _context;

        UpdateInventoryCommandHandler(InventoryDbContext context)
        {
            this._context = context;
        }

        public async Task Handle(UpdateInventoryCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindAsync(request.ProductId);
            if (product != null)
            {
                product.Stock -= request.Quantity;
                _context.Products.Update(product);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
