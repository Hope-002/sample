namespace sample.DataAccessLayer
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        List<Employee> AddEmployee(Employee employee);
        Employee GetById(int id);
        void DeleteEmployee(int id);


    }
}
