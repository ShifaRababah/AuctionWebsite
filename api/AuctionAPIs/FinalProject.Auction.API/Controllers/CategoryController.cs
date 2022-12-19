using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Auction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {

            categoryService = _categoryService;


            
        }
        [HttpGet]//Type of http method
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public List<Category> GetAllCategory()
        {
            return categoryService.GetAllCategory();
        }
        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateCategory(Category category)
        {

            return categoryService.UpdateCategory(category);

        }
        [HttpDelete]
        [Route("DeleteCategory{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteCategory(int id)
        {

            return categoryService.DeleteCategory(id);
        }
        [HttpPost]
        [Route("CreateCategory")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateCategory(Category category) {


            return categoryService.CreateCategory(category);
        
        }





    }
}