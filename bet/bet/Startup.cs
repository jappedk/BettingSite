using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bet.Startup))]
namespace bet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
