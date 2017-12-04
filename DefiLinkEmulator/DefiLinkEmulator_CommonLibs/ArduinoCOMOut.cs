using System;
using System.Threading;
using System.IO.Ports;

namespace DefiLinkEmulator.Common
{
    public class ArduinoCOMOut : COMOUTCommon
    {
        //Arduinoボーレート設定
        public const int ARDUINO_BAUD_RATE = 38400;

        public ArduinoCOMOut()
            : base(ARDUINO_BAUD_RATE, Parity.None, 500, StopBits.One, 8)
        {           
        }

        public Int32 Tacho { get; set; }
        public Int32 Speed { get; set; }

        public Int32 Boost { get; set; }
        public Int32 Water_Temp { get; set; }
        public Int32 Oil_Temp { get; set; }
        public Int32 Oil_Temp2 { get; set; }
        public Int32 Oil_Pres { get; set; }
        public Int32 Fuel_Pres { get; set; }

        protected override void communicate_main()
        {
            serialWriteLine("T" + Tacho.ToString());
            serialWriteLine("S" + Speed.ToString());
            serialWriteLine("A" + Boost.ToString());
            serialWriteLine("B" + Water_Temp.ToString());
            serialWriteLine("C" + Oil_Temp.ToString());
            serialWriteLine("D" + Oil_Temp2.ToString());
            serialWriteLine("E" + Oil_Pres.ToString());
            serialWriteLine("F" + Fuel_Pres.ToString());
            Thread.Sleep(14);
        }
    }
}
