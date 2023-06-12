﻿namespace sample.DataAccessLayer.Concrete
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
                new Employee() { ID = 3, Name = "Rout", Department = "Payroll", IsActive = true }
            };

        public List<Employee> GetAllEmployees()
        {

            return ListEmployees;
        }


        public Employee GetById(int id)
        {
            var ListEmployees = new List<Employee>();

            return ListEmployees.FirstOrDefault(e => e.ID == id);
        }



        public List<Employee> AddEmployee(Employee employee)
        {

            ListEmployees.Add(employee);

            return ListEmployees;
        }



        public List<Employee> DeleteEmployee(int id)
        {
            Employee employee = ListEmployees.FirstOrDefault(e => e.ID == id);
            if (employee != null)
            {
                ListEmployees.Remove(employee);
            }
            return ListEmployees;
        }



        public List<Employee> UpdateEmployee(Employee updatedEmployee)
        {
            Employee employee = ListEmployees.FirstOrDefault(e => e.ID == updatedEmployee.ID);
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
