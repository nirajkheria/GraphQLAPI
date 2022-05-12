using GraphQLAPI.Interfaces;
using GraphQLAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPI.Services
{
    public class ProductService : IProductService
    {
        private static List<Product> products = new List<Product>
        {
            new Product{ Id = 0, Name = "Apple", Price = 10},
            new Product{ Id = 1, Name = "Mango", Price = 20}
        };

        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            products.RemoveAt(id);
        }

        public Product GetProductById(int id)
        {
            var product = products.Find(p=>p.Id == id);
            return product;
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product UpdateProduct(int id, Product product)
        {
            products[id] = product;
            return product;
        }
    }
}
