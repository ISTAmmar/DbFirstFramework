using Models.DomainModels;

namespace Sigma.ModelMapper
{
    public static class RoleMapper
    {
        public static Models.AspNetRole CreateFromServerToClient(this AspNetRole source)
        {
            return new Models.AspNetRole
            {
                Id = source.Id,
                Name = source.Name
            };
        }
    }
}