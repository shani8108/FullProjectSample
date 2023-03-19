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
    public class DepartmentController : ControllerBase
    {
        public DepartmentEntities departmentEntities  { get; set; }
        public DepartmentController()
        {
            departmentEntities = new DepartmentEntities();
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public JsonResult Get()
        {
            List<Department> table = departmentEntities.GetAllDepartmentE();

            return new JsonResult(table);
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            List<Department> table = departmentEntities.GetDepartmentE(id);
            return new JsonResult(table);
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public JsonResult Post([FromBody] Department dep)
        {
            string res = departmentEntities.InsertDepartmentE(dep);
            return new JsonResult(res);
        }

        // PUT api/<DepartmentController>/5
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody] Department dep)
        {
            string res= departmentEntities.UpdateDepartmentE(id, dep);
            return new JsonResult(res);
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string res=departmentEntities.DeleteDepartmentE(id);
            return new JsonResult(res);
        }
    }
}
