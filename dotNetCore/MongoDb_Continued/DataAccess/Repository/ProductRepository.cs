using Entity.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        MongoDbContext dbContext = new MongoDbContext();
        public void AddProduct(Product product)
        {
            try
            {
                dbContext.Products.InsertOne(product);
                Console.WriteLine("Added sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetProducts()
        {
            try
            {
                var products = dbContext.Products.Find(x => true).ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.ProductId}\t{product.ProductName}\t{product.Quantity}\t {product.Brand}\t{product.Price}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateProduct(int id, Product product)
        {
            try
            {
                var filter = Builders<Product>.Filter.Where(prod => prod.ProductId == id);
                var update = Builders<Product>.Update.Set(obj => obj.ProductName, product.ProductName).Set(obj => obj.Brand, product.Brand).Set(obj => obj.Quantity, product.Quantity).Set(obj => obj.Price, product.Price);
                dbContext.Products.UpdateOne(filter, update);
                Console.WriteLine("updated Product successfully!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteProduct(int id)
        {
            try
            {
                dbContext.Products.DeleteOne(x => x.ProductId == id);
                Console.WriteLine("deleted product Successfully!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        bool IProductRepository.IsProductExist(Product product)
        {
            var productExist = dbContext.Products.Find(products => products.ProductId == product.ProductId);
            if (productExist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

