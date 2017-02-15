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
    }


    public class SSMComOUT
    {
        private SerialPort serialPort1;
        private Int32 _portname;
        private Thread communicate_realtime_thread1;
        private bool _communicate_realtime_start;

        private SSM_Content_Table _content_table;

        //SSM baudrate
        private const int SSM_BAUD_RATE = 4800;

        public SSMComOUT()
        {
            serialPort1 = new SerialPort();
            PortName = 1;
            serialPort1.BaudRate = SSM_BAUD_RATE;
            serialPort1.ReadTimeout = 500;

            _content_table = new SSM_Content_Table();

            _communicate_realtime_start = false;
        }

        ~SSMComOUT()
        {
            communicate_realtime_stop();
        }

        public int get_Numeric_bytelength(SSM_Parameter_Code code)
        {
            return _content_table[code].Address_Length;
        }

        public double get_Coefficent(SSM_Parameter_Code code)
        {
            return _content_table[code].Conversion_Coefficient;
        }

        public double get_Offset(SSM_Parameter_Code code)
        {
            return _content_table[code].Conversion_Offset;
        }

        public string get_Unit(SSM_Parameter_Code code)
        {
            return _content_table[code].Unit;
        }

        public int get_raw_value(SSM_Parameter_Code code)
        {
            return _content_table[code].Raw_Value;
        }

        public double get_value(SSM_Parameter_Code code)
        {
            return _content_table[code].Value;
        }

        public void set_value(SSM_Parameter_Code code, int val)
        {
            _content_table[code].Raw_Value = val;
        }

        
        public void set_switch(SSM_Switch_Code code, bool val)
        {
            _content_table[code].Value = val;
        }

        public bool get_switch(SSM_Switch_Code code)
        {
            return _content_table[code].Value;
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
                catch (System.InvalidOperationException ex1)
                {
                    MessageBox.Show(ex1.Message, "SSMCOMのエラー");
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

        private byte[] read_ssm_packet()
        {
            byte singlebyte_buf;

            do
            {
                singlebyte_buf = (byte)serialPort1.ReadByte();
            }while (singlebyte_buf != 0x80);

            byte[] inbuf = new byte[4];
            inbuf[0] = 0x80;
            inbuf[1] = (byte)serialPort1.ReadByte(); // Dest byte (shuould be 0x10 (ECU))
            inbuf[2] = (byte)serialPort1.ReadByte(); // Source byte (should be 0xF0)(DIGTOOL)
            inbuf[3] = (byte)serialPort1.ReadByte(); // Size byte

            int data_length = (int)inbuf[3];
            int i;

            List<byte> data_content = new List<byte>();
            for (i = 0; i < data_length; i++)
            {
                data_content.Add((byte)serialPort1.ReadByte());
            }

            //read checksum byte
            data_content.Add((byte)serialPort1.ReadByte());

            inbuf = inbuf.Concat(data_content.ToArray()).ToArray();

            return inbuf;
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
                    if(serialPort1.BytesToRead == 0)
                    {
                        Thread.Sleep(10);
                        continue;
                    }

                    byte[] inbuf = read_ssm_packet();

                    byte[] outbuf = new byte[] { };
                    byte[] outbuf_header = new byte[] { 0x80, 0xf0, 0x10 };
                    byte[] outbuf_length = new byte[1];
                    byte[] outbuf_content = new byte[1] {0xE8};
                    byte[] outbuf_checksum = new byte[1];

                    int i = 0;
                    int j,k;

                    if ((inbuf[0] != 0x80) || (inbuf[1] != 0x10) || (inbuf[2] != 0xF0) || (inbuf[4] != 0xA8))
                        continue;

                    //データ長読み取り
                    int data_length = (int)inbuf[3];

                    //Queryアドレス数計算(Command Padding byte除いたデータ長/3 (アドレス長3バイト)
                    int num_addresses = (data_length - 2) / 3;

                    for (i = 0; i < num_addresses; i++)
                    {
                        j = 6 + 3 * i;
                        byte[] address = new byte[3];
                        address[0] = inbuf[j];
                        address[1] = inbuf[j+1];
                        address[2] = inbuf[j+2];

                        foreach (SSM_Parameter_Code code in Enum.GetValues(typeof(SSM_Parameter_Code)))
                        {
                            if (_content_table[code].Read_Address.Length == 3)
                            {
                                if (address.SequenceEqual(_content_table[code].Read_Address))
                                {
                                    byte[] new_data = new byte[1];
                                    new_data[0] = (byte)_content_table[code].Raw_Value;
                                    outbuf_content = outbuf_content.Concat(new_data).ToArray();
                                    break;
                                }
                            }
                            else if (_content_table[code].Read_Address.Length == 6)
                            {
                                //MSB処理
                                byte[] content_address_msb = new byte[3];
                                content_address_msb[0] = _content_table[code].Read_Address[0];
                                content_address_msb[1] = _content_table[code].Read_Address[1];
                                content_address_msb[2] = _content_table[code].Read_Address[2];
                                if (address.SequenceEqual(content_address_msb))
                                {
                                    byte[] new_data = new byte[1];
                                    new_data[0] = (byte)((_content_table[code].Raw_Value & 0xFF00) >> 8);
                                    outbuf_content = outbuf_content.Concat(new_data).ToArray();
                                    break;
                                }
                                //LSB処理
                                byte[] content_address_lsb = new byte[3];
                                content_address_lsb[0] = _content_table[code].Read_Address[3];
                                content_address_lsb[1] = _content_table[code].Read_Address[4];
                                content_address_lsb[2] = _content_table[code].Read_Address[5];
                                if (address.SequenceEqual(content_address_lsb))
                                {
                                    byte[] new_data = new byte[1];
                                    new_data[0] = (byte)((_content_table[code].Raw_Value) & (0x00FF));
                                    outbuf_content = outbuf_content.Concat(new_data).ToArray();
                                    break;
                                }
                            }
                            else
                            {
                                throw new InvalidOperationException("Content Tableのアドレス長が不正です");
                            }
                        }
                    }
                    outbuf_length[0] = (byte)outbuf_content.Length;

                    //連結
                    outbuf = outbuf.Concat(outbuf_header).ToArray();
                    outbuf = outbuf.Concat(outbuf_length).ToArray();
                    outbuf = outbuf.Concat(outbuf_content).ToArray();

                    //チェックサム計算
                    int outbuf_sum = 0;
                    for (k = 0; k < outbuf.Length; k++)
                    {
                        outbuf_sum = outbuf_sum + (int)outbuf[k];
                    }

                    outbuf_checksum[0] = (byte)(outbuf_sum & 0xFF);

                    outbuf = outbuf.Concat(outbuf_checksum).ToArray();

                    //出力配列書き込み
                    serialPort1.Write(inbuf, 0, inbuf.Length);//エコーバック
                    serialPort1.Write(outbuf, 0, outbuf.Length);
                }
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("SSMCOMポートが開けません");
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("SSMCOMポートはすでに開かれています。");
            }
            catch (System.UnauthorizedAccessException ex)
            {
                MessageBox.Show("SSMCOMポートへのアクセスを拒否されました。");
            }
            catch (System.TimeoutException ex)
            {
                MessageBox.Show("TimeoutException");
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
