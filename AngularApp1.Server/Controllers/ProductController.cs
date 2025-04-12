using AngularApp1.Server.IDataService;
using AngularApp1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AngularApp1.Server.IDataService.IDataService _data;
        public ProductController(AngularApp1.Server.IDataService.IDataService db)
        {
            _data = db;
        }




        [HttpGet("products")]
        public IActionResult GetAllProducts()
        {
            var products = _data.GetAllProducts();
            return Ok(products);
        }




        [HttpGet("productsbyid")]
        public IActionResult GetProductById(int id)
        {
            var product = _data.GetProductById(id);
            return Ok(product);
        }



        [HttpGet("productsbyname")]
        public IActionResult GetProductByName(string name)
        {
            var product = _data.GetProductByName(name);
            return Ok(product);
        }



        [HttpGet("productsFirst")]
        public IActionResult GetFirstProduct()
        {
            var product = _data.GetFirstProduct();
            return Ok(product);
        }


        [HttpDelete("delete")]
        public IActionResult DeleteProduct(int id) {
            var data = _data.DeleteProduct(id);
            if (data == true)
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
