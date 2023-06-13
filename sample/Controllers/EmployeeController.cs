using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sample.BusinessLayer;
using sample.BusinessLayer.Concrete;
using sample.DataAccessLayer;
using sample.Model;


namespace sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _service;
        public EmployeeController(IEmployeeService service) 
        {
            _service = service;
        }


        [HttpGet("getAllEmployees")]
        public ActionResult GetAllEmployees()
        {
            var employees = _service.GetAll();
            return Ok(employees);
        }

        [HttpGet("getActiveEmployees")]
        public ActionResult GetEmployees() 
        {
            var employees = _service.GetActiveEmployees();
            return Ok(employees);
        }

        [HttpGet("getEmployeesById")]
        public ActionResult GetEmployees(int id)
        {
            var employees = _service.GetEmployees(id);
            return Ok(employees);
        }

        [HttpPost("AddEmployee")]
        public ActionResult AddEmployee(Employee employee)
        {
            _service.CreateEmployee(employee);
            return Ok(employee);
        }

        [HttpDelete("deleteEmployeeById")]
        public ActionResult DeleteEmployee(int id)        
        {
            var employees = _service.DeleteEmployee(id);
            return Ok(employees);
        }

    }
}
