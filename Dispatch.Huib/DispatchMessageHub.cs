using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Dispatch.Huib
{
    [HubName("NotificationHub")]
    public class DispatchMessageHub : Hub
    {
        private static IHubConnectionContext<dynamic> GetClients(DispatchMessageHub chatHub)
        {
            if (chatHub == null)
                return GlobalHost.ConnectionManager.GetHubContext<DispatchMessageHub>().Clients;
            else
                return chatHub.Clients;
        }

        //public void Send(string userId)
        //{
        //    var message = $"Send message to you with user id {userId}";
        //    Clients.Client(userId).SendAsync("ReceiveMessage", message);
        //}

        public override Task OnConnected()
        {
            string userName = Context.Request.QueryString["userName"];
            Groups.Add(Context.ConnectionId, userName);

            return base.OnConnected();
        }



    }
}