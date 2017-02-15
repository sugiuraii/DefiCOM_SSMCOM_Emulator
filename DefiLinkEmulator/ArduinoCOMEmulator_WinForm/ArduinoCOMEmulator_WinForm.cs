using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DefiLinkEmulator.Common;

namespace ArduinoCOMEmulator_WinForm
{
    public partial class ArduinoCOMEmulator_WinForm : Form
    {
        private ArduinoCOMOut arduinocomout1;
        private bool _communicate_start;
        public ArduinoCOMEmulator_WinForm()
        {
            InitializeComponent();
            arduinocomout1 = new ArduinoCOMOut();
            arduinocomout1.COMOUTErrorOccured += arduinocomout1_COMOUTErrorOccured;
            _communicate_start = false;
        }

        private void trackBar_Speed_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_Speed.Value;
            arduinocomout1.Speed = val;
            label_Speed.Text = val.ToString();
        }

        private void trackBar_Tacho_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_Tacho.Value;
            arduinocomout1.Tacho = val;
            label_Tacho.Text = val.ToString();
        }

        private void trackBar_Boost_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_Boost.Value;
            arduinocomout1.Boost = val;
            label_Boost.Text = val.ToString();
        }

        private void trackBar_WaterTemp_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_WaterTemp.Value;
            arduinocomout1.Water_Temp = val;
            label_WaterTemp.Text = val.ToString();
        }

        private void trackBar_OilTemp_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_OilTemp.Value;
            arduinocomout1.Oil_Temp = val;
            label_OilTemp.Text = val.ToString();
        }

        private void trackBar_OilTemp2_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_OilTemp2.Value;
            arduinocomout1.Oil_Temp2 = val;
            label_OilTemp2.Text = val.ToString();
        }

        private void trackBar_OilPres_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_OilPres.Value;
            arduinocomout1.Oil_Pres = val;
            label_OilPres.Text = val.ToString();
        }

        private void trackBar_FuelPres_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_FuelPres.Value;
            arduinocomout1.Fuel_Pres = val;
            label_FuelPres.Text = val.ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!_communicate_start)
            {
                arduinocomout1.PortName = comboBox_COMPortSelect.Text;
                arduinocomout1.communicate_realtime_start();
                _communicate_start = true;
                buttonStart.Text = "Stop";
            }
            else
            {
                buttonStart.Text = "Start";
                arduinocomout1.communicate_realtime_stop();
                _communicate_start = false;
            }
        }

        private void ArduinoCOMEmulator_WinForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            arduinocomout1.communicate_realtime_stop();
        }

        private void arduinocomout1_COMOUTErrorOccured(Object sender, COMOUTErrorEventArgs args)
        {
            // UIとは別スレッドからの実行のため、Invokeメソッドを使ってスレッドセーフにする(通信スレッドからUIスレッドに委譲)
            // コントロールを生成したスレッドの場合 InvokeRequired は false となります。
            if (this.InvokeRequired)
            {
                // コントロールを生成したスレッドに処理を委譲します。
                this.Invoke((MethodInvoker)delegate() { arduinocomout1_COMOUTErrorOccured(sender, args); });
                return;
            }

            ArduinoCOMOut senderobj = (ArduinoCOMOut)sender;
            MessageBox.Show(args.Message, "ArduinoCOMError", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            _communicate_start = false;
            buttonStart.Text = "Start";
        }

    }
}
