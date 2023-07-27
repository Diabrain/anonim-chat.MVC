using Microsoft.AspNetCore.SignalR;

namespace anonim_chat.MVC.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string User,string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", User, message);
        }
    }
}
