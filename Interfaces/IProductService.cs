using GraphQLAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        Product UpdateProduct(int id, Product product);
        Product AddProduct(Product product);
        void DeleteProduct(int id);
    }
}
