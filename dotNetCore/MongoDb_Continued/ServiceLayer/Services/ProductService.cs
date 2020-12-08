using DataDAL.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
            //var productAvailabilityStatus = _productRepository.IsProductExists(product);
            //if(!productAvailabilityStatus)
            //{
            //    _productRepository.AddProduct(product);
            //}
            //else
            //{
            //    throw new Exception("Product Exist");
            //}
        }

        public List<Product> GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }
        public bool DeleteProduct(int id)
        {
           return  _productRepository.DeleteProduct(id);
            //var productAvailabilityStatus = _productRepository.IsProductExistWithId(id);
            //if (productAvailabilityStatus)
            //{
            //    _productRepository.DeleteProduct(id);
            //}
            //else
            //{
            //    throw new Exception("Product doesnot Exist");
            //}
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }


        public void UpdateProduct(int id, Product product)
        {
            var productAvailabilityStatus = _productRepository.IsProductExistWithId(id);
            if (productAvailabilityStatus)
            {
                _productRepository.UpdateProduct(id,product);
            }
            else
            {
                throw new Exception("Product not found");
            }
        }
    }
}
