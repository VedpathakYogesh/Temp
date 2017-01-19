using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Captcha.Startup))]
namespace Captcha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
