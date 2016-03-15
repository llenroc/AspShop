using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspShop.Startup))]
namespace AspShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
