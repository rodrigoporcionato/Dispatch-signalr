using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;


namespace Dispatch.Huib
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {            
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        //protected void Application_PreSendRequestHeaders()
        //{
        //    this.Context.Response.Headers.Add("Access-Control-Allow-Headers", "*");
        //    this.Context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        //}
    }
}