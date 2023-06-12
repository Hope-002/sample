namespace sample.DataAccessLayer
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetById(int id);
        List<Employee> AddEmployee(Employee employee);
        List<Employee> DeleteEmployee(int id);

        List<Employee> UpdateEmployee(Employee updatedEmployee);

    }
}
