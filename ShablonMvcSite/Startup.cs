using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShablonMvcSite.Startup))]
namespace ShablonMvcSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
