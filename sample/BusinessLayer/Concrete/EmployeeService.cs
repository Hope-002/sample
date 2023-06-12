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

        public void DeleteEmployee(int id)
        {
            _repository.DeleteEmployee(id);
        }

        /*   public void AddEmployee(Employee employee)
           {
               _repository.AddEmployee(employee);
           }*/

        public List<Employee> AddEmployee(Employee employee)
        {
            var list =  _repository.AddEmployee(employee);
            return list;
        }

        public List<Employee> UpdateEmployee(int id, Employee updatedEmployee)
        {
            return _repository.UpdateEmployee(id, updatedEmployee);
        }
    }
}