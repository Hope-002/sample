namespace sample.DataAccessLayer
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
    }
}
