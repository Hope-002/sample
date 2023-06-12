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

        public List<Employee> GetActiveEmployees()
        {
            var allEmployees = _repository.GetAllEmployees();
            var activeEmployees = allEmployees.Where(x => x.IsActive).ToList();
            return activeEmployees;
        }
        public Employee GetEmployeeById(int id)
        {
            var allEmployees = _repository.GetAllEmployees();
            return allEmployees.FirstOrDefault(e => e.ID == id);
        }
        public List<Employee> AddEmployee(Employee employee)
        {

            var rep = _repository.AddEmployee(employee);
            return rep;
        }
        public List<Employee> DeleteEmployee(int id)
        {
          
            return _repository.DeleteEmployee(id);
        }
        public List<Employee> UpdateEmployee(Employee updatedEmployee)
        {
            return _repository.UpdateEmployee(updatedEmployee);
        }
    }
}
