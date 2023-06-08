namespace sample.DataAccessLayer
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();

        List<Employee> GetAllEmployees(int id);
    }
}
