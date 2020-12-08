using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        List<Product> GetProductById(int id);

        void UpdateProduct( int id, Product product);
        bool DeleteProduct(int id);
        Product AddProduct(Product product);
    }
}
