using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApi.Config;
using WebApi.Entities;

namespace WebApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContextOptions<BaseContext> _options;
        public ProductRepository()
        {
            _options = new DbContextOptions<BaseContext>();
        }

        public async Task Add(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductModel>> List()
        {
            throw new NotImplementedException();
        }

        public async Task Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
