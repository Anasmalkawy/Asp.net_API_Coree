using AngularApp1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly MyDbContext _db;
        public CategorieController(MyDbContext dbContext)
        {
            _db = dbContext;
        }

        [HttpGet("getallcategories")]
        public IActionResult getallcategories()
        {
            var users = _db.Categories.ToList();
            return Ok(users);
        }


        [HttpGet("getbyidcategories")]
        public IActionResult getcategories(int id)
        {
            var categories = _db.Categories.SingleOrDefault(x => x.Id == id);
            return Ok(categories);
        }


        [HttpGet("getbynamecategories")]
        public IActionResult getcategoriesbyname(string name)
        {
            var categories = _db.Categories.FirstOrDefault(x => x.Name == name);
            return Ok(categories);
        }


        [HttpGet("categoriesFirst")]
        public IActionResult categoriesFirst()
        {
            var categories = _db.Categories.First();
            return Ok(categories);
        }

    }
}
