using DataAccess.Repository;
using Entity.Models;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        //private readonly Product product;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        void IProductService.AddProduct(Product product)
        {
            var prouctAvailabilityStatus = _productRepository.IsProductExist(product);
            if (!prouctAvailabilityStatus)
            {
                _productRepository.AddProduct(product);
            }
            else
            {
                throw new Exception("Product already Exist");
            }
        }

        void IProductService.DeleteProduct(Product product)
        {
            var prouctAvailabilityStatus = _productRepository.IsProductExist(product);
            if (prouctAvailabilityStatus)
            {
                _productRepository.DeleteProduct(product.ProductId);
            }
            else
            {
                throw new Exception("Product doesnot Exist");
            }
        }

        void IProductService.GetProducts(Product product)
        {
            var prouctAvailabilityStatus = _productRepository.IsProductExist(product);
            if (prouctAvailabilityStatus)
            {
                _productRepository.GetProducts();
            }
            else
            {
                throw new Exception("Empty repository");
            }
        }

        void IProductService.UpdateProduct(Product product)
        {
            var prouctAvailabilityStatus = _productRepository.IsProductExist(product);
            if (prouctAvailabilityStatus)
            {
                _productRepository.UpdateProduct(product.ProductId,product);
            }
            else
            {
                throw new Exception("Product dos not exist");
            }
        }
    }
}
