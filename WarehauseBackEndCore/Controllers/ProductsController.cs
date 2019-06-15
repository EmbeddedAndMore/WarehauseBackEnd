using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WarehauseBackEndCore.Model;

namespace WarehauseBackEndCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class ProductsController : ControllerBase
    {

        List<Product> products = new List<Product>()
            {
                new Product(){id = 1 , name = "Product 1", ownerName = "Person 1" , entrDate = DateTime.Now},
                new Product(){id = 2 , name = "Product 2", ownerName = "Person 2" , entrDate = DateTime.Now},
                new Product(){id = 3 , name = "Product 3", ownerName = "Person 3" , entrDate = DateTime.Now},
                new Product(){id = 4 , name = "Product 4", ownerName = "Person 4" , entrDate = DateTime.Now},
                new Product(){id = 5 , name = "Product 5", ownerName = "Person 5" , entrDate = DateTime.Now},
            };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return new Product().GetAllProducts();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return products.FirstOrDefault(x=>x.id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            value.entrDate = DateTime.Now;
            new Product().AddProduct(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            new Product().RemoveProduct(id);
        }
    }
}
