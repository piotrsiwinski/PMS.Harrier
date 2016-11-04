using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PMS.Harrier.Startup))]
namespace PMS.Harrier
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
