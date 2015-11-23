using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bet3.Startup))]
namespace bet3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
