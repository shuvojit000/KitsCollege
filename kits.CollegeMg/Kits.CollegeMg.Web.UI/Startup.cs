using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kits.CollegeMg.Web.UI.Startup))]
namespace Kits.CollegeMg.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
