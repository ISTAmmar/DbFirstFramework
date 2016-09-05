using Implementation.Services;
using Interfaces.Services;
using Microsoft.Practices.Unity;

namespace Implementation
{
    public static class TypeRegistrations
    {
        public static void RegisterType(IUnityContainer unityContainer)
        {
            UnityConfig.UnityContainer = unityContainer;
            Repository.TypeRegistrations.RegisterType(unityContainer);
            unityContainer.RegisterType<IAspNetRoleService, AspNetRoleService>();
            unityContainer.RegisterType<IDashboardService, DashboardService>();
            unityContainer.RegisterType<IEmployeeService, EmployeeService>();
            unityContainer.RegisterType<IRolePermissionService, RolePermissionService>();
            unityContainer.RegisterType<ITaskService, TaskService>();
        }
    }
}
