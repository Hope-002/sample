namespace sample.DataAccessLayer
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetById(int id);

        void DeleteEmployee(int id);

        List<Employee> AddEmployee(Employee employee);

       List<Employee> UpdateEmployee(int id,Employee employee);
       // void AddEmployee(Employee employee);
    }
}
