namespace sample.DataAccessLayer
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetById(int id);
    }
}
