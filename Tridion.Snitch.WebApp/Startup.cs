using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tridion.Snitch.WebApp.Startup))]
namespace Tridion.Snitch.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
