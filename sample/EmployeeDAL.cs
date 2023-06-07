using sample;
using System.Collections.Generic;
namespace sample
{
    
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }

    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>
            {
              
                new Employee() { ID = 1, Name = "Pranaya", Department = "IT", IsActive = true },
                new Employee() { ID = 2, Name = "Kumar", Department = "HR", IsActive = true },
                new Employee() { ID = 3, Name = "Rout", Department = "Payroll", IsActive = false }
            };
            return ListEmployees;
        }
    }
}