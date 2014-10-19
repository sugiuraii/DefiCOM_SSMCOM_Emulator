using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using DefiSubaruMonitor.Communication.SSM;

using SSMEmulator.Common;

namespace SSMEmulator
{
    public partial class SSMEmulatorForm : Form
    {
        private SSMComOUT ssmcomout1;


        bool _communicate_start;

        public SSMEmulatorForm()
        {
            InitializeComponent();
            ssmcomout1 = new SSMComOUT();
            ssmcomout1.SSMCOMOUTErrorOccured += ssmcomout1_SSMCOMOUTErrorOccured;
            _communicate_start = false;

        }
        ~SSMEmulatorForm()
        {

        }

        private void SSMEmulatorForm_Load(object sender, EventArgs e)
        {
            parameter_selectbox_initialize(comboBox_Numeric);
            swicth_selectbox_initialize(comboBox_switch);
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!_communicate_start)
            {
                buttonStart.Text = "Stop";
                ssmcomout1.PortName = (int)numericUpDown_Portname.Value;
                ssmcomout1.communicate_realtime_start();
                _communicate_start = true;
            }
            else
            {
                buttonStart.Text = "Start";
                ssmcomout1.communicate_realtime_stop();
                _communicate_start = false;
            }
        }

        private void DefilinkEmulatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ssmcomout1.communicate_realtime_stop();
        }

        private void parameter_selectbox_initialize(ComboBox targetbox)
        {
            targetbox.Items.AddRange(Enum.GetNames(typeof(SSM_Parameter_Code)));
            targetbox.SelectedIndex = 0;
        }

        private void swicth_selectbox_initialize(ComboBox targetbox)
        {
            targetbox.Items.AddRange(Enum.GetNames(typeof(SSM_Switch_Code)));
            targetbox.SelectedIndex = 0;
        }

        private void comboBox_Numeric_SelectedIndexChanged(object sender, EventArgs e)
        {
            SSM_Parameter_Code target_param_code; 
            try
            {
                target_param_code = (SSM_Parameter_Code)Enum.Parse(typeof(SSM_Parameter_Code), comboBox_Numeric.SelectedItem.ToString());
            }
            catch (ArgumentException ex)
            {
                return;
            }

            trackBar1.Minimum = 0;
            trackBar1.Maximum = (int)Math.Pow(2, (ssmcomout1.get_Numeric_bytelength(target_param_code) / 3 * 8));
            trackBar1.TickFrequency = (trackBar1.Maximum - trackBar1.Minimum) / 8;
            trackBar1.Value = ssmcomout1.get_raw_value(target_param_code);
            textBox_RawValue.Text = trackBar1.Value.ToString();
            textBox_Value.Text = ssmcomout1.get_value(target_param_code).ToString();
            label_Unit.Text = ssmcomout1.get_Unit(target_param_code);
        }

        private void comboBox_switch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SSM_Switch_Code target_switch_code;
            try
            {
                target_switch_code = (SSM_Switch_Code)Enum.Parse(typeof(SSM_Switch_Code), comboBox_switch.SelectedItem.ToString());
            }
            catch (ArgumentException ex)
            {
                return;
            }
            checkBox_switch.Checked = ssmcomout1.get_switch(target_switch_code);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            SSM_Parameter_Code target_param_code = (SSM_Parameter_Code)Enum.Parse(typeof(SSM_Parameter_Code), comboBox_Numeric.SelectedItem.ToString());
            ssmcomout1.set_value(target_param_code, trackBar1.Value);
            textBox_RawValue.Text = ssmcomout1.get_raw_value(target_param_code).ToString();
            textBox_Value.Text = ssmcomout1.get_value(target_param_code).ToString();           
        }

        private void checkBox_switch_CheckedChanged(object sender, EventArgs e)
        {
            SSM_Switch_Code target_switch_code = (SSM_Switch_Code)Enum.Parse(typeof(SSM_Switch_Code), comboBox_switch.SelectedItem.ToString());
            ssmcomout1.set_switch(target_switch_code, checkBox_switch.Checked);
        }

        private void ssmcomout1_SSMCOMOUTErrorOccured(Object sender, SSMCOMErrorEventArgs args)
        {
            // UIとは別スレッドからの実行のため、Invokeメソッドを使ってスレッドセーフにする(通信スレッドからUIスレッドに委譲)
            // コントロールを生成したスレッドの場合 InvokeRequired は false となります。
            if (this.InvokeRequired)
            {
                // コントロールを生成したスレッドに処理を委譲します。
                this.Invoke((MethodInvoker)delegate() { ssmcomout1_SSMCOMOUTErrorOccured(sender, args); });
                return;
            }

            SSMComOUT senderobj = (SSMComOUT)sender;
            MessageBox.Show(args.Message, "SSMCOMError", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            _communicate_start = false;
            buttonStart.Text = "Start";
        }

    }




}
