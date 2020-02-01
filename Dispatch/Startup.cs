using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dispatch.Startup))]
namespace Dispatch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            ConfigureAuth(app);
        }
    }
}
