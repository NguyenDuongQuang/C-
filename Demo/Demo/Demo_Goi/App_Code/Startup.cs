using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_Goi.Startup))]
namespace Demo_Goi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
