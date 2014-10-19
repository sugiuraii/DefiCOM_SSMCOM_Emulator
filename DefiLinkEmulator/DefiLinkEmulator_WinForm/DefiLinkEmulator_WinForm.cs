using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DefiLinkEmulator.Common;

namespace DefiLinkEmulator
{
    public partial class DefilinkEmulator_WinForm : Form
    {
        private DefiComOUT deficomout1;

        bool _communicate_start;

        public DefilinkEmulator_WinForm()
        {
            InitializeComponent();
            deficomout1 = new DefiComOUT();
            deficomout1.DefiCOMOUTErrorOccured += deficomout1_DefiCOMOUTErrorOccured;
            _communicate_start = false;
        }
        ~DefilinkEmulator_WinForm()
        {

        }

        private void DefilinkEmulatorForm_Load(object sender, EventArgs e)
        {

        }

        private void trackBar_Boost_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_Boost.Value;
            deficomout1.Boost = val;
            label_Boost.Text = val.ToString();
        }

        private void trackBar_Tacho_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_Tacho.Value;
            deficomout1.Tacho = val;
            label_Tacho.Text = val.ToString();
        }

        private void trackBar_OilPres_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_OilPres.Value;
            deficomout1.Oil_Pres = val;
            label_OilPres.Text = val.ToString();
        }

        private void trackBar_FuelPres_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_FuelPres.Value;
            deficomout1.Fuel_Pres = val;
            label_FuelPres.Text = val.ToString();
        }

        private void trackBar_ExtTemp_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_ExtTemp.Value;
            deficomout1.Ext_Temp = val;
            label_ExtTemp.Text = val.ToString();
        }

        private void trackBar_OilTemp_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_OilTemp.Value;
            deficomout1.Oil_Temp = val;
            label_OilTemp.Text = val.ToString();
        }

        private void trackBar_WaterTemp_ValueChanged(object sender, EventArgs e)
        {
            Int32 val = trackBar_WaterTemp.Value;
            deficomout1.Water_Temp = val;
            label_WaterTemp.Text = val.ToString();
 
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!_communicate_start)
            {
                deficomout1.PortName = (int)numericUpDown_Portname.Value;
                deficomout1.communicate_realtime_start();
                _communicate_start = true;
                buttonStart.Text = "Stop";
            }
            else
            {
                buttonStart.Text = "Start";
                deficomout1.communicate_realtime_stop();
                _communicate_start = false;
            }
        }

        private void DefilinkEmulatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            deficomout1.communicate_realtime_stop();
        }

        

        private void deficomout1_DefiCOMOUTErrorOccured(Object sender, DefiCOMOUTErrorEventArgs args)
        {
            // UIとは別スレッドからの実行のため、Invokeメソッドを使ってスレッドセーフにする(通信スレッドからUIスレッドに委譲)
            // コントロールを生成したスレッドの場合 InvokeRequired は false となります。
            if (this.InvokeRequired)
            {
                // コントロールを生成したスレッドに処理を委譲します。
                this.Invoke((MethodInvoker)delegate() { deficomout1_DefiCOMOUTErrorOccured(sender, args); });
                return;
            }

            DefiComOUT senderobj = (DefiComOUT)sender;
            MessageBox.Show(args.Message, "DefiCOMError", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            _communicate_start = false;
            buttonStart.Text = "Start";
        }


    }



}
