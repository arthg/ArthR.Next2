using Microsoft.AspNetCore.SignalR;

namespace ArthR.Next.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.InvokeAsync("Send", message);
        }
    }
}