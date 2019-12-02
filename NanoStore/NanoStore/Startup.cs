using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NanoStore.Startup))]
namespace NanoStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
