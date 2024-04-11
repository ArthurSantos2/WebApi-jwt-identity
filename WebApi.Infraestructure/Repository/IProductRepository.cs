
using WebApi.Domain.Entities;

namespace WebApi.Infraestructure.Repository
{
    public interface IProductRepository
    {
        Task Add(ProductModel product, CancellationToken cancellationToken);
        Task Update(ProductModel product, CancellationToken cancellationToken);
        Task Delete(ProductModel product, CancellationToken cancellationToken);
        Task<ProductModel> GetById(int id, CancellationToken cancellationToken);
        Task<List<ProductModel>> List(CancellationToken cancellationToken);
    }
}
