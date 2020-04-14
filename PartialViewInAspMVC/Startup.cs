using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartialViewInAspMVC.Startup))]
namespace PartialViewInAspMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
