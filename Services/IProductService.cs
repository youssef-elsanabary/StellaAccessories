using StellaAccessories.Models;

namespace StellaAccessories.Services
{
    public interface IProductService
    {
        public Task<List<Product>> getAll() ;
        public Task<Product> getById(int id) ;
        public Task add(Product product) ;
        public Task update(Product product) ;
        public Task deleteById(int id) ;
    }
}
