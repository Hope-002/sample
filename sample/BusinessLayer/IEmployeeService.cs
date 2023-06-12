namespace sample.BusinessLayer

{
    public interface IEmployeeService
    {
        List<Employee> GetActiveEmployees();
        Employee GetEmployeeById(int id);
        List<Employee> AddEmployee(Employee employee);
        List<Employee> DeleteEmployee(int id);
        List<Employee> UpdateEmployee(Employee updatedEmployee);


    }


}
