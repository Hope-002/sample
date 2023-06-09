namespace sample.BusinessLayer
{
    public interface IEmployeeService
    {
        List<Employee> GetActiveEmployees();
        Employee GetEmployeeById(int id);
    }
    
}
