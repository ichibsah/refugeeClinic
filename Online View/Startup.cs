using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_View.Startup))]
namespace Online_View
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
