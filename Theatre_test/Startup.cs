using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Theatre_test.Startup))]
namespace Theatre_test
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
