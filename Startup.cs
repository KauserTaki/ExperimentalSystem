using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpSystem.Startup))]
namespace ExpSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
