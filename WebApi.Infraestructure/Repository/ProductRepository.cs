using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Entities;
using WebApi.Infraestructure.Config;

namespace WebApi.Infraestructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContextOptions<BaseContext> _options;
        public ProductRepository()
        {
            _options = new DbContextOptions<BaseContext>();
        }

        public async Task Add(ProductModel product, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var data = new BaseContext(_options))
            {
                data.Set<ProductModel>().Add(product);
                await data.SaveChangesAsync();
            }

            await Task.CompletedTask;
        }

        public async Task Delete(ProductModel product, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var data = new BaseContext(_options))
            {
                data.Set<ProductModel>().Remove(product);
                await data.SaveChangesAsync();
            }

            await Task.CompletedTask;
        }

        public async Task<ProductModel> GetById(int id, CancellationToken cancellationToken)
        {
            using (var data = new BaseContext(_options))
            {
                return await data.Set<ProductModel>().FindAsync(id, cancellationToken);
            }
        }

        public async Task<List<ProductModel>> List(CancellationToken cancellationToken)
        {
            using (var data = new BaseContext(_options))
            {
                return await data.Set<ProductModel>().ToListAsync(cancellationToken);
            }
        }

        public async Task Update(ProductModel product, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var data = new BaseContext(_options))
            {
                data.Set<ProductModel>().Update(product);
                await data.SaveChangesAsync();
            }

            await Task.CompletedTask;
        }
    }
}
