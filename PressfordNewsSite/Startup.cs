using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PressfordNewsSite.Startup))]
namespace PressfordNewsSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
