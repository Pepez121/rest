using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProducts.Startup))]
namespace MVCProducts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
