using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnotherSuperHeroProject.Startup))]
namespace AnotherSuperHeroProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
