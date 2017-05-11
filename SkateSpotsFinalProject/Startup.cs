using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkateSpotsFinalProject.Startup))]
namespace SkateSpotsFinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
