using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(netcoreapp.Startup))]
namespace netcoreapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
