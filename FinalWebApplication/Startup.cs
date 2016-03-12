using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalWebApplication.Startup))]
namespace FinalWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
