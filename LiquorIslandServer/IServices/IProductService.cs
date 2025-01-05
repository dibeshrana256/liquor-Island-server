using LiquorIslandServer.Controllers.Models;

namespace LiquorIslandServer.IServices
{
    public interface IProductService
    {
        public Task<List<Product>> GetProductsAsync();
    }
}
