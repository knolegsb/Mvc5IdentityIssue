using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5IdentityIssue.Startup))]
namespace Mvc5IdentityIssue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
