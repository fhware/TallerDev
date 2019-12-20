using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TallerDev.Startup))]
namespace TallerDev
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
