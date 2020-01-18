using System;
using DefiArduinoEmulator_WebApp.Services;
using DefiArduinoEmulator_WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DefiArduinoEmulator_WebApp.Controllers
{
    public class DefiEmulatorController : Controller
    {
        private readonly DefiLinkEmulatorService _defilinkEmulatorService;

        public DefiEmulatorController(DefiLinkEmulatorService defiLinkEmulatorService) : base()
        {
            _defilinkEmulatorService = defiLinkEmulatorService;
        }

        public ActionResult  EmulatorStatus()
        {
            DefiCOMEmulatorStatus appStatus = new DefiCOMEmulatorStatus();
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
            return Json(appStatus);
        }
    }
}