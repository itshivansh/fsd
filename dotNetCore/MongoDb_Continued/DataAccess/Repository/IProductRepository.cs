using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public void GetProducts();
        public void AddProduct(Product product);
        public void DeleteProduct(int id);
        public void UpdateProduct(int id,Product product);
        public bool IsProductExist(Product product);
    }
}
