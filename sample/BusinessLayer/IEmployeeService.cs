namespace sample.BusinessLayer
{
    public interface IEmployeeService
    {
        void AddEmployee(Employee employee);
        List<Employee> GetActiveEmployees();
    }
}
