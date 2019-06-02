using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrakeTest.WebUI.Startup))]
namespace DrakeTest.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
