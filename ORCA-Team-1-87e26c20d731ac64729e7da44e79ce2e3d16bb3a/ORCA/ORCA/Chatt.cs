using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.ComponentModel.DataAnnotations;

namespace ORCA
{
    public class Chatt : Hub
    {
        [Key]
        public int id { get; set; }
        public void SendMessage(string username, string message)
        // public void SendMessage()
        {
            
            string name = Context.User.Identity.Name;
            Clients.Group(name).addChatMessage(name, message);
            Clients.Group("2@1.com").addChatMessage(name, message);

        }
        public override Task OnConnected()
        {
            string name = Context.User.Identity.Name;
            Groups.Add(Context.ConnectionId, name);
            return base.OnConnected();
        }
        //public string username { get; set; }
        //public string messahe { get; set; }
    }



    //Clients.All.showMessage(username, message);

    //Clients.Caller.showMessage("system", "your message was sent at" + DateTime.Now.ToString("h:mm tt"));
}

