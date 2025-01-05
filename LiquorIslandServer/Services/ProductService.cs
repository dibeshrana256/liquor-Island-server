using LiquorIslandServer.Controllers.Models;
using LiquorIslandServer.IServices;
using Supabase.Postgrest;

namespace LiquorIslandServer.Services
{
    public class ProductService:IProductService
    {
        private readonly Supabase.Client _client;

        public ProductService(Supabase.Client client)
        {
            _client = client;
        }
        public async Task<List<Product>> GetProductsAsync()
        {
            try
            {
                var response = await _client
                    .From<Product>()
                    .Limit(10) // Specify the limit directly
                    .Get();
                var val = response.Models.Count();
                return response.Models;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
