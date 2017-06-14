using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(API014.Startup))]
namespace API014
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
