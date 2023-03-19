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
        public ProductEntities productEntities { get; set; }
        public ProductController()
        {
            productEntities= new ProductEntities();
        }
        [HttpGet]
        public JsonResult Get()
        {
            List<ProductView> table = productEntities.GetAllProductE();
            return new JsonResult(table);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            List<ProductView> table = productEntities.GetProductE(id);
            return new JsonResult(table);
        }

        // POST api/<ProductController>
        [HttpPost]
        public JsonResult Post([FromBody] Product prod)
        {
            string res= productEntities.InsertProductE(prod);
            return new JsonResult(res);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody] Product prod)
        {
            string res= productEntities.UpdateProductE(id, prod);
            return new JsonResult(res);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string res=productEntities.DeleteProductE(id);
            return new JsonResult(res);
        }
    }
}
