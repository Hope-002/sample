namespace sample.BusinessLayer
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        List<Employee> GetActiveEmployees();

        List<Employee> GetEmployees(int id);
    }
}
