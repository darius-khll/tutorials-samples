using OwinKatanaSample.Model;
using System.Collections.Generic;
using System.Web.Http;

namespace OwinKatanaSample.ApiControllers
{
    public class ProductsController : ApiController
    {
        [HttpGet]
        [Route("products/{categoryId}")]
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return new List<Product>
            {
                new Product { Id = 1 , Name = "Test" }
            };
        }
    }
}