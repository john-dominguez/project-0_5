using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project0.Startup))]
namespace Project0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
