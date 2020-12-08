using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataDAL.Repository;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {

            productService = _productService;

        }
        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(productService.GetProducts());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(productService.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            productService.AddProduct(product);
            return Created("api/Product", product);
        }
        [HttpPut]
        public IActionResult Put([FromBody] Product product)
        {
            productService.UpdateProduct(product.ProductId,product);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(productService.DeleteProduct(id));
        }
    }
}
