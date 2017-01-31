using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Log4netToDb.Startup))]
namespace Log4netToDb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
