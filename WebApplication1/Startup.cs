using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Earthdawn.Startup))]
namespace Earthdawn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
