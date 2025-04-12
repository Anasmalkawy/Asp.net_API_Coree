using AngularApp1.Server.IDataService;
using AngularApp1.Server.Models;
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

        [HttpDelete("deleteCategories")]
        public IActionResult delete(int id)
        {
            var deleteST = _data.deletecategories(id);
            if (deleteST == true)
            {
                return Ok("delete done");
            }
            else
            {
                return NotFound("delete failed");
            }
        }


    }
}
