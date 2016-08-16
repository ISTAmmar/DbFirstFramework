using System.Data.Entity;
using Microsoft.Practices.Unity;
using Repository.BaseRepository;

namespace Repository
{
    public static class TypeRegistrations
    {
        public static void RegisterType(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<DbContext, BaseDbContext>(new PerRequestLifetimeManager());
            // unityContainer.RegisterType<IHelpRepository, HelpRepository>();
        }
    }
}
