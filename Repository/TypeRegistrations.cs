using System.Data.Entity;
using Interfaces.Repositories;
using Microsoft.Practices.Unity;
using Repository.BaseRepository;
using Repository.Repositories;

namespace Repository
{
    public static class TypeRegistrations
    {
        public static void RegisterType(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<DbContext, BaseDbContext>(new PerRequestLifetimeManager());

            unityContainer.RegisterType<IAspNetRoleRepository, AspNetRoleRepository>();
            unityContainer.RegisterType<IRolePermissionRepository, RolePermissionRepository>();
            unityContainer.RegisterType<ITaskRepository, TaskRepository>();
        }
    }
}
