using Microsoft.EntityFrameworkCore;
using StellaAccessories.Context;
using StellaAccessories.Models;

namespace StellaAccessories.Services
{
    public class ProductService : IProductService
    {
        public StellaDbContext db;
        public ProductService(StellaDbContext _db) {
            db = _db;
        }
        public async Task add(Product product)
        {
            await db.Products.AddAsync(product);
            
            
        }

        public async Task deleteById(int id)
        {
            Product? product = db.Products.SingleOrDefault(p => p.Id == id);
             db.Products.Remove(product);
        }

        public async Task<List<Product>> getAll()
        {
            return db.Products.ToList();
        }

        public async Task<Product> getById(int id)
        {
            Product product = db.Products.SingleOrDefault(p => p.Id == id);
            return product;
        }

        public async Task update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
