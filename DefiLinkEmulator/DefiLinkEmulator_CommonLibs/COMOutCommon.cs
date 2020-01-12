using System;
using System.Threading;
using System.IO.Ports;

namespace DefiLinkEmulator.Common
{
    public class COMOUTErrorEventArgs : EventArgs
    {
        public COMOUTErrorEventArgs(string s)
        {
            msg = s;
        }
        private string msg;
        public string Message
        {
            get { return msg; }
        }
    }

    public abstract class COMOUTCommon
    {
        private SerialPort serialPort1;
        private Thread communicate_realtime_thread1;
        private bool _communicate_realtime_start;
        
        private CommunicationThreadEndStatus communicationThreadEndStatus;
        public event EventHandler<COMOUTErrorEventArgs> COMOUTErrorOccured;

        public bool IsCommunicateRunning
        {
            get
            {   
                return _communicate_realtime_start;
            }
        }

        public CommunicationThreadEndStatus WaitCommunicationThreadEnd()
        {
            while(_communicate_realtime_start)
                Thread.Sleep(100);

            return communicationThreadEndStatus;
        }

        public COMOUTCommon(int baudrate, Parity parity, int readTimeout, StopBits stopBits, int dataBits)
        {
            serialPort1 = new SerialPort();
            PortName = "COM1";
            serialPort1.BaudRate = baudrate;
            serialPort1.Parity = parity;
            serialPort1.ReadTimeout = readTimeout;
            serialPort1.StopBits = stopBits;
            serialPort1.DataBits = dataBits;

            _communicate_realtime_start = false;
        }
        
        ~COMOUTCommon()
        {
            communicate_realtime_stop();
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

        protected void serialWrite(string text)
        {
            serialPort1.Write(text);
        }
        protected void serialWriteLine(string text)
        {
            serialPort1.WriteLine(text);
        }

        protected abstract void communicate_main();

        private void communicate_realtime()
        {
            //ポートオープン
            try
            {
                serialPort1.Open();
                //スレッドフラグがfalseにされるまで続ける
                while (_communicate_realtime_start)
                {
                    communicate_main();
                }
                communicationThreadEndStatus = new CommunicationThreadEndStatus(false, null);
            }
            catch (Exception ex)
            {
                communicationThreadEndStatus = new CommunicationThreadEndStatus(true, ex);
                COMOUTErrorOccured(this, new COMOUTErrorEventArgs(ex.Message));
            }
            finally
            {
                _communicate_realtime_start = false;

                if (serialPort1.IsOpen)
                    serialPort1.Close();
            }
        }

        public String PortName
        {
            get
            {
                return serialPort1.PortName;
            }
            set
            {
                try
                {
                    serialPort1.PortName = value;
                }
                catch (System.InvalidOperationException ex)
                {
                    COMOUTErrorOccured(this, new COMOUTErrorEventArgs(ex.Message));
                }
            }
        }
    }
}
