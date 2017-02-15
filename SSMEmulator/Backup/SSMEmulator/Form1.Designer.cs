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
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDown_Portname = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Numeric = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Unit = new System.Windows.Forms.Label();
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_RawValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_switch = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_switch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Portname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(279, 291);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 29);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
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
            // comboBox_Numeric
            // 
            this.comboBox_Numeric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Numeric.FormattingEnabled = true;
            this.comboBox_Numeric.Location = new System.Drawing.Point(69, 18);
            this.comboBox_Numeric.Name = "comboBox_Numeric";
            this.comboBox_Numeric.Size = new System.Drawing.Size(293, 20);
            this.comboBox_Numeric.TabIndex = 22;
            this.comboBox_Numeric.SelectedIndexChanged += new System.EventHandler(this.comboBox_Numeric_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 32;
            this.trackBar1.Location = new System.Drawing.Point(7, 44);
            this.trackBar1.Maximum = 256;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(372, 45);
            this.trackBar1.TabIndex = 23;
            this.trackBar1.TickFrequency = 32;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Unit);
            this.groupBox1.Controls.Add(this.textBox_Value);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_RawValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.comboBox_Numeric);
            this.groupBox1.Location = new System.Drawing.Point(7, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 105);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numeric";
            // 
            // label_Unit
            // 
            this.label_Unit.AutoSize = true;
            this.label_Unit.Location = new System.Drawing.Point(328, 82);
            this.label_Unit.Name = "label_Unit";
            this.label_Unit.Size = new System.Drawing.Size(26, 12);
            this.label_Unit.TabIndex = 29;
            this.label_Unit.Text = "Unit";
            // 
            // textBox_Value
            // 
            this.textBox_Value.Location = new System.Drawing.Point(229, 79);
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.Size = new System.Drawing.Size(94, 19);
            this.textBox_Value.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "Value";
            // 
            // textBox_RawValue
            // 
            this.textBox_RawValue.Location = new System.Drawing.Point(80, 79);
            this.textBox_RawValue.Name = "textBox_RawValue";
            this.textBox_RawValue.Size = new System.Drawing.Size(94, 19);
            this.textBox_RawValue.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "Raw Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "Parameter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_switch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_switch);
            this.groupBox2.Location = new System.Drawing.Point(9, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 81);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switch";
            // 
            // checkBox_switch
            // 
            this.checkBox_switch.AutoSize = true;
            this.checkBox_switch.Location = new System.Drawing.Point(67, 53);
            this.checkBox_switch.Name = "checkBox_switch";
            this.checkBox_switch.Size = new System.Drawing.Size(15, 14);
            this.checkBox_switch.TabIndex = 32;
            this.checkBox_switch.UseVisualStyleBackColor = true;
            this.checkBox_switch.CheckedChanged += new System.EventHandler(this.checkBox_switch_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "Switch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "Parameter";
            // 
            // comboBox_switch
            // 
            this.comboBox_switch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_switch.FormattingEnabled = true;
            this.comboBox_switch.Location = new System.Drawing.Point(67, 18);
            this.comboBox_switch.Name = "comboBox_switch";
            this.comboBox_switch.Size = new System.Drawing.Size(293, 20);
            this.comboBox_switch.TabIndex = 30;
            this.comboBox_switch.SelectedIndexChanged += new System.EventHandler(this.comboBox_switch_SelectedIndexChanged);
            // 
            // SSMEmulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 332);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numericUpDown_Portname);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 370);
            this.MinimumSize = new System.Drawing.Size(420, 370);
            this.Name = "SSMEmulatorForm";
            this.Text = "SSMEmulator";
            this.Load += new System.EventHandler(this.SSMEmulatorForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DefilinkEmulatorForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Portname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDown_Portname;
        private System.Windows.Forms.ComboBox comboBox_Numeric;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Unit;
        private System.Windows.Forms.TextBox textBox_Value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_RawValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_switch;
        private System.Windows.Forms.CheckBox checkBox_switch;
    }
}

