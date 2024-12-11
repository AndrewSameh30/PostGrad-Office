using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBproject.Startup))]
namespace DBproject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
