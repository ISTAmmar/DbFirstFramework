using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sigma.Startup))]
namespace Sigma
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
