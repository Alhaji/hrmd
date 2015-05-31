using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hrmd.Startup))]
namespace hrmd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
