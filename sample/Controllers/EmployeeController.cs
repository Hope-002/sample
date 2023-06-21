using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sample.BusinessLayer;
using sample.BusinessLayer.Concrete;

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

        [HttpGet("getEmployees")]
        public ActionResult GetEmployees() 
        {
            var employees = _service.GetActiveEmployees();
            return Ok(employees);
        }


        [HttpGet("getEmployee/{id}")]
        public ActionResult GetEmployee(int id)
        {
            var employee = _service.GetEmployeeById(id);
            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpDelete("deleteEmployee/{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            _service.DeleteEmployee(id);
            return Ok();
        }

        [HttpPost("addEmployee")]
        public ActionResult AddEmployee([FromBody] Employee employee)
        {
            _service.AddEmployee(employee);
            return Ok(employee);
        }

        [HttpPut("updateEmployee/{id}")]
        public ActionResult UpdateEmployee(int id, [FromBody] Employee employee)
        {
            var existingEmployee = _service.GetEmployeeById(id);
            if (existingEmployee == null)
                return NotFound();

            existingEmployee.Name = employee.Name;
            existingEmployee.Department = employee.Department;
            existingEmployee.IsActive = employee.IsActive;

            return Ok(existingEmployee);
        }
    }
}
