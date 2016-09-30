using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PissServer.Startup))]
namespace PissServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
