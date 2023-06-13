namespace sample.DataAccessLayer
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        List<Employee> GetAllEmployees(int id);
        Employee AddEmployee(Employee employee);
        Employee DeleteEmployee(int id);
        void UpdateEmployee(Employee employee);
    }
}
