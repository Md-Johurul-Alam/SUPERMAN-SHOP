using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SupermanShop.Startup))]
namespace SupermanShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
