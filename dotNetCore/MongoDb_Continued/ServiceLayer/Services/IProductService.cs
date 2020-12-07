using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services
{
    public interface IProductService
    {
        public void GetProducts(Product product);
        public void AddProduct(Product product);
        public void DeleteProduct(Product product);
        public void UpdateProduct(Product product);
    }
}
