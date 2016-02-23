namespace Tutorial_31___AR_Drone
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
            this.cbDroneVersion = new System.Windows.Forms.ComboBox();
            this.thresholdImageDisplay = new Emgu.CV.UI.ImageBox();
            this.HueLowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaturationLowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ValueLowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HueHighNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaturationHighNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ValueHighNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hueLabel = new System.Windows.Forms.Label();
            this.saturationLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.batteryLevelBar = new System.Windows.Forms.ProgressBar();
            this.batteryLevelLabel = new System.Windows.Forms.Label();
            this.hueLowTrackbar = new System.Windows.Forms.TrackBar();
            this.saturationLowTrackbar = new System.Windows.Forms.TrackBar();
            this.valueLowTrackbar = new System.Windows.Forms.TrackBar();
            this.valueHighTrackbar = new System.Windows.Forms.TrackBar();
            this.saturationHighTrackbar = new System.Windows.Forms.TrackBar();
            this.hueHighTrackbar = new System.Windows.Forms.TrackBar();
            this.resetThresholdValues = new System.Windows.Forms.Button();
            this.originalFeed = new Emgu.CV.UI.ImageBox();
            this.currentUAVAltitudeTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.distanceToObjectTextBox = new System.Windows.Forms.TextBox();
            this.posYTextBox = new System.Windows.Forms.TextBox();
            this.posXTextBox = new System.Windows.Forms.TextBox();
            this.objectCharacteristicsLabel = new System.Windows.Forms.Label();
            this.erodeLabel = new System.Windows.Forms.Label();
            this.erodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toTrackTrackBar = new System.Windows.Forms.TrackBar();
            this.isTrackingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flightCharacteristicsLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.zUAVVelocityTextBox = new System.Windows.Forms.TextBox();
            this.yUAVVelocityTextBox = new System.Windows.Forms.TextBox();
            this.xUAVVelocityTextBox = new System.Windows.Forms.TextBox();
            this.xObjectVelocityTextBox = new System.Windows.Forms.TextBox();
            this.yObjectVelocityTextBox = new System.Windows.Forms.TextBox();
            this.zObjectVelocityTextBox = new System.Windows.Forms.TextBox();
            this.currentObjectAltitudeTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdImageDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueLowNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationLowNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueLowNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueHighNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationHighNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueHighNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueLowTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationLowTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueLowTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueHighTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationHighTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueHighTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalFeed)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toTrackTrackBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect to AR Drone";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop Video and Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Test Connection";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Start Engines";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(93, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Emergency";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Start Video";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button7.Location = new System.Drawing.Point(12, 124);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Stop Video";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button8.Location = new System.Drawing.Point(93, 66);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Flat Trim";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button9.Location = new System.Drawing.Point(93, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Hover";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(93, 153);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(91, 23);
            this.button19.TabIndex = 29;
            this.button19.Text = "Land";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(12, 66);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 30;
            this.button20.Text = "Set Defaults";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // ezB_Connect1
            // 
            this.ezB_Connect1.Location = new System.Drawing.Point(1189, 1);
            this.ezB_Connect1.Name = "ezB_Connect1";
            this.ezB_Connect1.Port = "COM4";
            this.ezB_Connect1.ShowDebugButton = true;
            this.ezB_Connect1.Size = new System.Drawing.Size(10, 10);
            this.ezB_Connect1.TabIndex = 0;
            this.ezB_Connect1.TCPPassword = null;
            this.ezB_Connect1.Visible = false;
            this.ezB_Connect1.Load += new System.EventHandler(this.ezB_Connect1_Load);
            // 
            // cbDroneVersion
            // 
            this.cbDroneVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDroneVersion.FormattingEnabled = true;
            this.cbDroneVersion.Location = new System.Drawing.Point(93, 27);
            this.cbDroneVersion.Name = "cbDroneVersion";
            this.cbDroneVersion.Size = new System.Drawing.Size(91, 21);
            this.cbDroneVersion.TabIndex = 34;
            this.cbDroneVersion.SelectedIndexChanged += new System.EventHandler(this.cbDroneVersion_SelectedIndexChanged);
            // 
            // thresholdImageDisplay
            // 
            this.thresholdImageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdImageDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.thresholdImageDisplay.Location = new System.Drawing.Point(702, 12);
            this.thresholdImageDisplay.Name = "thresholdImageDisplay";
            this.thresholdImageDisplay.Size = new System.Drawing.Size(384, 317);
            this.thresholdImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thresholdImageDisplay.TabIndex = 2;
            this.thresholdImageDisplay.TabStop = false;
            this.thresholdImageDisplay.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // HueLowNumericUpDown
            // 
            this.HueLowNumericUpDown.Location = new System.Drawing.Point(710, 361);
            this.HueLowNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HueLowNumericUpDown.Name = "HueLowNumericUpDown";
            this.HueLowNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.HueLowNumericUpDown.TabIndex = 35;
            this.HueLowNumericUpDown.ValueChanged += new System.EventHandler(this.Hue_ValueChanged);
            // 
            // SaturationLowNumericUpDown
            // 
            this.SaturationLowNumericUpDown.Location = new System.Drawing.Point(836, 361);
            this.SaturationLowNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SaturationLowNumericUpDown.Name = "SaturationLowNumericUpDown";
            this.SaturationLowNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.SaturationLowNumericUpDown.TabIndex = 36;
            this.SaturationLowNumericUpDown.ValueChanged += new System.EventHandler(this.SaturationLow_ValueChanged);
            // 
            // ValueLowNumericUpDown
            // 
            this.ValueLowNumericUpDown.Location = new System.Drawing.Point(962, 361);
            this.ValueLowNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ValueLowNumericUpDown.Name = "ValueLowNumericUpDown";
            this.ValueLowNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ValueLowNumericUpDown.TabIndex = 37;
            this.ValueLowNumericUpDown.ValueChanged += new System.EventHandler(this.ValueLow_ValueChanged);
            // 
            // HueHighNumericUpDown
            // 
            this.HueHighNumericUpDown.Location = new System.Drawing.Point(710, 439);
            this.HueHighNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HueHighNumericUpDown.Name = "HueHighNumericUpDown";
            this.HueHighNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.HueHighNumericUpDown.TabIndex = 41;
            this.HueHighNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // SaturationHighNumericUpDown
            // 
            this.SaturationHighNumericUpDown.Location = new System.Drawing.Point(836, 439);
            this.SaturationHighNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SaturationHighNumericUpDown.Name = "SaturationHighNumericUpDown";
            this.SaturationHighNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.SaturationHighNumericUpDown.TabIndex = 42;
            this.SaturationHighNumericUpDown.ValueChanged += new System.EventHandler(this.SaturationHigh_ValueChanged);
            // 
            // ValueHighNumericUpDown
            // 
            this.ValueHighNumericUpDown.Location = new System.Drawing.Point(962, 439);
            this.ValueHighNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ValueHighNumericUpDown.Name = "ValueHighNumericUpDown";
            this.ValueHighNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ValueHighNumericUpDown.TabIndex = 43;
            this.ValueHighNumericUpDown.ValueChanged += new System.EventHandler(this.ValueHigh_ValueChanged);
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(753, 345);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(27, 13);
            this.hueLabel.TabIndex = 46;
            this.hueLabel.Text = "Hue";
            this.hueLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // saturationLabel
            // 
            this.saturationLabel.AutoSize = true;
            this.saturationLabel.Location = new System.Drawing.Point(869, 345);
            this.saturationLabel.Name = "saturationLabel";
            this.saturationLabel.Size = new System.Drawing.Size(55, 13);
            this.saturationLabel.TabIndex = 47;
            this.saturationLabel.Text = "Saturation";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(995, 345);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(34, 13);
            this.valueLabel.TabIndex = 48;
            this.valueLabel.Text = "Value";
            // 
            // batteryLevelBar
            // 
            this.batteryLevelBar.Location = new System.Drawing.Point(7, 26);
            this.batteryLevelBar.MarqueeAnimationSpeed = 10;
            this.batteryLevelBar.Name = "batteryLevelBar";
            this.batteryLevelBar.Size = new System.Drawing.Size(103, 23);
            this.batteryLevelBar.TabIndex = 49;
            this.batteryLevelBar.Click += new System.EventHandler(this.batteryLevelBar_Click);
            // 
            // batteryLevelLabel
            // 
            this.batteryLevelLabel.AutoSize = true;
            this.batteryLevelLabel.Location = new System.Drawing.Point(6, 9);
            this.batteryLevelLabel.Name = "batteryLevelLabel";
            this.batteryLevelLabel.Size = new System.Drawing.Size(86, 13);
            this.batteryLevelLabel.TabIndex = 50;
            this.batteryLevelLabel.Text = "Battery Level (%)";
            this.batteryLevelLabel.Click += new System.EventHandler(this.batteryLevelLabel_Click);
            // 
            // hueLowTrackbar
            // 
            this.hueLowTrackbar.Location = new System.Drawing.Point(710, 387);
            this.hueLowTrackbar.Maximum = 255;
            this.hueLowTrackbar.Minimum = 1;
            this.hueLowTrackbar.Name = "hueLowTrackbar";
            this.hueLowTrackbar.Size = new System.Drawing.Size(120, 45);
            this.hueLowTrackbar.TabIndex = 51;
            this.hueLowTrackbar.Value = 1;
            this.hueLowTrackbar.Scroll += new System.EventHandler(this.hueLowTrackbar_Scroll);
            // 
            // saturationLowTrackbar
            // 
            this.saturationLowTrackbar.Location = new System.Drawing.Point(836, 387);
            this.saturationLowTrackbar.Maximum = 255;
            this.saturationLowTrackbar.Name = "saturationLowTrackbar";
            this.saturationLowTrackbar.Size = new System.Drawing.Size(120, 45);
            this.saturationLowTrackbar.TabIndex = 52;
            this.saturationLowTrackbar.Scroll += new System.EventHandler(this.saturationLowTrackbar_Scroll);
            // 
            // valueLowTrackbar
            // 
            this.valueLowTrackbar.Location = new System.Drawing.Point(962, 387);
            this.valueLowTrackbar.Maximum = 255;
            this.valueLowTrackbar.Name = "valueLowTrackbar";
            this.valueLowTrackbar.Size = new System.Drawing.Size(120, 45);
            this.valueLowTrackbar.TabIndex = 53;
            this.valueLowTrackbar.Scroll += new System.EventHandler(this.valueLowTrackbar_Scroll);
            // 
            // valueHighTrackbar
            // 
            this.valueHighTrackbar.Location = new System.Drawing.Point(962, 465);
            this.valueHighTrackbar.Maximum = 255;
            this.valueHighTrackbar.Name = "valueHighTrackbar";
            this.valueHighTrackbar.Size = new System.Drawing.Size(120, 45);
            this.valueHighTrackbar.TabIndex = 56;
            this.valueHighTrackbar.Scroll += new System.EventHandler(this.valueHighTrackbar_Scroll);
            // 
            // saturationHighTrackbar
            // 
            this.saturationHighTrackbar.Location = new System.Drawing.Point(836, 465);
            this.saturationHighTrackbar.Maximum = 255;
            this.saturationHighTrackbar.Name = "saturationHighTrackbar";
            this.saturationHighTrackbar.Size = new System.Drawing.Size(120, 45);
            this.saturationHighTrackbar.TabIndex = 55;
            this.saturationHighTrackbar.Scroll += new System.EventHandler(this.saturationHighTrackbar_Scroll);
            // 
            // hueHighTrackbar
            // 
            this.hueHighTrackbar.Location = new System.Drawing.Point(710, 465);
            this.hueHighTrackbar.Maximum = 255;
            this.hueHighTrackbar.Minimum = 1;
            this.hueHighTrackbar.Name = "hueHighTrackbar";
            this.hueHighTrackbar.Size = new System.Drawing.Size(120, 45);
            this.hueHighTrackbar.TabIndex = 54;
            this.hueHighTrackbar.Value = 1;
            this.hueHighTrackbar.Scroll += new System.EventHandler(this.hueHighTrackbar_Scroll);
            // 
            // resetThresholdValues
            // 
            this.resetThresholdValues.AutoSize = true;
            this.resetThresholdValues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetThresholdValues.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetThresholdValues.Location = new System.Drawing.Point(856, 516);
            this.resetThresholdValues.Name = "resetThresholdValues";
            this.resetThresholdValues.Size = new System.Drawing.Size(86, 23);
            this.resetThresholdValues.TabIndex = 57;
            this.resetThresholdValues.Text = "Default Values";
            this.resetThresholdValues.UseVisualStyleBackColor = true;
            this.resetThresholdValues.Click += new System.EventHandler(this.resetThresholdValues_Click);
            // 
            // originalFeed
            // 
            this.originalFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalFeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.originalFeed.Location = new System.Drawing.Point(302, 342);
            this.originalFeed.Name = "originalFeed";
            this.originalFeed.Size = new System.Drawing.Size(384, 317);
            this.originalFeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalFeed.TabIndex = 2;
            this.originalFeed.TabStop = false;
            // 
            // currentUAVAltitudeTextbox
            // 
            this.currentUAVAltitudeTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.currentUAVAltitudeTextbox.Location = new System.Drawing.Point(7, 55);
            this.currentUAVAltitudeTextbox.Name = "currentUAVAltitudeTextbox";
            this.currentUAVAltitudeTextbox.ReadOnly = true;
            this.currentUAVAltitudeTextbox.Size = new System.Drawing.Size(81, 20);
            this.currentUAVAltitudeTextbox.TabIndex = 58;
            this.currentUAVAltitudeTextbox.Text = "altitude";
            this.currentUAVAltitudeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentUAVAltitudeTextbox.WordWrap = false;
            this.currentUAVAltitudeTextbox.TextChanged += new System.EventHandler(this.currentAltitudeTextbox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.currentObjectAltitudeTextbox);
            this.panel2.Controls.Add(this.zObjectVelocityTextBox);
            this.panel2.Controls.Add(this.yObjectVelocityTextBox);
            this.panel2.Controls.Add(this.xObjectVelocityTextBox);
            this.panel2.Controls.Add(this.distanceToObjectTextBox);
            this.panel2.Controls.Add(this.posYTextBox);
            this.panel2.Controls.Add(this.posXTextBox);
            this.panel2.Location = new System.Drawing.Point(23, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 220);
            this.panel2.TabIndex = 60;
            // 
            // distanceToObjectTextBox
            // 
            this.distanceToObjectTextBox.Location = new System.Drawing.Point(6, 59);
            this.distanceToObjectTextBox.Name = "distanceToObjectTextBox";
            this.distanceToObjectTextBox.ReadOnly = true;
            this.distanceToObjectTextBox.Size = new System.Drawing.Size(81, 20);
            this.distanceToObjectTextBox.TabIndex = 71;
            this.distanceToObjectTextBox.Text = "distance";
            this.distanceToObjectTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // posYTextBox
            // 
            this.posYTextBox.Location = new System.Drawing.Point(6, 33);
            this.posYTextBox.Name = "posYTextBox";
            this.posYTextBox.ReadOnly = true;
            this.posYTextBox.Size = new System.Drawing.Size(82, 20);
            this.posYTextBox.TabIndex = 61;
            this.posYTextBox.Text = "posY";
            this.posYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.posYTextBox.TextChanged += new System.EventHandler(this.posYTextBox_TextChanged);
            // 
            // posXTextBox
            // 
            this.posXTextBox.Location = new System.Drawing.Point(6, 7);
            this.posXTextBox.Name = "posXTextBox";
            this.posXTextBox.ReadOnly = true;
            this.posXTextBox.Size = new System.Drawing.Size(81, 20);
            this.posXTextBox.TabIndex = 72;
            this.posXTextBox.Text = "posX";
            this.posXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // objectCharacteristicsLabel
            // 
            this.objectCharacteristicsLabel.AutoSize = true;
            this.objectCharacteristicsLabel.Location = new System.Drawing.Point(28, 419);
            this.objectCharacteristicsLabel.Name = "objectCharacteristicsLabel";
            this.objectCharacteristicsLabel.Size = new System.Drawing.Size(110, 13);
            this.objectCharacteristicsLabel.TabIndex = 61;
            this.objectCharacteristicsLabel.Text = "Object Characteristics";
            // 
            // erodeLabel
            // 
            this.erodeLabel.AutoSize = true;
            this.erodeLabel.Location = new System.Drawing.Point(753, 504);
            this.erodeLabel.Name = "erodeLabel";
            this.erodeLabel.Size = new System.Drawing.Size(35, 13);
            this.erodeLabel.TabIndex = 62;
            this.erodeLabel.Text = "Erode";
            // 
            // erodeNumericUpDown
            // 
            this.erodeNumericUpDown.Location = new System.Drawing.Point(756, 521);
            this.erodeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.erodeNumericUpDown.Name = "erodeNumericUpDown";
            this.erodeNumericUpDown.Size = new System.Drawing.Size(34, 20);
            this.erodeNumericUpDown.TabIndex = 64;
            this.erodeNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // toTrackTrackBar
            // 
            this.toTrackTrackBar.LargeChange = 1;
            this.toTrackTrackBar.Location = new System.Drawing.Point(23, 371);
            this.toTrackTrackBar.Maximum = 1;
            this.toTrackTrackBar.Name = "toTrackTrackBar";
            this.toTrackTrackBar.Size = new System.Drawing.Size(61, 45);
            this.toTrackTrackBar.TabIndex = 65;
            this.toTrackTrackBar.Scroll += new System.EventHandler(this.toTrackTrackBar_Scroll);
            // 
            // isTrackingLabel
            // 
            this.isTrackingLabel.AutoSize = true;
            this.isTrackingLabel.Location = new System.Drawing.Point(20, 355);
            this.isTrackingLabel.Name = "isTrackingLabel";
            this.isTrackingLabel.Size = new System.Drawing.Size(69, 13);
            this.isTrackingLabel.TabIndex = 66;
            this.isTrackingLabel.Text = "Track Object";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(302, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 317);
            this.panel1.TabIndex = 67;
            // 
            // flightCharacteristicsLabel
            // 
            this.flightCharacteristicsLabel.AutoSize = true;
            this.flightCharacteristicsLabel.Location = new System.Drawing.Point(164, 419);
            this.flightCharacteristicsLabel.Name = "flightCharacteristicsLabel";
            this.flightCharacteristicsLabel.Size = new System.Drawing.Size(104, 13);
            this.flightCharacteristicsLabel.TabIndex = 68;
            this.flightCharacteristicsLabel.Text = "Flight Characteristics";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.zUAVVelocityTextBox);
            this.panel3.Controls.Add(this.yUAVVelocityTextBox);
            this.panel3.Controls.Add(this.xUAVVelocityTextBox);
            this.panel3.Controls.Add(this.currentUAVAltitudeTextbox);
            this.panel3.Controls.Add(this.batteryLevelBar);
            this.panel3.Controls.Add(this.batteryLevelLabel);
            this.panel3.Location = new System.Drawing.Point(157, 439);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 220);
            this.panel3.TabIndex = 69;
            // 
            // zUAVVelocityTextBox
            // 
            this.zUAVVelocityTextBox.Location = new System.Drawing.Point(7, 134);
            this.zUAVVelocityTextBox.Name = "zUAVVelocityTextBox";
            this.zUAVVelocityTextBox.ReadOnly = true;
            this.zUAVVelocityTextBox.Size = new System.Drawing.Size(81, 20);
            this.zUAVVelocityTextBox.TabIndex = 70;
            this.zUAVVelocityTextBox.Text = "z velocity";
            this.zUAVVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yUAVVelocityTextBox
            // 
            this.yUAVVelocityTextBox.Location = new System.Drawing.Point(7, 108);
            this.yUAVVelocityTextBox.Name = "yUAVVelocityTextBox";
            this.yUAVVelocityTextBox.ReadOnly = true;
            this.yUAVVelocityTextBox.Size = new System.Drawing.Size(81, 20);
            this.yUAVVelocityTextBox.TabIndex = 60;
            this.yUAVVelocityTextBox.Text = "y velocity";
            this.yUAVVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xUAVVelocityTextBox
            // 
            this.xUAVVelocityTextBox.Location = new System.Drawing.Point(7, 82);
            this.xUAVVelocityTextBox.Name = "xUAVVelocityTextBox";
            this.xUAVVelocityTextBox.ReadOnly = true;
            this.xUAVVelocityTextBox.Size = new System.Drawing.Size(81, 20);
            this.xUAVVelocityTextBox.TabIndex = 59;
            this.xUAVVelocityTextBox.Text = "x velocity";
            this.xUAVVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xObjectVelocityTextBox
            // 
            this.xObjectVelocityTextBox.Location = new System.Drawing.Point(6, 111);
            this.xObjectVelocityTextBox.Name = "xObjectVelocityTextBox";
            this.xObjectVelocityTextBox.Size = new System.Drawing.Size(82, 20);
            this.xObjectVelocityTextBox.TabIndex = 73;
            this.xObjectVelocityTextBox.Text = "x velocity";
            this.xObjectVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yObjectVelocityTextBox
            // 
            this.yObjectVelocityTextBox.Location = new System.Drawing.Point(6, 137);
            this.yObjectVelocityTextBox.Name = "yObjectVelocityTextBox";
            this.yObjectVelocityTextBox.Size = new System.Drawing.Size(82, 20);
            this.yObjectVelocityTextBox.TabIndex = 74;
            this.yObjectVelocityTextBox.Text = "y velocity";
            this.yObjectVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zObjectVelocityTextBox
            // 
            this.zObjectVelocityTextBox.Location = new System.Drawing.Point(6, 163);
            this.zObjectVelocityTextBox.Name = "zObjectVelocityTextBox";
            this.zObjectVelocityTextBox.Size = new System.Drawing.Size(82, 20);
            this.zObjectVelocityTextBox.TabIndex = 70;
            this.zObjectVelocityTextBox.Text = "z velocity";
            this.zObjectVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentObjectAltitudeTextbox
            // 
            this.currentObjectAltitudeTextbox.Location = new System.Drawing.Point(6, 85);
            this.currentObjectAltitudeTextbox.Name = "currentObjectAltitudeTextbox";
            this.currentObjectAltitudeTextbox.Size = new System.Drawing.Size(81, 20);
            this.currentObjectAltitudeTextbox.TabIndex = 70;
            this.currentObjectAltitudeTextbox.Text = "altitude";
            this.currentObjectAltitudeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1096, 666);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flightCharacteristicsLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.isTrackingLabel);
            this.Controls.Add(this.toTrackTrackBar);
            this.Controls.Add(this.erodeNumericUpDown);
            this.Controls.Add(this.erodeLabel);
            this.Controls.Add(this.objectCharacteristicsLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.originalFeed);
            this.Controls.Add(this.resetThresholdValues);
            this.Controls.Add(this.valueHighTrackbar);
            this.Controls.Add(this.saturationHighTrackbar);
            this.Controls.Add(this.hueHighTrackbar);
            this.Controls.Add(this.valueLowTrackbar);
            this.Controls.Add(this.saturationLowTrackbar);
            this.Controls.Add(this.hueLowTrackbar);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.saturationLabel);
            this.Controls.Add(this.hueLabel);
            this.Controls.Add(this.ValueHighNumericUpDown);
            this.Controls.Add(this.SaturationHighNumericUpDown);
            this.Controls.Add(this.HueHighNumericUpDown);
            this.Controls.Add(this.ValueLowNumericUpDown);
            this.Controls.Add(this.SaturationLowNumericUpDown);
            this.Controls.Add(this.HueLowNumericUpDown);
            this.Controls.Add(this.thresholdImageDisplay);
            this.Controls.Add(this.cbDroneVersion);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ezB_Connect1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UAV Quidditch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thresholdImageDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueLowNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationLowNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueLowNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueHighNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationHighNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueHighNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueLowTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationLowTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueLowTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueHighTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationHighTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueHighTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalFeed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toTrackTrackBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EZ_B.UCEZB_Connect ezB_Connect1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.ComboBox cbDroneVersion;
        private Emgu.CV.UI.ImageBox thresholdImageDisplay;
        private System.Windows.Forms.NumericUpDown HueLowNumericUpDown;
        private System.Windows.Forms.NumericUpDown SaturationLowNumericUpDown;
        private System.Windows.Forms.NumericUpDown ValueLowNumericUpDown;
        private System.Windows.Forms.NumericUpDown HueHighNumericUpDown;
        private System.Windows.Forms.NumericUpDown SaturationHighNumericUpDown;
        private System.Windows.Forms.NumericUpDown ValueHighNumericUpDown;
        private System.Windows.Forms.Label hueLabel;
        private System.Windows.Forms.Label saturationLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.ProgressBar batteryLevelBar;
        private System.Windows.Forms.Label batteryLevelLabel;
        private System.Windows.Forms.TrackBar hueLowTrackbar;
        private System.Windows.Forms.TrackBar saturationLowTrackbar;
        private System.Windows.Forms.TrackBar valueLowTrackbar;
        private System.Windows.Forms.TrackBar valueHighTrackbar;
        private System.Windows.Forms.TrackBar saturationHighTrackbar;
        private System.Windows.Forms.TrackBar hueHighTrackbar;
        private System.Windows.Forms.Button resetThresholdValues;
        private Emgu.CV.UI.ImageBox originalFeed;
        private System.Windows.Forms.TextBox currentUAVAltitudeTextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label objectCharacteristicsLabel;
        private System.Windows.Forms.TextBox posYTextBox;
        private System.Windows.Forms.TextBox posXTextBox;
        private System.Windows.Forms.Label erodeLabel;
        private System.Windows.Forms.NumericUpDown erodeNumericUpDown;
        private System.Windows.Forms.TrackBar toTrackTrackBar;
        private System.Windows.Forms.Label isTrackingLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label flightCharacteristicsLabel;
        private System.Windows.Forms.TextBox distanceToObjectTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox zUAVVelocityTextBox;
        private System.Windows.Forms.TextBox yUAVVelocityTextBox;
        private System.Windows.Forms.TextBox xUAVVelocityTextBox;
        private System.Windows.Forms.TextBox xObjectVelocityTextBox;
        private System.Windows.Forms.TextBox zObjectVelocityTextBox;
        private System.Windows.Forms.TextBox yObjectVelocityTextBox;
        private System.Windows.Forms.TextBox currentObjectAltitudeTextbox;
    }
}

