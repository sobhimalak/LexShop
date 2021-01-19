using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Photogenix.WebUi.Startup))]
namespace Photogenix.WebUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
