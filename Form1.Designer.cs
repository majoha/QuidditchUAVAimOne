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
            this.conectToARDoneButton = new System.Windows.Forms.Button();
            this.stopVideoAndDisconnectButton = new System.Windows.Forms.Button();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.startEnginesButton = new System.Windows.Forms.Button();
            this.emergencyButton = new System.Windows.Forms.Button();
            this.startVideoButton = new System.Windows.Forms.Button();
            this.stopVideoButton = new System.Windows.Forms.Button();
            this.flatTrimButton = new System.Windows.Forms.Button();
            this.hoverButton = new System.Windows.Forms.Button();
            this.landButton = new System.Windows.Forms.Button();
            this.setDefaultsButton = new System.Windows.Forms.Button();
            this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
            this.cbDroneVersion = new System.Windows.Forms.ComboBox();
            this.thresholdImagePanel = new Emgu.CV.UI.ImageBox();
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
            this.originalFeedPanel = new Emgu.CV.UI.ImageBox();
            this.currentUAVAltitudeTextbox = new System.Windows.Forms.TextBox();
            this.objectCharacteristicsPanel = new System.Windows.Forms.Panel();
            this.currentObjectAltitudeTextbox = new System.Windows.Forms.TextBox();
            this.zObjectVelocityTextBox = new System.Windows.Forms.TextBox();
            this.yObjectVelocityTextBox = new System.Windows.Forms.TextBox();
            this.xObjectVelocityTextBox = new System.Windows.Forms.TextBox();
            this.distanceToObjectTextBox = new System.Windows.Forms.TextBox();
            this.posYTextBox = new System.Windows.Forms.TextBox();
            this.posXTextBox = new System.Windows.Forms.TextBox();
            this.objectCharacteristicsLabel = new System.Windows.Forms.Label();
            this.erodeLabel = new System.Windows.Forms.Label();
            this.erodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toTrackTrackBar = new System.Windows.Forms.TrackBar();
            this.isTrackingLabel = new System.Windows.Forms.Label();
            this.sourceFeedPanel = new System.Windows.Forms.Panel();
            this.flightCharacteristicsLabel = new System.Windows.Forms.Label();
            this.flightCharacteristicsPanel = new System.Windows.Forms.Panel();
            this.zUAVVelocityTextBox = new System.Windows.Forms.TextBox();
            this.yUAVVelocityTextBox = new System.Windows.Forms.TextBox();
            this.xUAVVelocityTextBox = new System.Windows.Forms.TextBox();
            this.toFollowTrackBar = new System.Windows.Forms.TrackBar();
            this.isfollowingLabel = new System.Windows.Forms.Label();
            this.isPredictingLabel = new System.Windows.Forms.Label();
            this.toPredictTrackBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUAVUp = new System.Windows.Forms.Button();
            this.moveUAVDown = new System.Windows.Forms.Button();
            this.moveUAVForward = new System.Windows.Forms.Button();
            this.moveUAVBackward = new System.Windows.Forms.Button();
            this.moveUAVLeftRoll = new System.Windows.Forms.Button();
            this.moveUAVRightRoll = new System.Windows.Forms.Button();
            this.moveUAVAnticlockwiseYaw = new System.Windows.Forms.Button();
            this.moveUAVClockwiseYaw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdImagePanel)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.originalFeedPanel)).BeginInit();
            this.objectCharacteristicsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toTrackTrackBar)).BeginInit();
            this.flightCharacteristicsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toFollowTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toPredictTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conectToARDoneButton
            // 
            this.conectToARDoneButton.Location = new System.Drawing.Point(12, 28);
            this.conectToARDoneButton.Name = "conectToARDoneButton";
            this.conectToARDoneButton.Size = new System.Drawing.Size(75, 48);
            this.conectToARDoneButton.TabIndex = 1;
            this.conectToARDoneButton.Text = "Connect to AR Drone";
            this.conectToARDoneButton.UseVisualStyleBackColor = true;
            this.conectToARDoneButton.Click += new System.EventHandler(this.conectToARDoneButton_Click);
            // 
            // stopVideoAndDisconnectButton
            // 
            this.stopVideoAndDisconnectButton.Location = new System.Drawing.Point(12, 198);
            this.stopVideoAndDisconnectButton.Name = "stopVideoAndDisconnectButton";
            this.stopVideoAndDisconnectButton.Size = new System.Drawing.Size(75, 48);
            this.stopVideoAndDisconnectButton.TabIndex = 4;
            this.stopVideoAndDisconnectButton.Text = "Stop Video and Disconnect";
            this.stopVideoAndDisconnectButton.UseVisualStyleBackColor = true;
            this.stopVideoAndDisconnectButton.Click += new System.EventHandler(this.stopVideoAndDisconnectButton_Click);
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(12, 169);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.testConnectionButton.TabIndex = 5;
            this.testConnectionButton.Text = "Test Link";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // startEnginesButton
            // 
            this.startEnginesButton.Location = new System.Drawing.Point(93, 140);
            this.startEnginesButton.Name = "startEnginesButton";
            this.startEnginesButton.Size = new System.Drawing.Size(75, 23);
            this.startEnginesButton.TabIndex = 6;
            this.startEnginesButton.Text = "Take Off";
            this.startEnginesButton.UseVisualStyleBackColor = true;
            this.startEnginesButton.Click += new System.EventHandler(this.startEnginesButton_Click);
            // 
            // emergencyButton
            // 
            this.emergencyButton.BackColor = System.Drawing.Color.Red;
            this.emergencyButton.Location = new System.Drawing.Point(93, 223);
            this.emergencyButton.Name = "emergencyButton";
            this.emergencyButton.Size = new System.Drawing.Size(75, 23);
            this.emergencyButton.TabIndex = 7;
            this.emergencyButton.Text = "Emergency";
            this.emergencyButton.UseVisualStyleBackColor = false;
            this.emergencyButton.Click += new System.EventHandler(this.emergencyButton_Click);
            // 
            // startVideoButton
            // 
            this.startVideoButton.Location = new System.Drawing.Point(12, 111);
            this.startVideoButton.Name = "startVideoButton";
            this.startVideoButton.Size = new System.Drawing.Size(75, 23);
            this.startVideoButton.TabIndex = 8;
            this.startVideoButton.Text = "Start Video";
            this.startVideoButton.UseVisualStyleBackColor = true;
            this.startVideoButton.Click += new System.EventHandler(this.startVideoButton_Click);
            // 
            // stopVideoButton
            // 
            this.stopVideoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stopVideoButton.Location = new System.Drawing.Point(12, 140);
            this.stopVideoButton.Name = "stopVideoButton";
            this.stopVideoButton.Size = new System.Drawing.Size(75, 23);
            this.stopVideoButton.TabIndex = 9;
            this.stopVideoButton.Text = "Stop Video";
            this.stopVideoButton.UseVisualStyleBackColor = true;
            this.stopVideoButton.Click += new System.EventHandler(this.stopVideoButton_Click);
            // 
            // flatTrimButton
            // 
            this.flatTrimButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.flatTrimButton.Location = new System.Drawing.Point(93, 111);
            this.flatTrimButton.Name = "flatTrimButton";
            this.flatTrimButton.Size = new System.Drawing.Size(75, 23);
            this.flatTrimButton.TabIndex = 11;
            this.flatTrimButton.Text = "Flat Trim";
            this.flatTrimButton.UseVisualStyleBackColor = true;
            this.flatTrimButton.Click += new System.EventHandler(this.flatTrimButton_Click);
            // 
            // hoverButton
            // 
            this.hoverButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hoverButton.Location = new System.Drawing.Point(93, 169);
            this.hoverButton.Name = "hoverButton";
            this.hoverButton.Size = new System.Drawing.Size(75, 23);
            this.hoverButton.TabIndex = 15;
            this.hoverButton.Text = "Hover";
            this.hoverButton.UseVisualStyleBackColor = true;
            this.hoverButton.Click += new System.EventHandler(this.hoverButton_Click);
            // 
            // landButton
            // 
            this.landButton.Location = new System.Drawing.Point(93, 198);
            this.landButton.Name = "landButton";
            this.landButton.Size = new System.Drawing.Size(75, 23);
            this.landButton.TabIndex = 29;
            this.landButton.Text = "Land";
            this.landButton.UseVisualStyleBackColor = true;
            this.landButton.Click += new System.EventHandler(this.landButton_Click);
            // 
            // setDefaultsButton
            // 
            this.setDefaultsButton.Location = new System.Drawing.Point(12, 82);
            this.setDefaultsButton.Name = "setDefaultsButton";
            this.setDefaultsButton.Size = new System.Drawing.Size(75, 23);
            this.setDefaultsButton.TabIndex = 30;
            this.setDefaultsButton.Text = "Set Defaults";
            this.setDefaultsButton.UseVisualStyleBackColor = true;
            this.setDefaultsButton.Click += new System.EventHandler(this.setDefaultsButton_Click);
            // 
            // ezB_Connect1
            // 
            this.ezB_Connect1.Location = new System.Drawing.Point(0, 669);
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
            this.cbDroneVersion.Location = new System.Drawing.Point(93, 82);
            this.cbDroneVersion.Name = "cbDroneVersion";
            this.cbDroneVersion.Size = new System.Drawing.Size(75, 21);
            this.cbDroneVersion.TabIndex = 34;
            this.cbDroneVersion.SelectedIndexChanged += new System.EventHandler(this.cbDroneVersion_SelectedIndexChanged);
            // 
            // thresholdImagePanel
            // 
            this.thresholdImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdImagePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.thresholdImagePanel.Location = new System.Drawing.Point(922, 28);
            this.thresholdImagePanel.Name = "thresholdImagePanel";
            this.thresholdImagePanel.Size = new System.Drawing.Size(384, 317);
            this.thresholdImagePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thresholdImagePanel.TabIndex = 2;
            this.thresholdImagePanel.TabStop = false;
            this.thresholdImagePanel.Click += new System.EventHandler(this.thresholdImageDisplay_Click);
            // 
            // HueLowNumericUpDown
            // 
            this.HueLowNumericUpDown.Location = new System.Drawing.Point(930, 377);
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
            this.SaturationLowNumericUpDown.Location = new System.Drawing.Point(1056, 377);
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
            this.ValueLowNumericUpDown.Location = new System.Drawing.Point(1182, 377);
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
            this.HueHighNumericUpDown.Location = new System.Drawing.Point(930, 455);
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
            this.SaturationHighNumericUpDown.Location = new System.Drawing.Point(1056, 455);
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
            this.ValueHighNumericUpDown.Location = new System.Drawing.Point(1182, 455);
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
            this.hueLabel.Location = new System.Drawing.Point(973, 361);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(27, 13);
            this.hueLabel.TabIndex = 46;
            this.hueLabel.Text = "Hue";
            this.hueLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // saturationLabel
            // 
            this.saturationLabel.AutoSize = true;
            this.saturationLabel.Location = new System.Drawing.Point(1089, 361);
            this.saturationLabel.Name = "saturationLabel";
            this.saturationLabel.Size = new System.Drawing.Size(55, 13);
            this.saturationLabel.TabIndex = 47;
            this.saturationLabel.Text = "Saturation";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(1215, 361);
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
            this.batteryLevelLabel.Location = new System.Drawing.Point(15, 9);
            this.batteryLevelLabel.Name = "batteryLevelLabel";
            this.batteryLevelLabel.Size = new System.Drawing.Size(86, 13);
            this.batteryLevelLabel.TabIndex = 50;
            this.batteryLevelLabel.Text = "Battery Level (%)";
            this.batteryLevelLabel.Click += new System.EventHandler(this.batteryLevelLabel_Click);
            // 
            // hueLowTrackbar
            // 
            this.hueLowTrackbar.Location = new System.Drawing.Point(930, 403);
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
            this.saturationLowTrackbar.Location = new System.Drawing.Point(1056, 403);
            this.saturationLowTrackbar.Maximum = 255;
            this.saturationLowTrackbar.Name = "saturationLowTrackbar";
            this.saturationLowTrackbar.Size = new System.Drawing.Size(120, 45);
            this.saturationLowTrackbar.TabIndex = 52;
            this.saturationLowTrackbar.Scroll += new System.EventHandler(this.saturationLowTrackbar_Scroll);
            // 
            // valueLowTrackbar
            // 
            this.valueLowTrackbar.Location = new System.Drawing.Point(1182, 403);
            this.valueLowTrackbar.Maximum = 255;
            this.valueLowTrackbar.Name = "valueLowTrackbar";
            this.valueLowTrackbar.Size = new System.Drawing.Size(120, 45);
            this.valueLowTrackbar.TabIndex = 53;
            this.valueLowTrackbar.Scroll += new System.EventHandler(this.valueLowTrackbar_Scroll);
            // 
            // valueHighTrackbar
            // 
            this.valueHighTrackbar.Location = new System.Drawing.Point(1182, 481);
            this.valueHighTrackbar.Maximum = 255;
            this.valueHighTrackbar.Name = "valueHighTrackbar";
            this.valueHighTrackbar.Size = new System.Drawing.Size(120, 45);
            this.valueHighTrackbar.TabIndex = 56;
            this.valueHighTrackbar.Scroll += new System.EventHandler(this.valueHighTrackbar_Scroll);
            // 
            // saturationHighTrackbar
            // 
            this.saturationHighTrackbar.Location = new System.Drawing.Point(1056, 481);
            this.saturationHighTrackbar.Maximum = 255;
            this.saturationHighTrackbar.Name = "saturationHighTrackbar";
            this.saturationHighTrackbar.Size = new System.Drawing.Size(120, 45);
            this.saturationHighTrackbar.TabIndex = 55;
            this.saturationHighTrackbar.Scroll += new System.EventHandler(this.saturationHighTrackbar_Scroll);
            // 
            // hueHighTrackbar
            // 
            this.hueHighTrackbar.Location = new System.Drawing.Point(930, 481);
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
            this.resetThresholdValues.Location = new System.Drawing.Point(1076, 532);
            this.resetThresholdValues.Name = "resetThresholdValues";
            this.resetThresholdValues.Size = new System.Drawing.Size(86, 23);
            this.resetThresholdValues.TabIndex = 57;
            this.resetThresholdValues.Text = "Default Values";
            this.resetThresholdValues.UseVisualStyleBackColor = true;
            this.resetThresholdValues.Click += new System.EventHandler(this.resetThresholdValues_Click);
            // 
            // originalFeedPanel
            // 
            this.originalFeedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalFeedPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.originalFeedPanel.Location = new System.Drawing.Point(522, 358);
            this.originalFeedPanel.Name = "originalFeedPanel";
            this.originalFeedPanel.Size = new System.Drawing.Size(384, 317);
            this.originalFeedPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalFeedPanel.TabIndex = 2;
            this.originalFeedPanel.TabStop = false;
            // 
            // currentUAVAltitudeTextbox
            // 
            this.currentUAVAltitudeTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.currentUAVAltitudeTextbox.Location = new System.Drawing.Point(17, 55);
            this.currentUAVAltitudeTextbox.Name = "currentUAVAltitudeTextbox";
            this.currentUAVAltitudeTextbox.ReadOnly = true;
            this.currentUAVAltitudeTextbox.Size = new System.Drawing.Size(81, 20);
            this.currentUAVAltitudeTextbox.TabIndex = 58;
            this.currentUAVAltitudeTextbox.Text = "altitude";
            this.currentUAVAltitudeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentUAVAltitudeTextbox.WordWrap = false;
            this.currentUAVAltitudeTextbox.TextChanged += new System.EventHandler(this.currentAltitudeTextbox_TextChanged);
            // 
            // objectCharacteristicsPanel
            // 
            this.objectCharacteristicsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.objectCharacteristicsPanel.Controls.Add(this.currentObjectAltitudeTextbox);
            this.objectCharacteristicsPanel.Controls.Add(this.zObjectVelocityTextBox);
            this.objectCharacteristicsPanel.Controls.Add(this.yObjectVelocityTextBox);
            this.objectCharacteristicsPanel.Controls.Add(this.xObjectVelocityTextBox);
            this.objectCharacteristicsPanel.Controls.Add(this.distanceToObjectTextBox);
            this.objectCharacteristicsPanel.Controls.Add(this.posYTextBox);
            this.objectCharacteristicsPanel.Controls.Add(this.posXTextBox);
            this.objectCharacteristicsPanel.Location = new System.Drawing.Point(12, 458);
            this.objectCharacteristicsPanel.Name = "objectCharacteristicsPanel";
            this.objectCharacteristicsPanel.Size = new System.Drawing.Size(117, 220);
            this.objectCharacteristicsPanel.TabIndex = 60;
            // 
            // currentObjectAltitudeTextbox
            // 
            this.currentObjectAltitudeTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.currentObjectAltitudeTextbox.Location = new System.Drawing.Point(17, 88);
            this.currentObjectAltitudeTextbox.Name = "currentObjectAltitudeTextbox";
            this.currentObjectAltitudeTextbox.ReadOnly = true;
            this.currentObjectAltitudeTextbox.Size = new System.Drawing.Size(81, 20);
            this.currentObjectAltitudeTextbox.TabIndex = 70;
            this.currentObjectAltitudeTextbox.Text = "altitude";
            this.currentObjectAltitudeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zObjectVelocityTextBox
            // 
            this.zObjectVelocityTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.zObjectVelocityTextBox.Location = new System.Drawing.Point(17, 166);
            this.zObjectVelocityTextBox.Name = "zObjectVelocityTextBox";
            this.zObjectVelocityTextBox.ReadOnly = true;
            this.zObjectVelocityTextBox.Size = new System.Drawing.Size(82, 20);
            this.zObjectVelocityTextBox.TabIndex = 70;
            this.zObjectVelocityTextBox.Text = "z velocity";
            this.zObjectVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yObjectVelocityTextBox
            // 
            this.yObjectVelocityTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.yObjectVelocityTextBox.Location = new System.Drawing.Point(17, 140);
            this.yObjectVelocityTextBox.Name = "yObjectVelocityTextBox";
            this.yObjectVelocityTextBox.ReadOnly = true;
            this.yObjectVelocityTextBox.Size = new System.Drawing.Size(82, 20);
            this.yObjectVelocityTextBox.TabIndex = 74;
            this.yObjectVelocityTextBox.Text = "y velocity";
            this.yObjectVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xObjectVelocityTextBox
            // 
            this.xObjectVelocityTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.xObjectVelocityTextBox.Location = new System.Drawing.Point(17, 114);
            this.xObjectVelocityTextBox.Name = "xObjectVelocityTextBox";
            this.xObjectVelocityTextBox.ReadOnly = true;
            this.xObjectVelocityTextBox.Size = new System.Drawing.Size(82, 20);
            this.xObjectVelocityTextBox.TabIndex = 73;
            this.xObjectVelocityTextBox.Text = "x velocity";
            this.xObjectVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // distanceToObjectTextBox
            // 
            this.distanceToObjectTextBox.Location = new System.Drawing.Point(17, 62);
            this.distanceToObjectTextBox.Name = "distanceToObjectTextBox";
            this.distanceToObjectTextBox.ReadOnly = true;
            this.distanceToObjectTextBox.Size = new System.Drawing.Size(81, 20);
            this.distanceToObjectTextBox.TabIndex = 71;
            this.distanceToObjectTextBox.Text = "distance";
            this.distanceToObjectTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // posYTextBox
            // 
            this.posYTextBox.Location = new System.Drawing.Point(17, 36);
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
            this.posXTextBox.Location = new System.Drawing.Point(17, 10);
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
            this.objectCharacteristicsLabel.Location = new System.Drawing.Point(17, 438);
            this.objectCharacteristicsLabel.Name = "objectCharacteristicsLabel";
            this.objectCharacteristicsLabel.Size = new System.Drawing.Size(110, 13);
            this.objectCharacteristicsLabel.TabIndex = 61;
            this.objectCharacteristicsLabel.Text = "Object Characteristics";
            // 
            // erodeLabel
            // 
            this.erodeLabel.AutoSize = true;
            this.erodeLabel.Location = new System.Drawing.Point(973, 520);
            this.erodeLabel.Name = "erodeLabel";
            this.erodeLabel.Size = new System.Drawing.Size(35, 13);
            this.erodeLabel.TabIndex = 62;
            this.erodeLabel.Text = "Erode";
            // 
            // erodeNumericUpDown
            // 
            this.erodeNumericUpDown.Location = new System.Drawing.Point(976, 537);
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
            this.toTrackTrackBar.Location = new System.Drawing.Point(29, 377);
            this.toTrackTrackBar.Maximum = 1;
            this.toTrackTrackBar.Name = "toTrackTrackBar";
            this.toTrackTrackBar.Size = new System.Drawing.Size(61, 45);
            this.toTrackTrackBar.TabIndex = 65;
            this.toTrackTrackBar.Scroll += new System.EventHandler(this.toTrackTrackBar_Scroll);
            // 
            // isTrackingLabel
            // 
            this.isTrackingLabel.AutoSize = true;
            this.isTrackingLabel.Location = new System.Drawing.Point(26, 361);
            this.isTrackingLabel.Name = "isTrackingLabel";
            this.isTrackingLabel.Size = new System.Drawing.Size(69, 13);
            this.isTrackingLabel.TabIndex = 66;
            this.isTrackingLabel.Text = "Track Object";
            // 
            // sourceFeedPanel
            // 
            this.sourceFeedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceFeedPanel.Location = new System.Drawing.Point(522, 28);
            this.sourceFeedPanel.Name = "sourceFeedPanel";
            this.sourceFeedPanel.Size = new System.Drawing.Size(384, 317);
            this.sourceFeedPanel.TabIndex = 67;
            // 
            // flightCharacteristicsLabel
            // 
            this.flightCharacteristicsLabel.AutoSize = true;
            this.flightCharacteristicsLabel.Location = new System.Drawing.Point(153, 438);
            this.flightCharacteristicsLabel.Name = "flightCharacteristicsLabel";
            this.flightCharacteristicsLabel.Size = new System.Drawing.Size(104, 13);
            this.flightCharacteristicsLabel.TabIndex = 68;
            this.flightCharacteristicsLabel.Text = "Flight Characteristics";
            // 
            // flightCharacteristicsPanel
            // 
            this.flightCharacteristicsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.flightCharacteristicsPanel.Controls.Add(this.zUAVVelocityTextBox);
            this.flightCharacteristicsPanel.Controls.Add(this.yUAVVelocityTextBox);
            this.flightCharacteristicsPanel.Controls.Add(this.xUAVVelocityTextBox);
            this.flightCharacteristicsPanel.Controls.Add(this.currentUAVAltitudeTextbox);
            this.flightCharacteristicsPanel.Controls.Add(this.batteryLevelBar);
            this.flightCharacteristicsPanel.Controls.Add(this.batteryLevelLabel);
            this.flightCharacteristicsPanel.Location = new System.Drawing.Point(146, 458);
            this.flightCharacteristicsPanel.Name = "flightCharacteristicsPanel";
            this.flightCharacteristicsPanel.Size = new System.Drawing.Size(117, 220);
            this.flightCharacteristicsPanel.TabIndex = 69;
            // 
            // zUAVVelocityTextBox
            // 
            this.zUAVVelocityTextBox.Location = new System.Drawing.Point(17, 134);
            this.zUAVVelocityTextBox.Name = "zUAVVelocityTextBox";
            this.zUAVVelocityTextBox.ReadOnly = true;
            this.zUAVVelocityTextBox.Size = new System.Drawing.Size(81, 20);
            this.zUAVVelocityTextBox.TabIndex = 70;
            this.zUAVVelocityTextBox.Text = "z velocity";
            this.zUAVVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yUAVVelocityTextBox
            // 
            this.yUAVVelocityTextBox.Location = new System.Drawing.Point(17, 108);
            this.yUAVVelocityTextBox.Name = "yUAVVelocityTextBox";
            this.yUAVVelocityTextBox.ReadOnly = true;
            this.yUAVVelocityTextBox.Size = new System.Drawing.Size(81, 20);
            this.yUAVVelocityTextBox.TabIndex = 60;
            this.yUAVVelocityTextBox.Text = "y velocity";
            this.yUAVVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xUAVVelocityTextBox
            // 
            this.xUAVVelocityTextBox.Location = new System.Drawing.Point(17, 82);
            this.xUAVVelocityTextBox.Name = "xUAVVelocityTextBox";
            this.xUAVVelocityTextBox.ReadOnly = true;
            this.xUAVVelocityTextBox.Size = new System.Drawing.Size(81, 20);
            this.xUAVVelocityTextBox.TabIndex = 59;
            this.xUAVVelocityTextBox.Text = "x velocity";
            this.xUAVVelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toFollowTrackBar
            // 
            this.toFollowTrackBar.Location = new System.Drawing.Point(103, 377);
            this.toFollowTrackBar.Maximum = 1;
            this.toFollowTrackBar.Name = "toFollowTrackBar";
            this.toFollowTrackBar.Size = new System.Drawing.Size(61, 45);
            this.toFollowTrackBar.TabIndex = 70;
            // 
            // isfollowingLabel
            // 
            this.isfollowingLabel.AutoSize = true;
            this.isfollowingLabel.Location = new System.Drawing.Point(101, 361);
            this.isfollowingLabel.Name = "isfollowingLabel";
            this.isfollowingLabel.Size = new System.Drawing.Size(71, 13);
            this.isfollowingLabel.TabIndex = 71;
            this.isfollowingLabel.Text = "Follow Object";
            // 
            // isPredictingLabel
            // 
            this.isPredictingLabel.AutoSize = true;
            this.isPredictingLabel.Location = new System.Drawing.Point(175, 361);
            this.isPredictingLabel.Name = "isPredictingLabel";
            this.isPredictingLabel.Size = new System.Drawing.Size(74, 13);
            this.isPredictingLabel.TabIndex = 72;
            this.isPredictingLabel.Text = "Predict Object";
            // 
            // toPredictTrackBar
            // 
            this.toPredictTrackBar.Location = new System.Drawing.Point(178, 377);
            this.toPredictTrackBar.Maximum = 1;
            this.toPredictTrackBar.Name = "toPredictTrackBar";
            this.toPredictTrackBar.Size = new System.Drawing.Size(60, 45);
            this.toPredictTrackBar.TabIndex = 73;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1321, 24);
            this.menuStrip1.TabIndex = 74;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // restartApplicationToolStripMenuItem
            // 
            this.restartApplicationToolStripMenuItem.Name = "restartApplicationToolStripMenuItem";
            this.restartApplicationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restartApplicationToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.restartApplicationToolStripMenuItem.Text = "Restart Application";
            this.restartApplicationToolStripMenuItem.Click += new System.EventHandler(this.restartApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.quitToolStripMenuItem.Text = "&Exit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "&Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // moveUAVUp
            // 
            this.moveUAVUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUAVUp.Location = new System.Drawing.Point(447, 459);
            this.moveUAVUp.Name = "moveUAVUp";
            this.moveUAVUp.Size = new System.Drawing.Size(48, 49);
            this.moveUAVUp.TabIndex = 75;
            this.moveUAVUp.Text = "↥";
            this.moveUAVUp.UseVisualStyleBackColor = true;
            this.moveUAVUp.Click += new System.EventHandler(this.moveUAVUp_Click);
            // 
            // moveUAVDown
            // 
            this.moveUAVDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUAVDown.Location = new System.Drawing.Point(447, 512);
            this.moveUAVDown.Name = "moveUAVDown";
            this.moveUAVDown.Size = new System.Drawing.Size(48, 48);
            this.moveUAVDown.TabIndex = 76;
            this.moveUAVDown.Text = "↧";
            this.moveUAVDown.UseVisualStyleBackColor = true;
            this.moveUAVDown.Click += new System.EventHandler(this.moveUAVDown_Click);
            // 
            // moveUAVForward
            // 
            this.moveUAVForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUAVForward.Location = new System.Drawing.Point(339, 458);
            this.moveUAVForward.Name = "moveUAVForward";
            this.moveUAVForward.Size = new System.Drawing.Size(48, 49);
            this.moveUAVForward.TabIndex = 77;
            this.moveUAVForward.Text = "↑";
            this.moveUAVForward.UseVisualStyleBackColor = true;
            this.moveUAVForward.Click += new System.EventHandler(this.moveUAVForward_Click);
            // 
            // moveUAVBackward
            // 
            this.moveUAVBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUAVBackward.Location = new System.Drawing.Point(339, 512);
            this.moveUAVBackward.Name = "moveUAVBackward";
            this.moveUAVBackward.Size = new System.Drawing.Size(48, 49);
            this.moveUAVBackward.TabIndex = 78;
            this.moveUAVBackward.Text = "↓";
            this.moveUAVBackward.UseVisualStyleBackColor = true;
            this.moveUAVBackward.Click += new System.EventHandler(this.moveUAVBackward_Click);
            // 
            // moveUAVLeftRoll
            // 
            this.moveUAVLeftRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUAVLeftRoll.Location = new System.Drawing.Point(285, 512);
            this.moveUAVLeftRoll.Name = "moveUAVLeftRoll";
            this.moveUAVLeftRoll.Size = new System.Drawing.Size(48, 49);
            this.moveUAVLeftRoll.TabIndex = 79;
            this.moveUAVLeftRoll.Text = "←";
            this.moveUAVLeftRoll.UseVisualStyleBackColor = true;
            this.moveUAVLeftRoll.Click += new System.EventHandler(this.moveUAVLeftRoll_Click);
            // 
            // moveUAVRightRoll
            // 
            this.moveUAVRightRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUAVRightRoll.Location = new System.Drawing.Point(393, 512);
            this.moveUAVRightRoll.Name = "moveUAVRightRoll";
            this.moveUAVRightRoll.Size = new System.Drawing.Size(48, 49);
            this.moveUAVRightRoll.TabIndex = 80;
            this.moveUAVRightRoll.Text = "→";
            this.moveUAVRightRoll.UseVisualStyleBackColor = true;
            this.moveUAVRightRoll.Click += new System.EventHandler(this.moveUAVRightRoll_Click);
            // 
            // moveUAVAnticlockwiseYaw
            // 
            this.moveUAVAnticlockwiseYaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUAVAnticlockwiseYaw.Location = new System.Drawing.Point(285, 458);
            this.moveUAVAnticlockwiseYaw.Name = "moveUAVAnticlockwiseYaw";
            this.moveUAVAnticlockwiseYaw.Size = new System.Drawing.Size(48, 49);
            this.moveUAVAnticlockwiseYaw.TabIndex = 81;
            this.moveUAVAnticlockwiseYaw.Text = "↺";
            this.moveUAVAnticlockwiseYaw.UseVisualStyleBackColor = true;
            this.moveUAVAnticlockwiseYaw.Click += new System.EventHandler(this.moveUAVAnticlockwiseYaw_Click);
            // 
            // moveUAVClockwiseYaw
            // 
            this.moveUAVClockwiseYaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUAVClockwiseYaw.Location = new System.Drawing.Point(393, 459);
            this.moveUAVClockwiseYaw.Name = "moveUAVClockwiseYaw";
            this.moveUAVClockwiseYaw.Size = new System.Drawing.Size(48, 49);
            this.moveUAVClockwiseYaw.TabIndex = 82;
            this.moveUAVClockwiseYaw.Text = "↻";
            this.moveUAVClockwiseYaw.UseVisualStyleBackColor = true;
            this.moveUAVClockwiseYaw.Click += new System.EventHandler(this.moveUAVClockwiseYaw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1321, 685);
            this.Controls.Add(this.moveUAVClockwiseYaw);
            this.Controls.Add(this.moveUAVAnticlockwiseYaw);
            this.Controls.Add(this.moveUAVRightRoll);
            this.Controls.Add(this.moveUAVLeftRoll);
            this.Controls.Add(this.moveUAVBackward);
            this.Controls.Add(this.moveUAVForward);
            this.Controls.Add(this.moveUAVDown);
            this.Controls.Add(this.moveUAVUp);
            this.Controls.Add(this.toPredictTrackBar);
            this.Controls.Add(this.isPredictingLabel);
            this.Controls.Add(this.isfollowingLabel);
            this.Controls.Add(this.toFollowTrackBar);
            this.Controls.Add(this.flightCharacteristicsPanel);
            this.Controls.Add(this.flightCharacteristicsLabel);
            this.Controls.Add(this.sourceFeedPanel);
            this.Controls.Add(this.isTrackingLabel);
            this.Controls.Add(this.toTrackTrackBar);
            this.Controls.Add(this.erodeNumericUpDown);
            this.Controls.Add(this.erodeLabel);
            this.Controls.Add(this.objectCharacteristicsLabel);
            this.Controls.Add(this.objectCharacteristicsPanel);
            this.Controls.Add(this.originalFeedPanel);
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
            this.Controls.Add(this.thresholdImagePanel);
            this.Controls.Add(this.cbDroneVersion);
            this.Controls.Add(this.setDefaultsButton);
            this.Controls.Add(this.landButton);
            this.Controls.Add(this.hoverButton);
            this.Controls.Add(this.flatTrimButton);
            this.Controls.Add(this.stopVideoButton);
            this.Controls.Add(this.startVideoButton);
            this.Controls.Add(this.emergencyButton);
            this.Controls.Add(this.startEnginesButton);
            this.Controls.Add(this.testConnectionButton);
            this.Controls.Add(this.stopVideoAndDisconnectButton);
            this.Controls.Add(this.conectToARDoneButton);
            this.Controls.Add(this.ezB_Connect1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UAV Quidditch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thresholdImagePanel)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.originalFeedPanel)).EndInit();
            this.objectCharacteristicsPanel.ResumeLayout(false);
            this.objectCharacteristicsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toTrackTrackBar)).EndInit();
            this.flightCharacteristicsPanel.ResumeLayout(false);
            this.flightCharacteristicsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toFollowTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toPredictTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EZ_B.UCEZB_Connect ezB_Connect1;
        private System.Windows.Forms.Button conectToARDoneButton;
        private System.Windows.Forms.Button stopVideoAndDisconnectButton;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.Button startEnginesButton;
        private System.Windows.Forms.Button emergencyButton;
        private System.Windows.Forms.Button startVideoButton;
        private System.Windows.Forms.Button stopVideoButton;
        private System.Windows.Forms.Button flatTrimButton;
        private System.Windows.Forms.Button hoverButton;
        private System.Windows.Forms.Button landButton;
        private System.Windows.Forms.Button setDefaultsButton;
        private System.Windows.Forms.ComboBox cbDroneVersion;
        private Emgu.CV.UI.ImageBox thresholdImagePanel;
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
        private Emgu.CV.UI.ImageBox originalFeedPanel;
        private System.Windows.Forms.TextBox currentUAVAltitudeTextbox;
        private System.Windows.Forms.Panel objectCharacteristicsPanel;
        private System.Windows.Forms.Label objectCharacteristicsLabel;
        private System.Windows.Forms.TextBox posYTextBox;
        private System.Windows.Forms.TextBox posXTextBox;
        private System.Windows.Forms.Label erodeLabel;
        private System.Windows.Forms.NumericUpDown erodeNumericUpDown;
        private System.Windows.Forms.TrackBar toTrackTrackBar;
        private System.Windows.Forms.Label isTrackingLabel;
        private System.Windows.Forms.Panel sourceFeedPanel;
        private System.Windows.Forms.Label flightCharacteristicsLabel;
        private System.Windows.Forms.TextBox distanceToObjectTextBox;
        private System.Windows.Forms.Panel flightCharacteristicsPanel;
        private System.Windows.Forms.TextBox zUAVVelocityTextBox;
        private System.Windows.Forms.TextBox yUAVVelocityTextBox;
        private System.Windows.Forms.TextBox xUAVVelocityTextBox;
        private System.Windows.Forms.TextBox xObjectVelocityTextBox;
        private System.Windows.Forms.TextBox zObjectVelocityTextBox;
        private System.Windows.Forms.TextBox yObjectVelocityTextBox;
        private System.Windows.Forms.TextBox currentObjectAltitudeTextbox;
        private System.Windows.Forms.TrackBar toFollowTrackBar;
        private System.Windows.Forms.Label isfollowingLabel;
        private System.Windows.Forms.Label isPredictingLabel;
        private System.Windows.Forms.TrackBar toPredictTrackBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem restartApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button moveUAVUp;
        private System.Windows.Forms.Button moveUAVDown;
        private System.Windows.Forms.Button moveUAVForward;
        private System.Windows.Forms.Button moveUAVBackward;
        private System.Windows.Forms.Button moveUAVLeftRoll;
        private System.Windows.Forms.Button moveUAVRightRoll;
        private System.Windows.Forms.Button moveUAVAnticlockwiseYaw;
        private System.Windows.Forms.Button moveUAVClockwiseYaw;
    }
}

