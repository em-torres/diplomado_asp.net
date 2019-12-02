using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(authorize.Startup))]
namespace authorize
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
