using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ORCA.Startup))]
namespace ORCA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
