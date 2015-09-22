using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StayCalm.Startup))]
namespace StayCalm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
