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
    }
}
