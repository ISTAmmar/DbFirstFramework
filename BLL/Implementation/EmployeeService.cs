using System.Collections.Generic;
using DAL.Repositories;
using Models.DomainModels;

namespace BLL.Implementation
{
    public class EmployeeService
    {
        public EmployeeRepository employeeRepository { get; set; }

        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
        }

        public IEnumerable<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }
    }
}
