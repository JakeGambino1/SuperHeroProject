using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperHero.Startup))]
namespace SuperHero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
