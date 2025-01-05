using LiquorIslandServer.Controllers.Models;
using LiquorIslandServer.IServices;
using Microsoft.AspNetCore.Mvc;
using Supabase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiquorIslandServer.Controllers
{
   
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetProducts")]
        public async Task<List<Product>> GetProductsAsync()
        {
            try
            {
                var response = await _productService.GetProductsAsync();
                var val = response.Count();
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }  
   
}
