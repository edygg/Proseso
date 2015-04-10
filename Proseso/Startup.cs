using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proseso.Startup))]
namespace Proseso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
