namespace SSMEmulator
{
    partial class SSMEmulatorForm
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
            this.trackBar_Speed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_CoolantTemp = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar_Throttle = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar_AF = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar_InjPulse = new System.Windows.Forms.TrackBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label_Speed = new System.Windows.Forms.Label();
            this.label_CoolantTemp = new System.Windows.Forms.Label();
            this.label_Throttle = new System.Windows.Forms.Label();
            this.label_AF = new System.Windows.Forms.Label();
            this.label_InjPulse = new System.Windows.Forms.Label();
            this.numericUpDown_Portname = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Neutral = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CoolantTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Throttle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_InjPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Portname)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMポート番号";
            // 
            // trackBar_Speed
            // 
            this.trackBar_Speed.Location = new System.Drawing.Point(73, 41);
            this.trackBar_Speed.Maximum = 254;
            this.trackBar_Speed.Name = "trackBar_Speed";
            this.trackBar_Speed.Size = new System.Drawing.Size(302, 45);
            this.trackBar_Speed.TabIndex = 2;
            this.trackBar_Speed.TickFrequency = 20;
            this.trackBar_Speed.ValueChanged += new System.EventHandler(this.trackBar_Speed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Water_Temp";
            // 
            // trackBar_CoolantTemp
            // 
            this.trackBar_CoolantTemp.Location = new System.Drawing.Point(73, 79);
            this.trackBar_CoolantTemp.Maximum = 254;
            this.trackBar_CoolantTemp.Name = "trackBar_CoolantTemp";
            this.trackBar_CoolantTemp.Size = new System.Drawing.Size(302, 45);
            this.trackBar_CoolantTemp.TabIndex = 4;
            this.trackBar_CoolantTemp.TickFrequency = 20;
            this.trackBar_CoolantTemp.ValueChanged += new System.EventHandler(this.trackBar_CoolantTemp_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Throttle";
            // 
            // trackBar_Throttle
            // 
            this.trackBar_Throttle.Location = new System.Drawing.Point(73, 115);
            this.trackBar_Throttle.Maximum = 254;
            this.trackBar_Throttle.Name = "trackBar_Throttle";
            this.trackBar_Throttle.Size = new System.Drawing.Size(302, 45);
            this.trackBar_Throttle.TabIndex = 6;
            this.trackBar_Throttle.TickFrequency = 20;
            this.trackBar_Throttle.ValueChanged += new System.EventHandler(this.trackBar_Throttle_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "AF";
            // 
            // trackBar_AF
            // 
            this.trackBar_AF.Location = new System.Drawing.Point(73, 154);
            this.trackBar_AF.Maximum = 254;
            this.trackBar_AF.Name = "trackBar_AF";
            this.trackBar_AF.Size = new System.Drawing.Size(302, 45);
            this.trackBar_AF.TabIndex = 8;
            this.trackBar_AF.TickFrequency = 20;
            this.trackBar_AF.ValueChanged += new System.EventHandler(this.trackBar_AF_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "InjPulse";
            // 
            // trackBar_InjPulse
            // 
            this.trackBar_InjPulse.Location = new System.Drawing.Point(73, 193);
            this.trackBar_InjPulse.Maximum = 254;
            this.trackBar_InjPulse.Name = "trackBar_InjPulse";
            this.trackBar_InjPulse.Size = new System.Drawing.Size(302, 45);
            this.trackBar_InjPulse.TabIndex = 10;
            this.trackBar_InjPulse.TickFrequency = 20;
            this.trackBar_InjPulse.ValueChanged += new System.EventHandler(this.trackBar_InjPulse_ValueChanged);
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
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.Location = new System.Drawing.Point(372, 42);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(11, 12);
            this.label_Speed.TabIndex = 17;
            this.label_Speed.Text = "0";
            // 
            // label_CoolantTemp
            // 
            this.label_CoolantTemp.AutoSize = true;
            this.label_CoolantTemp.Location = new System.Drawing.Point(372, 79);
            this.label_CoolantTemp.Name = "label_CoolantTemp";
            this.label_CoolantTemp.Size = new System.Drawing.Size(11, 12);
            this.label_CoolantTemp.TabIndex = 18;
            this.label_CoolantTemp.Text = "0";
            // 
            // label_Throttle
            // 
            this.label_Throttle.AutoSize = true;
            this.label_Throttle.Location = new System.Drawing.Point(372, 115);
            this.label_Throttle.Name = "label_Throttle";
            this.label_Throttle.Size = new System.Drawing.Size(11, 12);
            this.label_Throttle.TabIndex = 19;
            this.label_Throttle.Text = "0";
            // 
            // label_AF
            // 
            this.label_AF.AutoSize = true;
            this.label_AF.Location = new System.Drawing.Point(372, 154);
            this.label_AF.Name = "label_AF";
            this.label_AF.Size = new System.Drawing.Size(11, 12);
            this.label_AF.TabIndex = 20;
            this.label_AF.Text = "0";
            // 
            // label_InjPulse
            // 
            this.label_InjPulse.AutoSize = true;
            this.label_InjPulse.Location = new System.Drawing.Point(372, 193);
            this.label_InjPulse.Name = "label_InjPulse";
            this.label_InjPulse.Size = new System.Drawing.Size(11, 12);
            this.label_InjPulse.TabIndex = 20;
            this.label_InjPulse.Text = "0";
            // 
            // numericUpDown_Portname
            // 
            this.numericUpDown_Portname.Location = new System.Drawing.Point(108, 12);
            this.numericUpDown_Portname.Name = "numericUpDown_Portname";
            this.numericUpDown_Portname.Size = new System.Drawing.Size(92, 19);
            this.numericUpDown_Portname.TabIndex = 21;
            this.numericUpDown_Portname.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_Neutral
            // 
            this.checkBox_Neutral.AutoSize = true;
            this.checkBox_Neutral.Location = new System.Drawing.Point(12, 244);
            this.checkBox_Neutral.Name = "checkBox_Neutral";
            this.checkBox_Neutral.Size = new System.Drawing.Size(61, 16);
            this.checkBox_Neutral.TabIndex = 22;
            this.checkBox_Neutral.Text = "Neutral";
            this.checkBox_Neutral.UseVisualStyleBackColor = true;
            this.checkBox_Neutral.CheckedChanged += new System.EventHandler(this.checkBox_Neutral_CheckedChanged);
            // 
            // SSMEmulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 336);
            this.Controls.Add(this.checkBox_Neutral);
            this.Controls.Add(this.numericUpDown_Portname);
            this.Controls.Add(this.label_InjPulse);
            this.Controls.Add(this.label_AF);
            this.Controls.Add(this.label_Throttle);
            this.Controls.Add(this.label_CoolantTemp);
            this.Controls.Add(this.label_Speed);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar_InjPulse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar_AF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar_Throttle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar_CoolantTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar_Speed);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 370);
            this.MinimumSize = new System.Drawing.Size(420, 370);
            this.Name = "SSMEmulatorForm";
            this.Text = "SSMEmulator";
            this.Load += new System.EventHandler(this.DefilinkEmulatorForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DefilinkEmulatorForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_CoolantTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Throttle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_InjPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Portname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_Speed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_CoolantTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar_Throttle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar_AF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar_InjPulse;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.Label label_CoolantTemp;
        private System.Windows.Forms.Label label_Throttle;
        private System.Windows.Forms.Label label_AF;
        private System.Windows.Forms.Label label_InjPulse;
        private System.Windows.Forms.NumericUpDown numericUpDown_Portname;
        private System.Windows.Forms.CheckBox checkBox_Neutral;
    }
}

