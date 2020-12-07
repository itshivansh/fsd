using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Repository;
using Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductRepository productRepository;
        private readonly IProductService productService;

        public ProductController(IProductRepository _productRepository,IProductService _productService)
        {
            productRepository = _productRepository;
            productService = _productService;

        }
        [HttpGet]
        public IActionResult Get([FromBody] Product product)
        {
            productService.GetProducts(product);
            return Ok();
        }
 
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            productService.AddProduct(product);
            return Created("api/Building", 201);
        }
        [HttpPut]
        public IActionResult Put([FromBody] Product product)
        {
            productService.UpdateProduct(product);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] Product product)
        {
            productService.DeleteProduct(product);
            return Ok();
        }
    }
}
