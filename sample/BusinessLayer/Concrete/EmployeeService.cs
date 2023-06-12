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

        public List<Employee> AddEmployee (Employee employee)
        {
            
            var rep = _repository.AddEmployee(employee);
           return rep;
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

    }
}
