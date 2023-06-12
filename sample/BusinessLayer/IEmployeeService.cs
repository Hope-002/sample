namespace sample.BusinessLayer
{
    public interface IEmployeeService
    {
        List<Employee> GetActiveEmployees();
        void AddEmployee(Employee employee);
    }
}
