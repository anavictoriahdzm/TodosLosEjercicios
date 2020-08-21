using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model12.Models;

namespace Model12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<Product> _products = new List<Product>()
        {
            new Product(){ProductId = 0, ProductName = "Laptop", ProductPrice = "200"},
            new Product(){ProductId = 1, ProductName = "SmartPhone", ProductPrice = "100"}
        };

        /*public IEnumerable<Product> Get()
        {
            return _products;
            
        }*/
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(_products);
            //return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet("LoadWelcomeMessage")]
        public IActionResult GetWelcomeMessage()
        {
            return Ok("Welcome to our store...");
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            _products.Add(product);
            return StatusCode(StatusCodes.Status201Created);
        }
        /*public void Post([FromBody]Product product)
        {
            _products.Add(product);
        }*/

        [HttpPut("(id)")]
        public void Put(int id, [FromBody] Product product)
        {
            _products[id] = product;
        }

        [HttpDelete("{id}")]
        public void Detele(int id)
        {
            _products.RemoveAt(id);
        }
    }
}