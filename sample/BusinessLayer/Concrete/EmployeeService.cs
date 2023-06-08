using sample.DataAccessLayer;
using sample.DataAccessLayer.Concrete;

namespace sample.BusinessLayer.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository) 
        {
            _repository = repository;
        }
        
        public List<Employee> GetAll()
        {
            var allEmployees = _repository.GetAllEmployees();
            return allEmployees;
        }
        public List<Employee> GetActiveEmployees()
        {
            var activeEmployees = GetAll().Where(x => x.IsActive).ToList();
            return activeEmployees;
        }
        public List<Employee> GetEmployees(int id)
        {
            var employeeId = GetAll().Where(x => x.ID == id);
            List<Employee> employees = employeeId.ToList();
            return employees;
        }
    }
}
