using System.Collections.Generic;
using Models.DomainModels;

namespace Interfaces.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
    }
}