
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDAL.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProductById(int id);
        List<Product> GetProducts();
       
        void UpdateProduct(int id, Product product);
        bool DeleteProduct(int id);
        Product AddProduct(Product product);
        bool IsProductExists(Product product);
        public bool IsProductExistWithId(int id);
        
    }
}
