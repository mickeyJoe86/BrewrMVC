using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrewrMVC.Startup))]
namespace BrewrMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
