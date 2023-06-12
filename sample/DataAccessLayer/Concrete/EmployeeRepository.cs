namespace sample.DataAccessLayer.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {


       public static List<Employee> ListEmployees = new List<Employee>
            {

                new Employee() { ID = 1, Name = "Pranaya", Department = "IT", IsActive = true },
                new Employee() { ID = 2, Name = "Kumar", Department = "HR", IsActive = true },
                new Employee() { ID = 3, Name = "Rout", Department = "Payroll", IsActive = false }
            };

        public List<Employee> GetAllEmployees()
        {
            
            return ListEmployees;
        }

        public List<Employee> GetAllEmployees(int id)
        {
            return GetAllEmployees(id);
        }
    }
}
