﻿using AngularApp1.Server.IDataService;
using AngularApp1.Server.Models;
using AngularApp1.Server.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly AngularApp1.Server.IDataService.IDataService _data;
        public CategorieController(AngularApp1.Server.IDataService.IDataService data)
        {
            _data = data;
        }

        [HttpGet("getallcategories")]
        public IActionResult getallcategories()
        {
            var users = _data.GetAllCategory();
            return Ok(users);
        }


        [HttpGet("getbyidcategories")]
        public IActionResult getcategories(int id)
        {
            var categories = _data.GetCategory(id);
            return Ok(categories);
        }


        [HttpGet("getbynamecategories")]
        public IActionResult getcategoriesbyname(string name)
        {
            var categories = _data.GetCategoryByName;
            return Ok(categories);
        }


        [HttpGet("categoriesFirst")]
        public IActionResult categoriesFirst()
        {
            var firstone = _data.GetCategoryFirst();
            return Ok(firstone);
        }

        [HttpDelete("deleteCategories/{id}")]
        public IActionResult delete(int id)
        {
            var deleteST = _data.deletecategories(id);
            if (deleteST == true)
            {
                return Ok(id);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("add")]
        public IActionResult AddCategory([FromBody] CategoryDTO dto)
        {
            if (dto == null)
                return BadRequest();
            _data.AddCategory(dto);
            return Ok();

        }

        [HttpPut("editVategories/{id}")]
        public IActionResult editcategoriesbyid(int id, [FromBody] CategoryDTO category)
        {
            if (category == null)
                return BadRequest();

            else
            {
                var userr = _data.editcategoriesbyid(id, category);
                if (userr == null)
                {
                    return BadRequest();

                }
                else
                {
                    return StatusCode(201, "added done");
                }
            }

        }


    }
}
