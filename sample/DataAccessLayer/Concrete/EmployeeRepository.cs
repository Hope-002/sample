using System.Security.Cryptography.X509Certificates;

namespace sample.DataAccessLayer.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
       
        public EmployeeRepository()
        {
        }
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
        public Employee GetById(int id)
        {
             
            return ListEmployees.FirstOrDefault(e => e.ID == id);
        }
        public void DeleteEmployee(int id)
        {
           

            var employee = GetById(id);
            if (employee != null)
                ListEmployees.Remove(employee);
        }

     

        public List<Employee> AddEmployee(Employee employee)
        {
            ListEmployees.Add(employee);  
            return ListEmployees;
        }

        public List<Employee> UpdateEmployee(int id, Employee updatedEmployee)
        {
            var employee = GetById(id);
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Department = updatedEmployee.Department;
                employee.IsActive = updatedEmployee.IsActive;
            }
            return ListEmployees;
        }


    }
}
