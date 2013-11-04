using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IHOWebApplication.Startup))]
namespace IHOWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
