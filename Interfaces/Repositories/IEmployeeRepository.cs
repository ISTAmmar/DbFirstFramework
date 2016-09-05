using Models.DomainModels;

namespace Interfaces.Repositories
{
    public interface IEmployeeRepository : IBaseRepository<Employee, long>
    {
    }
}
