using Sample;

namespace sample.DataAccessLayer.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public List<Employee> GetAllEmployees(int id)
        {
            return GetAllEmployees(id);
        }

        public Employee AddEmployee(Employee employee)
        {
            var addEmployee = new Employee()
            {
                ID = employee.ID,
                Name = employee.Name,
                Department = employee.Department,
                IsActive = employee.IsActive
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return addEmployee;
        }

       public Employee DeleteEmployee(int id) 
       {
            var employeeId = _context.Employees.Find(id);
            if (employeeId != null)
            {
                _context.Employees.Remove(employeeId);
                _context.SaveChanges();
            }
            return employeeId;
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }
    }
}
