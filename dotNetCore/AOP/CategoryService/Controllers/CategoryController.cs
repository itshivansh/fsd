using System;
using Microsoft.AspNetCore.Mvc;
using CategoryService.Service;
using CategoryService.Models;
using CategoryService.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using CategoryService.Utilities;

namespace CategoryService.API.Controllers
{
    //[Authorize]
    //[ExceptionHandler]

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService service;

        public CategoryController(ICategoryService _service)
        {
            this.service = _service;
        }

        /// <summary>
        /// Get Category details by Id.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{categoryId:int}")]
        public IActionResult Get(int categoryId)
        {
            
                return Ok(service.GetCategoryById(categoryId));
            
        }

        /// <summary>
        /// Get all the categories created by a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public IActionResult Get(string userId)
        {
           
                return Ok(service.GetAllCategoriesByUserId(userId));
        }

        /// <summary>
        /// Create a new Category.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]Category value)
        {
                return Created("", service.CreateCategory(value));
            
        }

        /// <summary>
        /// Update the existing category.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Category value)
        {
            
                var updateResult = service.UpdateCategory(id, value);
                if (updateResult == true)
                    return Ok(updateResult);
                else
                    return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong. Unable to update the category");
           
        }

        /// <summary>
        /// Delete the Category.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
                return Ok(service.DeleteCategory(id));
        }
    }
}
