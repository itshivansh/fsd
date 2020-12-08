
using Entities.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace DataDAL.Repository
{
    public class ProductRepository:IProductRepository
    {
        
        List<Product> product = new List<Product>();
        MongoDBContext dbContext;
        public ProductRepository(MongoDBContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public Product AddProduct(Product product)
        {
            dbContext.Products.InsertOne(product);
            return product;
        }
        public List<Product> GetProductById(int id)
        {
            return dbContext.Products.Find(x => x.ProductId == id).ToList();
        }
        public List<Product> GetProducts()
        {
            return dbContext.Products.Find(_ => true).ToList();        
        }
       
        public void UpdateProduct(int id, Product product)
        {
            var filter = Builders<Product>.Filter.Where(prod => prod.ProductId == id);
            var update = Builders<Product>.Update.Set(obj => obj.Name, product.Name).Set(obj => obj.Brand, product.Brand).Set(obj => obj.Quantity, product.Quantity).Set(obj => obj.Price, product.Price);
            dbContext.Products.UpdateOne(filter, update);
            //Console.WriteLine("updated Product successfully!!");
        }
        public bool DeleteProduct(int id)
        {
            var deletionResult=dbContext.Products.DeleteOne(x => x.ProductId == id);
            return deletionResult.IsAcknowledged && deletionResult.DeletedCount > 0;

        }

        public bool IsProductExists(Product product)
        {
            var productExists = dbContext.Products.Find(product => product.ProductId == product.ProductId);
            if(productExists!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsProductExistWithId(int id)
        {
            var productExist = dbContext.Products.Find(x => x.ProductId == id).FirstOrDefault();
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
