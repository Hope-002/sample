﻿using sample.DataAccessLayer;
using sample.DataAccessLayer.Concrete;

namespace sample.BusinessLayer.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository) 
        {
            _repository = repository;
        }
        public List<Employee> GetActiveEmployees()
        {
            var allEmployees = _repository.GetAllEmployees();
            var activeEmployees = allEmployees.Where(x => x.IsActive).ToList();
            return activeEmployees;
        }

        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
