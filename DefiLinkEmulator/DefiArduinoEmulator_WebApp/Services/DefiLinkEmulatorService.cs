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
        public DefiLinkEmulatorService(IHubContext<DefiLinkEmulatorService> hubContext)
        {
            _hubContext = hubContext;
        }

        public DefiComOUT DefiComOUT{ get => _defiComOUT; }
    }
}