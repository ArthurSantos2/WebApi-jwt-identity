using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Domain.Entities;
using WebApi.Infraestructure.Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("/api/List")]
        public async Task<object> List(CancellationToken cancellationToken)
        {
            return await _productRepository.List(cancellationToken);
        }

        [HttpPost("/api/Add")]
        public async Task<object> Add(ProductModel product, CancellationToken cancellationToken)
        {
            try
            {
                await _productRepository.Add(product, cancellationToken);
            }
            catch (Exception ex)
            {

            }

            return Task.FromResult("OK");
        }

        [HttpPut("/api/Update")]
        public async Task<object> Update(ProductModel product, CancellationToken cancellationToken)
        {
            try
            {
                await _productRepository.Update(product, cancellationToken);
            }
            catch (Exception ERRO)
            {

            }

            return Task.FromResult("OK");
        }


        [HttpGet("/api/GetEntityById")]
        public async Task<object> GetEntityById(int id, CancellationToken cancellationToken)
        {
            return await _productRepository.GetById(id, cancellationToken);
        }

        [HttpDelete("/api/Delete")]
        [Produces("application/json")]
        public async Task<object> Delete(int id, CancellationToken cancellationToken)
        {
            try
            {
                var product = await _productRepository.GetById(id,cancellationToken);

                await _productRepository.Delete(product, cancellationToken);

            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }

    }
}
