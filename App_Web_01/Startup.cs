using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App_Web_01.Startup))]
namespace App_Web_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
