namespace DefiLinkEmulator
{
    partial class DefilinkEmulator_WinForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_Boost = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_Tacho = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar_OilPres = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar_FuelPres = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar_ExtTemp = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar_OilTemp = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar_WaterTemp = new System.Windows.Forms.TrackBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label_Boost = new System.Windows.Forms.Label();
            this.label_Tacho = new System.Windows.Forms.Label();
            this.label_OilPres = new System.Windows.Forms.Label();
            this.label_FuelPres = new System.Windows.Forms.Label();
            this.label_ExtTemp = new System.Windows.Forms.Label();
            this.label_OilTemp = new System.Windows.Forms.Label();
            this.label_WaterTemp = new System.Windows.Forms.Label();
            this.comboBox_COMPortSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Boost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Tacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_OilPres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_FuelPres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ExtTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_OilTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WaterTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMPort Name";
            // 
            // trackBar_Boost
            // 
            this.trackBar_Boost.Location = new System.Drawing.Point(73, 41);
            this.trackBar_Boost.Maximum = 2464;
            this.trackBar_Boost.Name = "trackBar_Boost";
            this.trackBar_Boost.Size = new System.Drawing.Size(302, 45);
            this.trackBar_Boost.TabIndex = 2;
            this.trackBar_Boost.TickFrequency = 200;
            this.trackBar_Boost.ValueChanged += new System.EventHandler(this.trackBar_Boost_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tacho";
            // 
            // trackBar_Tacho
            // 
            this.trackBar_Tacho.Location = new System.Drawing.Point(73, 79);
            this.trackBar_Tacho.Maximum = 2464;
            this.trackBar_Tacho.Name = "trackBar_Tacho";
            this.trackBar_Tacho.Size = new System.Drawing.Size(302, 45);
            this.trackBar_Tacho.TabIndex = 4;
            this.trackBar_Tacho.TickFrequency = 200;
            this.trackBar_Tacho.ValueChanged += new System.EventHandler(this.trackBar_Tacho_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oil_Pres";
            // 
            // trackBar_OilPres
            // 
            this.trackBar_OilPres.Location = new System.Drawing.Point(73, 115);
            this.trackBar_OilPres.Maximum = 2464;
            this.trackBar_OilPres.Name = "trackBar_OilPres";
            this.trackBar_OilPres.Size = new System.Drawing.Size(302, 45);
            this.trackBar_OilPres.TabIndex = 6;
            this.trackBar_OilPres.TickFrequency = 200;
            this.trackBar_OilPres.ValueChanged += new System.EventHandler(this.trackBar_OilPres_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fuel_Pres";
            // 
            // trackBar_FuelPres
            // 
            this.trackBar_FuelPres.Location = new System.Drawing.Point(73, 154);
            this.trackBar_FuelPres.Maximum = 2464;
            this.trackBar_FuelPres.Name = "trackBar_FuelPres";
            this.trackBar_FuelPres.Size = new System.Drawing.Size(302, 45);
            this.trackBar_FuelPres.TabIndex = 8;
            this.trackBar_FuelPres.TickFrequency = 200;
            this.trackBar_FuelPres.ValueChanged += new System.EventHandler(this.trackBar_FuelPres_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ext_Temp";
            // 
            // trackBar_ExtTemp
            // 
            this.trackBar_ExtTemp.Location = new System.Drawing.Point(73, 193);
            this.trackBar_ExtTemp.Maximum = 2464;
            this.trackBar_ExtTemp.Name = "trackBar_ExtTemp";
            this.trackBar_ExtTemp.Size = new System.Drawing.Size(302, 45);
            this.trackBar_ExtTemp.TabIndex = 10;
            this.trackBar_ExtTemp.TickFrequency = 200;
            this.trackBar_ExtTemp.ValueChanged += new System.EventHandler(this.trackBar_ExtTemp_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Oil_Temp";
            // 
            // trackBar_OilTemp
            // 
            this.trackBar_OilTemp.Location = new System.Drawing.Point(73, 232);
            this.trackBar_OilTemp.Maximum = 2464;
            this.trackBar_OilTemp.Name = "trackBar_OilTemp";
            this.trackBar_OilTemp.Size = new System.Drawing.Size(302, 45);
            this.trackBar_OilTemp.TabIndex = 12;
            this.trackBar_OilTemp.TickFrequency = 200;
            this.trackBar_OilTemp.ValueChanged += new System.EventHandler(this.trackBar_OilTemp_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "Water_Temp";
            // 
            // trackBar_WaterTemp
            // 
            this.trackBar_WaterTemp.Location = new System.Drawing.Point(73, 268);
            this.trackBar_WaterTemp.Maximum = 2464;
            this.trackBar_WaterTemp.Name = "trackBar_WaterTemp";
            this.trackBar_WaterTemp.Size = new System.Drawing.Size(302, 45);
            this.trackBar_WaterTemp.TabIndex = 14;
            this.trackBar_WaterTemp.TickFrequency = 200;
            this.trackBar_WaterTemp.ValueChanged += new System.EventHandler(this.trackBar_WaterTemp_ValueChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(261, 306);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 29);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label_Boost
            // 
            this.label_Boost.AutoSize = true;
            this.label_Boost.Location = new System.Drawing.Point(372, 42);
            this.label_Boost.Name = "label_Boost";
            this.label_Boost.Size = new System.Drawing.Size(11, 12);
            this.label_Boost.TabIndex = 17;
            this.label_Boost.Text = "0";
            // 
            // label_Tacho
            // 
            this.label_Tacho.AutoSize = true;
            this.label_Tacho.Location = new System.Drawing.Point(372, 79);
            this.label_Tacho.Name = "label_Tacho";
            this.label_Tacho.Size = new System.Drawing.Size(11, 12);
            this.label_Tacho.TabIndex = 18;
            this.label_Tacho.Text = "0";
            // 
            // label_OilPres
            // 
            this.label_OilPres.AutoSize = true;
            this.label_OilPres.Location = new System.Drawing.Point(372, 115);
            this.label_OilPres.Name = "label_OilPres";
            this.label_OilPres.Size = new System.Drawing.Size(11, 12);
            this.label_OilPres.TabIndex = 19;
            this.label_OilPres.Text = "0";
            // 
            // label_FuelPres
            // 
            this.label_FuelPres.AutoSize = true;
            this.label_FuelPres.Location = new System.Drawing.Point(372, 154);
            this.label_FuelPres.Name = "label_FuelPres";
            this.label_FuelPres.Size = new System.Drawing.Size(11, 12);
            this.label_FuelPres.TabIndex = 20;
            this.label_FuelPres.Text = "0";
            // 
            // label_ExtTemp
            // 
            this.label_ExtTemp.AutoSize = true;
            this.label_ExtTemp.Location = new System.Drawing.Point(372, 193);
            this.label_ExtTemp.Name = "label_ExtTemp";
            this.label_ExtTemp.Size = new System.Drawing.Size(11, 12);
            this.label_ExtTemp.TabIndex = 20;
            this.label_ExtTemp.Text = "0";
            // 
            // label_OilTemp
            // 
            this.label_OilTemp.AutoSize = true;
            this.label_OilTemp.Location = new System.Drawing.Point(372, 230);
            this.label_OilTemp.Name = "label_OilTemp";
            this.label_OilTemp.Size = new System.Drawing.Size(11, 12);
            this.label_OilTemp.TabIndex = 20;
            this.label_OilTemp.Text = "0";
            // 
            // label_WaterTemp
            // 
            this.label_WaterTemp.AutoSize = true;
            this.label_WaterTemp.Location = new System.Drawing.Point(372, 265);
            this.label_WaterTemp.Name = "label_WaterTemp";
            this.label_WaterTemp.Size = new System.Drawing.Size(11, 12);
            this.label_WaterTemp.TabIndex = 20;
            this.label_WaterTemp.Text = "0";
            // 
            // comboBox_COMPortSelect
            // 
            this.comboBox_COMPortSelect.FormattingEnabled = true;
            this.comboBox_COMPortSelect.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboBox_COMPortSelect.Location = new System.Drawing.Point(100, 12);
            this.comboBox_COMPortSelect.Name = "comboBox_COMPortSelect";
            this.comboBox_COMPortSelect.Size = new System.Drawing.Size(121, 20);
            this.comboBox_COMPortSelect.TabIndex = 22;
            this.comboBox_COMPortSelect.Text = "COM1";
            // 
            // DefilinkEmulator_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 331);
            this.Controls.Add(this.comboBox_COMPortSelect);
            this.Controls.Add(this.label_WaterTemp);
            this.Controls.Add(this.label_OilTemp);
            this.Controls.Add(this.label_ExtTemp);
            this.Controls.Add(this.label_FuelPres);
            this.Controls.Add(this.label_OilPres);
            this.Controls.Add(this.label_Tacho);
            this.Controls.Add(this.label_Boost);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar_WaterTemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar_OilTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar_ExtTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar_FuelPres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar_OilPres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar_Tacho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar_Boost);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 370);
            this.MinimumSize = new System.Drawing.Size(420, 370);
            this.Name = "DefilinkEmulator_WinForm";
            this.Text = "DefiLinkEmulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DefilinkEmulatorForm_FormClosed);
            this.Load += new System.EventHandler(this.DefilinkEmulatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Boost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Tacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_OilPres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_FuelPres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ExtTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_OilTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WaterTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_Boost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_Tacho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar_OilPres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar_FuelPres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_ExtTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar_OilTemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar_WaterTemp;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label_Boost;
        private System.Windows.Forms.Label label_Tacho;
        private System.Windows.Forms.Label label_OilPres;
        private System.Windows.Forms.Label label_FuelPres;
        private System.Windows.Forms.Label label_ExtTemp;
        private System.Windows.Forms.Label label_OilTemp;
        private System.Windows.Forms.Label label_WaterTemp;
        private System.Windows.Forms.ComboBox comboBox_COMPortSelect;
    }
}

