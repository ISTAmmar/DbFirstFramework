using System.Collections.Generic;
using Interfaces.Services;
using Models.DomainModels;
using Repository.Repositories;

namespace Implementation.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeRepository employeeRepository { get; set; }

        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
        }

        public IEnumerable<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

        public string Get()
        {
            return "Employee Service";
        }
    }
}