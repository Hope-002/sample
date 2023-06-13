using Microsoft.AspNetCore.Mvc;
using sample.BusinessLayer;

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
            if (id != null)
            {
                var employees = _service.GetEmployees(id);
                return Ok(employees);
            }
            else
            {
                return BadRequest("ID not available");

            }

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

        [HttpPut("UpdateEmployee")]
      
        public ActionResult UpdateEmployee(int id, Employee employee)
        {
           
            if (id != employee.ID)
            {
                return BadRequest("Employee ID mismatch");
            }

            _service.UpdateEmployee(employee);
            return Ok();
        }
    }
   
}
