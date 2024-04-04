using WebApi.Entities;

namespace WebApi.Repository
{
    public interface IProductRepository
    {
        Task Add(ProductModel product);
        Task Update(ProductModel product);
        Task Delete(ProductModel product);
        Task<ProductModel> GetById(int id);
        Task<List<ProductModel>> List();
    }
}
