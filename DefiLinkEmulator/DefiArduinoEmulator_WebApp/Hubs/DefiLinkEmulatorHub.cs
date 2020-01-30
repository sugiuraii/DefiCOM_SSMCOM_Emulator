using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using DefiArduinoEmulator_WebApp.Services;
using DefiArduinoEmulator_WebApp.Models;
using System;

namespace DefiArduinoEmulator_WebApp.Hubs
{
    public class DefiLinkEmulatorHub : Hub
    {
        private readonly DefiLinkEmulatorService _defilinkEmulatorService;

        public DefiLinkEmulatorHub(DefiLinkEmulatorService defiLinkEmulatorService) : base()
        {
            _defilinkEmulatorService = defiLinkEmulatorService;
        }

        public async Task StartDefiEmulator(string comPortName)
        {
            _defilinkEmulatorService.DefiComOUT.PortName = comPortName;
            _defilinkEmulatorService.DefiComOUT.COMOUTErrorOccured += async (obj, arg) =>
                await _defilinkEmulatorService.HubContext.Clients.All.SendAsync("emulatorStartStopped", comPortName, false, true, arg.Message);
            _defilinkEmulatorService.DefiComOUT.communicate_realtime_start();
            await Clients.All.SendAsync("emulatorStartStopped", comPortName, true, false, "");
        }

        public async Task GetEmulatorStatus()
        {
            var appStatus = new DefiCOMEmulatorStatus();
            var defiCOMOut = _defilinkEmulatorService.DefiComOUT;
            appStatus.COMPortName = defiCOMOut.PortName;
            appStatus.IsRunning = defiCOMOut.IsCommunicateRunning;
            appStatus.DefiCOMParameter.Add(DefiParameterCode.Coolant_Temperature.ToString(), defiCOMOut.Water_Temp);
            appStatus.DefiCOMParameter.Add(DefiParameterCode.Engine_Speed.ToString(), defiCOMOut.Tacho);
            appStatus.DefiCOMParameter.Add(DefiParameterCode.Exhaust_Gas_Temperature.ToString(), defiCOMOut.Ext_Temp);
            appStatus.DefiCOMParameter.Add(DefiParameterCode.Fuel_Rail_Pressure.ToString(), defiCOMOut.Fuel_Pres);
            appStatus.DefiCOMParameter.Add(DefiParameterCode.Manifold_Absolute_Pressure.ToString(), defiCOMOut.Boost);
            appStatus.DefiCOMParameter.Add(DefiParameterCode.Oil_Pressure.ToString(), defiCOMOut.Oil_Pres);
            appStatus.DefiCOMParameter.Add(DefiParameterCode.Oil_Temperature.ToString(), defiCOMOut.Oil_Temp);

            await Clients.Caller.SendAsync("appStatus", appStatus);
        }

        public async Task UpdateParameter(string code, string valStr)
        {
            var val = Int32.Parse(valStr);

            var defiCOMOut = _defilinkEmulatorService.DefiComOUT;            
            switch(code)
            {
                case "Manifold_Absolute_Pressure":
                    defiCOMOut.Boost = val;
                    await Clients.All.SendAsync("parameterUpdated", code, val);
                    break;
                case "Engine_Speed":
                    defiCOMOut.Tacho = val;
                    await Clients.All.SendAsync("parameterUpdated", code, val);
                    break;
                case "Oil_Pressure":
                    defiCOMOut.Oil_Pres = val;
                    await Clients.All.SendAsync("parameterUpdated", code, val);
                    break;
                case "Fuel_Rail_Pressure":
                    defiCOMOut.Fuel_Pres = val;
                    await Clients.All.SendAsync("parameterUpdated", code, val);
                    break;
                case "Exhaust_Gas_Temperature":
                    defiCOMOut.Ext_Temp = val;
                    await Clients.All.SendAsync("parameterUpdated", code, val);
                    break;
                case "Oil_Temperature":
                    defiCOMOut.Oil_Temp = val;
                    await Clients.All.SendAsync("parameterUpdated", code, val);
                    break;
                case "Coolant_Temperature":
                    defiCOMOut.Water_Temp = val;
                    await Clients.All.SendAsync("parameterUpdated", code, val);
                    break;
                default:
                    throw new ArgumentException("Parameter code does not match on parameterUpdated.");
            }
        }

        public async Task NewMessage(long username, string message)
        {
            await Clients.All.SendAsync("messageReceived", username, message);
        }
    }
}