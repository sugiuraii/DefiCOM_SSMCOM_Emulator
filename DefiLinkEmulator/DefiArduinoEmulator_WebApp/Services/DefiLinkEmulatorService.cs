using DefiArduinoEmulator_WebApp.Hubs;
using Microsoft.AspNetCore.SignalR;
using System;
using DefiLinkEmulator.Common;

namespace DefiArduinoEmulator_WebApp.Services
{
    public class DefiLinkEmulatorService
    {
        private readonly IHubContext<DefiLinkEmulatorHub> _hubContext;
        private readonly DefiComOUT _defiComOUT = new DefiComOUT();
        public DefiLinkEmulatorService(IHubContext<DefiLinkEmulatorHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public IHubContext<DefiLinkEmulatorHub> HubContext { get { return _hubContext;} }

        public DefiComOUT DefiComOUT{ get => _defiComOUT; }
    }
}