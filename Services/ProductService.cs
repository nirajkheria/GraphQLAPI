using GraphQLAPI.Data;
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
        private readonly GraphQLDbContext dbContext;

        public ProductService(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Product AddProduct(Product product)
        {
            dbContext.Add(product);
            dbContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            var objProduct = dbContext.Products.Find(id);
            dbContext.Products.Remove(objProduct);
            dbContext.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            var product = dbContext.Products.Find(id);
            return product;
        }

        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

        public Product UpdateProduct(int id, Product product)
        {
            var objProduct = dbContext.Products.Find(id);
            objProduct.Name = product.Name;
            objProduct.Price = product.Price;
            dbContext.SaveChanges();
            return product;
        }
    }
}
