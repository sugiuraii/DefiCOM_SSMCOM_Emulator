using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;


namespace DefiLinkEmulator
{
    namespace Common
    {
        public class DefiCOMOUTErrorEventArgs : EventArgs
        {
            public DefiCOMOUTErrorEventArgs(string s)
            {
                msg = s;
            }
            private string msg;
            public string Message
            {
                get { return msg; }
            }
        }

        public class DefiComOUT
        {
            private SerialPort serialPort1;
            private Int32 _portname;
            private Thread communicate_realtime_thread1;
            private bool _communicate_realtime_start;


            private Int32 _boost;
            private Int32 _tacho;
            private Int32 _oil_pres;
            private Int32 _fuel_pres;
            private Int32 _ext_temp;
            private Int32 _oil_temp;
            private Int32 _water_temp;

            const int DEFI_BAUD_RATE = 19200;
            //DefiLinkボーレート設定

            public event EventHandler<DefiCOMOUTErrorEventArgs> DefiCOMOUTErrorOccured;

            public DefiComOUT()
            {
                serialPort1 = new SerialPort();
                PortName = 1;
                serialPort1.BaudRate = DEFI_BAUD_RATE;
                serialPort1.Parity = Parity.Even;
                serialPort1.ReadTimeout = 500;
                serialPort1.StopBits = StopBits.One;
                serialPort1.DataBits = 8;

                _boost = 0;
                _tacho = 0;
                _oil_pres = 0;
                _fuel_pres = 0;
                _ext_temp = 0;
                _oil_pres = 0;
                _water_temp = 0;

                _communicate_realtime_start = false;
            }

            ~DefiComOUT()
            {
                communicate_realtime_stop();
            }

            public Int32 Boost
            {
                set
                {
                    _boost = value;
                }
            }

            public Int32 Tacho
            {
                set
                {
                    _tacho = value;
                }
            }

            public Int32 Oil_Pres
            {
                set
                {
                    _oil_pres = value;
                }
            }
            public Int32 Fuel_Pres
            {
                set
                {
                    _fuel_pres = value;
                }
            }
            public Int32 Ext_Temp
            {
                set
                {
                    _ext_temp = value;
                }
            }
            public Int32 Oil_Temp
            {
                set
                {
                    _oil_temp = value;
                }
            }
            public Int32 Water_Temp
            {
                set
                {
                    _water_temp = value;
                }
            }

            public Int32 PortName
            {
                get
                {
                    return _portname;
                }
                set
                {
                    try
                    {
                        _portname = value;
                        serialPort1.PortName = "COM" + _portname;
                    }
                    catch (System.InvalidOperationException ex)
                    {
                        DefiCOMOUTErrorOccured(this,new DefiCOMOUTErrorEventArgs("DefiCOMのエラー"));
                    }
                }
            }

            public void communicate_realtime_start()
            {
                communicate_realtime_thread1 = new Thread(new ThreadStart(communicate_realtime));
                _communicate_realtime_start = true;
                communicate_realtime_thread1.Start();
            }

            public void communicate_realtime_stop()
            {
                if (_communicate_realtime_start)
                {
                    //通信スレッドを終了させる(フラグをfalseに)
                    _communicate_realtime_start = false;

                    //通信スレッド終了まで待つ
                    communicate_realtime_thread1.Join();
                }
            }

            private void communicate_realtime()
            {
                //ポートオープン
                try
                {
                    serialPort1.Open();
                    //スレッドフラグがfalseにされるまで続ける
                    while (_communicate_realtime_start)
                    {
                        serialPort1.Write((char)0x01 + "1" + _boost.ToString("X3")
                            + (char)0x02 + "1" + _tacho.ToString("X3")
                            + (char)0x03 + "1" + _oil_pres.ToString("X3")
                            + (char)0x04 + "1" + _fuel_pres.ToString("X3")
                            + (char)0x05 + "1" + _ext_temp.ToString("X3")
                            + (char)0x07 + "1" + _oil_temp.ToString("X3")
                            + (char)0x0f + "1" + _water_temp.ToString("X3"));
                        Thread.Sleep(14);
                    }
                }
                catch (System.IO.IOException ex)
                {
                    DefiCOMOUTErrorOccured(this, new DefiCOMOUTErrorEventArgs("DefiCOMポートが開けません"));
                }
                catch (System.InvalidOperationException ex)
                {
                    DefiCOMOUTErrorOccured(this, new DefiCOMOUTErrorEventArgs("DefiCOMポートはすでに開かれています。"));
                }
                catch (System.UnauthorizedAccessException ex)
                {
                    DefiCOMOUTErrorOccured(this, new DefiCOMOUTErrorEventArgs("DefiCOMポートへのアクセスを拒否されました。"));
                }
                catch (System.TimeoutException ex)
                {
                    DefiCOMOUTErrorOccured(this, new DefiCOMOUTErrorEventArgs("TimeoutException"));
                }
                finally
                {
                    _communicate_realtime_start = false;

                    if (serialPort1.IsOpen)
                        serialPort1.Close();
                }
            }
        }
    }
}
