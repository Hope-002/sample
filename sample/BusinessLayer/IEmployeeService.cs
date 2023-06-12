namespace sample.BusinessLayer
{
    public interface IEmployeeService
    {
        List<Employee> GetActiveEmployees();
        List<Employee>AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        void DeleteEmployee(int id);
    }
}
