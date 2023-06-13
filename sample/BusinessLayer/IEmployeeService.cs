using sample.Model;

namespace sample.BusinessLayer
{
    public interface IEmployeeService
    {
        List<Employee> GetActiveEmployees();
        List<Employee> GetAll();
        List<Employee> GetEmployees(int id);
        Employee CreateEmployee(Employee employee);
        Employee DeleteEmployee(int id);
    }
}
