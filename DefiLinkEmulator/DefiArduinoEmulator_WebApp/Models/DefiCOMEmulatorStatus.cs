using System;
using System.Collections.Generic;

namespace DefiArduinoEmulator_WebApp.Models
{
    public class DefiCOMEmulatorStatus
    {
        public Dictionary<string, int> DefiCOMParameter {get; set;} = new Dictionary<string, int>();

        public string COMPortName {get; set;}

        public bool IsRunning {get; set;}
    }
}