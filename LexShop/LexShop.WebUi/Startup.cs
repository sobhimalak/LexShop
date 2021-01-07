using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LexShop.WebUi.Startup))]
namespace LexShop.WebUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
