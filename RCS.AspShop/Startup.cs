using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RCS.AspShop.Startup))]
namespace RCS.AspShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
