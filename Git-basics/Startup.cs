using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git_basics.Startup))]
namespace Git_basics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
