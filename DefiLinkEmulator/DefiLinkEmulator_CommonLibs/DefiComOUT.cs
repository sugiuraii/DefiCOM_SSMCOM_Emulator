using System;
using System.Threading;
using System.IO.Ports;


namespace DefiLinkEmulator.Common
{        
    public class DefiComOUT : COMOUTCommon
    {
        //DefiLinkボーレート設定
        const int DEFI_BAUD_RATE = 19200;

        public DefiComOUT()
            : base(DEFI_BAUD_RATE, Parity.Even, 500, StopBits.One, 8)
        {           
        }

        public Int32 Boost { get; set; }
        public Int32 Tacho { get; set; }
        public Int32 Oil_Pres  { get; set; }
        public Int32 Fuel_Pres { get; set; }
        public Int32 Ext_Temp  { get; set; }
        public Int32 Oil_Temp  { get; set; }
        public Int32 Water_Temp  { get; set; }

        protected override void communicate_main()
        {
            serialWrite((char)0x01 + "1" + Boost.ToString("X3")
                       + (char)0x02 + "1" + Tacho.ToString("X3")
                       + (char)0x03 + "1" + Oil_Pres.ToString("X3")
                       + (char)0x04 + "1" + Fuel_Pres.ToString("X3")
                       + (char)0x05 + "1" + Ext_Temp.ToString("X3")
                       + (char)0x07 + "1" + Oil_Temp.ToString("X3")
                       + (char)0x0f + "1" + Water_Temp.ToString("X3"));
            Thread.Sleep(14);
        }
    }
}
