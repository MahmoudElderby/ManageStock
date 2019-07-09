using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ManageStock
{
    public class AppHub : Hub
    {
        static List<UserDetail> ConnectedUsers = new List<UserDetail>();

        public void Hello()
        {
            Clients.All.hello();
        }
        public void send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
        public void GetPrices()
        {
           var ret= Clients.All.Get();
        }

        public void TakeData(dynamic data)
        {
            Clients.All.UpdatePrices(data);
        }

        public override Task OnConnected()
        {
           

            return base.OnConnected();
        }

    }
}