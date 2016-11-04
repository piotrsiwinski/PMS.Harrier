using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PMS.Harrier.WebUI.Startup))]
namespace PMS.Harrier.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
