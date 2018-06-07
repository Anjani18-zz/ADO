using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;
using AdoEmployee.Models;

namespace AdoEmployee.Controllers
{
    [Route("api/[controller]")]
    public class employeeController : ApiController
    {

        // GET: api/employee
        [System.Web.Http.HttpGet]
        public IEnumerable<Employee> Get()
        {
            // return new string[] { "value1", "value2" };
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            return employeeDataAccessLayer.GetAllEmployees();
            
           
        }

        // GET: api/employee/5
       //[HttpGet("{id}")]
      /*  public string Get(int id)
        {
            return result;
        }*/
        // POST: api/employee
       [System.Web.Http.HttpPost]
        public void Post([FromBody]Employee employee)
        {
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            employeeDataAccessLayer.AddEmployee(employee);
        }

        // PUT: api/employee/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Employee employee)
        {
            EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
            employeeDataAccessLayer.UpdateEmployee(employee);
            return Ok;
        }

        // DELETE: api/employee/5
        [System.Web.Http.HttpDelete()]
        public ActionResult Delete(int id)
        {
          EmployeeDataAccessLayer employeeDataAccessLayer = new EmployeeDataAccessLayer();
          employeeDataAccessLayer.DeleteEmployee(id);
          return Ok();
        }
    }
}
