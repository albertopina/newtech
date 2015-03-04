using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fabrikam.MVC.Startup))]
namespace Fabrikam.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
