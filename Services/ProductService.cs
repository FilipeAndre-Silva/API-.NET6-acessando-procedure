using EcommerceApi.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProProduct()
        {
            return await _context.Products.FromSqlRaw("EXEC [ProcProducts]").ToListAsync();
        }
    }
}