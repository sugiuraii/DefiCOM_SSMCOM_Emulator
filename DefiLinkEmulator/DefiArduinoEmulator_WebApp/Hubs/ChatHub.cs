using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace DefiArduinoEmulator_WebApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task NewMessage(long username, string message)
        {
            await Clients.All.SendAsync("messageReceived", username, message);
        }
    }
}