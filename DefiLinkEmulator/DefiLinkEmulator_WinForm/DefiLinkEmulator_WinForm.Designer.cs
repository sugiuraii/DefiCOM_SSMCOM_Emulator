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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefilinkEmulator_WinForm));
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Boost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Tacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_OilPres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_FuelPres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ExtTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_OilTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WaterTemp)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMPort Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_Boost
            // 
            this.trackBar_Boost.Location = new System.Drawing.Point(74, 3);
            this.trackBar_Boost.Maximum = 2464;
            this.trackBar_Boost.Name = "trackBar_Boost";
            this.trackBar_Boost.Size = new System.Drawing.Size(266, 28);
            this.trackBar_Boost.TabIndex = 2;
            this.trackBar_Boost.TickFrequency = 200;
            this.trackBar_Boost.ValueChanged += new System.EventHandler(this.trackBar_Boost_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boost";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tacho";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_Tacho
            // 
            this.trackBar_Tacho.Location = new System.Drawing.Point(74, 3);
            this.trackBar_Tacho.Maximum = 2464;
            this.trackBar_Tacho.Name = "trackBar_Tacho";
            this.trackBar_Tacho.Size = new System.Drawing.Size(266, 28);
            this.trackBar_Tacho.TabIndex = 4;
            this.trackBar_Tacho.TickFrequency = 200;
            this.trackBar_Tacho.ValueChanged += new System.EventHandler(this.trackBar_Tacho_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oil_Pres";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_OilPres
            // 
            this.trackBar_OilPres.Location = new System.Drawing.Point(74, 3);
            this.trackBar_OilPres.Maximum = 2464;
            this.trackBar_OilPres.Name = "trackBar_OilPres";
            this.trackBar_OilPres.Size = new System.Drawing.Size(266, 28);
            this.trackBar_OilPres.TabIndex = 6;
            this.trackBar_OilPres.TickFrequency = 200;
            this.trackBar_OilPres.ValueChanged += new System.EventHandler(this.trackBar_OilPres_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fuel_Pres";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_FuelPres
            // 
            this.trackBar_FuelPres.Location = new System.Drawing.Point(74, 3);
            this.trackBar_FuelPres.Maximum = 2464;
            this.trackBar_FuelPres.Name = "trackBar_FuelPres";
            this.trackBar_FuelPres.Size = new System.Drawing.Size(266, 28);
            this.trackBar_FuelPres.TabIndex = 8;
            this.trackBar_FuelPres.TickFrequency = 200;
            this.trackBar_FuelPres.ValueChanged += new System.EventHandler(this.trackBar_FuelPres_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "ExtTemp";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_ExtTemp
            // 
            this.trackBar_ExtTemp.Location = new System.Drawing.Point(74, 3);
            this.trackBar_ExtTemp.Maximum = 2464;
            this.trackBar_ExtTemp.Name = "trackBar_ExtTemp";
            this.trackBar_ExtTemp.Size = new System.Drawing.Size(266, 28);
            this.trackBar_ExtTemp.TabIndex = 10;
            this.trackBar_ExtTemp.TickFrequency = 200;
            this.trackBar_ExtTemp.ValueChanged += new System.EventHandler(this.trackBar_ExtTemp_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 34);
            this.label7.TabIndex = 13;
            this.label7.Text = "OilTemp";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_OilTemp
            // 
            this.trackBar_OilTemp.Location = new System.Drawing.Point(74, 3);
            this.trackBar_OilTemp.Maximum = 2464;
            this.trackBar_OilTemp.Name = "trackBar_OilTemp";
            this.trackBar_OilTemp.Size = new System.Drawing.Size(266, 28);
            this.trackBar_OilTemp.TabIndex = 12;
            this.trackBar_OilTemp.TickFrequency = 200;
            this.trackBar_OilTemp.ValueChanged += new System.EventHandler(this.trackBar_OilTemp_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 34);
            this.label8.TabIndex = 15;
            this.label8.Text = "WaterTemp";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_WaterTemp
            // 
            this.trackBar_WaterTemp.Location = new System.Drawing.Point(74, 3);
            this.trackBar_WaterTemp.Maximum = 2464;
            this.trackBar_WaterTemp.Name = "trackBar_WaterTemp";
            this.trackBar_WaterTemp.Size = new System.Drawing.Size(266, 28);
            this.trackBar_WaterTemp.TabIndex = 14;
            this.trackBar_WaterTemp.TickFrequency = 200;
            this.trackBar_WaterTemp.ValueChanged += new System.EventHandler(this.trackBar_WaterTemp_ValueChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(3, 323);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 29);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label_Boost
            // 
            this.label_Boost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Boost.AutoSize = true;
            this.label_Boost.Location = new System.Drawing.Point(346, 0);
            this.label_Boost.Name = "label_Boost";
            this.label_Boost.Size = new System.Drawing.Size(45, 34);
            this.label_Boost.TabIndex = 17;
            this.label_Boost.Text = "0";
            this.label_Boost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Tacho
            // 
            this.label_Tacho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Tacho.AutoSize = true;
            this.label_Tacho.Location = new System.Drawing.Point(346, 0);
            this.label_Tacho.Name = "label_Tacho";
            this.label_Tacho.Size = new System.Drawing.Size(45, 34);
            this.label_Tacho.TabIndex = 18;
            this.label_Tacho.Text = "0";
            this.label_Tacho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_OilPres
            // 
            this.label_OilPres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_OilPres.AutoSize = true;
            this.label_OilPres.Location = new System.Drawing.Point(346, 0);
            this.label_OilPres.Name = "label_OilPres";
            this.label_OilPres.Size = new System.Drawing.Size(45, 34);
            this.label_OilPres.TabIndex = 19;
            this.label_OilPres.Text = "0";
            this.label_OilPres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FuelPres
            // 
            this.label_FuelPres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FuelPres.AutoSize = true;
            this.label_FuelPres.Location = new System.Drawing.Point(346, 0);
            this.label_FuelPres.Name = "label_FuelPres";
            this.label_FuelPres.Size = new System.Drawing.Size(45, 34);
            this.label_FuelPres.TabIndex = 20;
            this.label_FuelPres.Text = "0";
            this.label_FuelPres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ExtTemp
            // 
            this.label_ExtTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ExtTemp.AutoSize = true;
            this.label_ExtTemp.Location = new System.Drawing.Point(346, 0);
            this.label_ExtTemp.Name = "label_ExtTemp";
            this.label_ExtTemp.Size = new System.Drawing.Size(45, 34);
            this.label_ExtTemp.TabIndex = 20;
            this.label_ExtTemp.Text = "0";
            this.label_ExtTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_OilTemp
            // 
            this.label_OilTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_OilTemp.AutoSize = true;
            this.label_OilTemp.Location = new System.Drawing.Point(346, 0);
            this.label_OilTemp.Name = "label_OilTemp";
            this.label_OilTemp.Size = new System.Drawing.Size(45, 34);
            this.label_OilTemp.TabIndex = 20;
            this.label_OilTemp.Text = "0";
            this.label_OilTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_WaterTemp
            // 
            this.label_WaterTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_WaterTemp.AutoSize = true;
            this.label_WaterTemp.Location = new System.Drawing.Point(346, 0);
            this.label_WaterTemp.Name = "label_WaterTemp";
            this.label_WaterTemp.Size = new System.Drawing.Size(45, 34);
            this.label_WaterTemp.TabIndex = 20;
            this.label_WaterTemp.Text = "0";
            this.label_WaterTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.comboBox_COMPortSelect.Location = new System.Drawing.Point(121, 3);
            this.comboBox_COMPortSelect.Name = "comboBox_COMPortSelect";
            this.comboBox_COMPortSelect.Size = new System.Drawing.Size(121, 20);
            this.comboBox_COMPortSelect.TabIndex = 22;
            this.comboBox_COMPortSelect.Text = "COM1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69971F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.30029F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_OilPres, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_OilPres, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 34);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel7);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel8);
            this.flowLayoutPanel1.Controls.Add(this.buttonStart);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(404, 358);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69971F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.30029F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.trackBar_FuelPres, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_FuelPres, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 34);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69971F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.30029F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_Boost, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.trackBar_Boost, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 34);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69971F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.30029F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Controls.Add(this.trackBar_Tacho, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_Tacho, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(394, 34);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69971F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.30029F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.trackBar_ExtTemp, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_ExtTemp, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(394, 34);
            this.tableLayoutPanel5.TabIndex = 23;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69971F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.30029F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.Controls.Add(this.trackBar_OilTemp, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label_OilTemp, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 243);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(394, 34);
            this.tableLayoutPanel6.TabIndex = 23;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.20304F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.79695F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.comboBox_COMPortSelect, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(394, 34);
            this.tableLayoutPanel7.TabIndex = 23;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69971F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.30029F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.Controls.Add(this.trackBar_WaterTemp, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label_WaterTemp, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 283);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(394, 34);
            this.tableLayoutPanel8.TabIndex = 24;
            // 
            // DefilinkEmulator_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 403);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 442);
            this.MinimumSize = new System.Drawing.Size(454, 442);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    }
}

