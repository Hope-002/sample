namespace sample.BusinessLayer
{
    public interface IEmployeeService
    {
        List<Employee> GetActiveEmployees();
        Employee GetEmployeeById(int id);

        void DeleteEmployee(int id);

        List<Employee> AddEmployee(Employee employee);

        List<Employee> UpdateEmployee(int id,Employee employee);

   //     void AddEmployee(Employee employee);

    }
}
