using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Log4Net_dash.Startup))]
namespace Log4Net_dash
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
