using GraphQLAPI.Interfaces;
using GraphQLAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productService.GetProducts();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return productService.GetProductById(id);
        }

        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            return productService.AddProduct(product);
        }

        [HttpPut("{id}")]
        public Product Put(int id, [FromBody] Product product)
        {
            return productService.UpdateProduct(id, product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            productService.DeleteProduct(id);
        }
    }
}
