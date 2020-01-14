using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using DefiArduinoEmulator_WebApp.Services;

namespace DefiArduinoEmulator_WebApp.Hubs
{
    public class DefiLinkEmulatorHub : Hub
    {
        private readonly DefiLinkEmulatorService _defilinkEmulatorService;

        public DefiLinkEmulatorHub(DefiLinkEmulatorService defiLinkEmulatorService) : base()
        {
            _defilinkEmulatorService = defiLinkEmulatorService;
        }
        public async Task NewMessage(long username, string message)
        {
            await Clients.All.SendAsync("messageReceived", username, message);
        }
    }
}