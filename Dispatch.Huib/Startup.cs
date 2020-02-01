using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http.Cors;

[assembly: OwinStartup(typeof(Dispatch.Huib.Startup))]
namespace Dispatch.Huib
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            var politica = new CorsPolicy();            
            politica.SupportsCredentials = true;
            politica.Origins.Add("https://localhost:44354");
            politica.AllowAnyMethod = true;
            politica.Methods.Add("GET");
            politica.Methods.Add("POST");
            politica.Methods.Add("OPTIONS");
            var corsOptions = new CorsOptions
            {
                PolicyProvider = new CorsPolicyProvider
                {
                    PolicyResolver = context => Task.FromResult(politica)
                }
            };
            app.UseCors(corsOptions);

            
            app.MapSignalR("/signalr", new HubConfiguration());
            

        }

    }
}