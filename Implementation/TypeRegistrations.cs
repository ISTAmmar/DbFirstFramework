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
            unityContainer.RegisterType<IEmployeeService, EmployeeService>();
        }
    }
}
