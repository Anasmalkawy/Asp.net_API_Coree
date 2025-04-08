using AngularApp1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MyDbContext _db;
        public ProductController(MyDbContext db)
        {
            _db = db;
        }




        [HttpGet("products")]
        public IActionResult GetAllProducts()
        {
            var products = _db.Products.ToList();
            return Ok(products);
        }




        [HttpGet("productsbyid")]
        public IActionResult GetProductById(int id)
        {
            var product = _db.Products.Find(id);
            return Ok(product);
        }



        [HttpGet("productsbyname")]
        public IActionResult GetProductByName(string name)
        {
            var product = _db.Products.FirstOrDefault(p => p.Name == name);
            return Ok(product);
        }



        [HttpGet("productsFirst")]
        public IActionResult GetFirstProduct()
        {
            var product = _db.Products.First();
            return Ok(product);
        }



    }
}
