using sample.DataAccessLayer;

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
            var allEmployees = _repository.GetAllEmployees();
            var activeEmployees = allEmployees.Where(x => x.IsActive).ToList();
            return activeEmployees;
        }
        public List<Employee> GetEmployees(int id)
        {
            var employeeId = GetAll().Where(x => x.ID == id);
            List<Employee> employees = employeeId.ToList();
            return employees;
        }
        public Employee CreateEmployee(Employee employee)
        {
            var result = _repository.AddEmployee(employee);
            return result;
        }

        public Employee DeleteEmployee(int id) 
        {
            var result = _repository.DeleteEmployee(id);
            return result;
        }

        public void UpdateEmployee(Employee employee)
        {
           _repository.UpdateEmployee(employee);
          
        }

    }
}
