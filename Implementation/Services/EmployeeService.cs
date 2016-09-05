using System.Collections.Generic;
using Interfaces.Repositories;
using Interfaces.Services;
using Models.DomainModels;

namespace Implementation.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository employeeRepository { get; set; }

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }
    }
}