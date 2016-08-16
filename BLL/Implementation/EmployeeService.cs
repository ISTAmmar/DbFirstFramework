using System.Collections.Generic;
using DAL.Repositories;
using Interfaces.Services;
using Models.DomainModels;

namespace BLL.Implementation
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