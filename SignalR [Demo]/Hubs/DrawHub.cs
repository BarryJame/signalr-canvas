using System;
using System.Drawing;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRChat
{
    [HubName("drawHub")]
    public class DrawHub : Hub
    {
        public void Move(int prevX, int prevY, int currX, int currY)
        {
            Clients.Others.executeCommand(prevX, prevY, currX, currY);
        }
    }
}