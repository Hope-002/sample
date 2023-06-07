namespace sample.DataAccessLayer.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeRepository()
        {
        }

        public List<Employee> GetAllEmployees()
        {
            var ListEmployees = new List<Employee>
            {

                new Employee() { ID = 1, Name = "Pranaya", Department = "IT", IsActive = true },
                new Employee() { ID = 2, Name = "Kumar", Department = "HR", IsActive = true },
                new Employee() { ID = 3, Name = "Rout", Department = "Payroll", IsActive = false }
            };
            return ListEmployees;
        }
    }
}
