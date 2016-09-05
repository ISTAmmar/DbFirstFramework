using Models.DomainModels;

namespace Interfaces.Repositories
{
    public interface IAspNetRoleRepository : IBaseRepository<AspNetRole, int>
    {
        bool CheckIfExist(AspNetRole role);
    }
}