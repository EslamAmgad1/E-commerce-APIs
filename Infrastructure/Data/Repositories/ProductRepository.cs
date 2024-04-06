using Core.Interfaces;
using Core.Models;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _storeContext;

        public ProductRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _storeContext.Products.Include(p => p.ProductBrand).Include(p => p.ProductType).AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _storeContext.Products.Include(p=>p.ProductBrand).Include(p=>p.ProductType).AsNoTracking().SingleOrDefaultAsync(p =>p.Id==id);
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await _storeContext.ProductBrands.AsNoTracking().ToListAsync();
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            return await _storeContext.ProductTypes.AsNoTracking().ToListAsync();
        }
    }
}
