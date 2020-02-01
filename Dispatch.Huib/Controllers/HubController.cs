using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dispatch.Huib.Controllers
{
    public class HubController : ApiController
    {
        private readonly IHubContext _Context;
        

        private readonly IConnectionManager _ConnectionManager;
        public HubController()
        {
            _Context = GlobalHost.ConnectionManager.GetHubContext<DispatchMessageHub>();
            _ConnectionManager = GlobalHost.ConnectionManager;

        }
      

        //// GET: api/Hub/5
        public string Get(string user, string message)
        {
            //_Context.Clients.All.NewDispatch(user, message);            
            _Context.Clients.Client(user).NewDispatch(user, message);
            
            return message + " user= " + user;
        }














    }
}
