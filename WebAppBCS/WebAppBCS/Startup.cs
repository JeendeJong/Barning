using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppBCS.Startup))]
namespace WebAppBCS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
