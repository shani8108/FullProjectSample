using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDAL;
using ProjectEntities;
using ProjectModel;
using System.Data;

namespace ProjectUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public JsonResult Get()
        {
            DataTable table = ProductEntities.GetAllProductE();
            return new JsonResult(table);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            DataTable table = ProductEntities.GetProductE(id);
            return new JsonResult(table);
        }

        // POST api/<ProductController>
        [HttpPost]
        public JsonResult Post([FromBody] Product prod)
        {
            string res= ProductEntities.InsertProductE(prod);
            return new JsonResult(res);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody] Product prod)
        {
            string res= ProductEntities.UpdateProductE(id, prod);
            return new JsonResult(res);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string res=ProductEntities.DeleteProductE(id);
            return new JsonResult(res);
        }
    }
}
