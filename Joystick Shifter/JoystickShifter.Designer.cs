
namespace Joystick_Shifter
{
    partial class JoystickShifter
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlProfileManagement = new System.Windows.Forms.Panel();
            this.lbxProfilesList = new System.Windows.Forms.ListBox();
            this.tboxProfileName = new System.Windows.Forms.TextBox();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.pnlConfiguration = new System.Windows.Forms.Panel();
            this.pnlKeyboardOutput = new System.Windows.Forms.Panel();
            this.btnDetectKeyboardOutput1 = new System.Windows.Forms.Button();
            this.cbxKeyboardOutput1 = new System.Windows.Forms.ComboBox();
            this.cbxKeyboardOutput2 = new System.Windows.Forms.ComboBox();
            this.btnDetectKeyboardOutputN = new System.Windows.Forms.Button();
            this.cbxKeyboardOutput3 = new System.Windows.Forms.ComboBox();
            this.btnDetectKeyboardOutputR = new System.Windows.Forms.Button();
            this.cbxKeyboardOutput4 = new System.Windows.Forms.ComboBox();
            this.btnDetectKeyboardOutput6 = new System.Windows.Forms.Button();
            this.cbxKeyboardOutput5 = new System.Windows.Forms.ComboBox();
            this.btnDetectKeyboardOutput5 = new System.Windows.Forms.Button();
            this.cbxKeyboardOutput6 = new System.Windows.Forms.ComboBox();
            this.btnDetectKeyboardOutput4 = new System.Windows.Forms.Button();
            this.cbxKeyboardOutputR = new System.Windows.Forms.ComboBox();
            this.btnDetectKeyboardOutput3 = new System.Windows.Forms.Button();
            this.cbxKeyboardOutputN = new System.Windows.Forms.ComboBox();
            this.btnDetectKeyboardOutput2 = new System.Windows.Forms.Button();
            this.btnDetectInputN = new System.Windows.Forms.Button();
            this.btnDetectInputR = new System.Windows.Forms.Button();
            this.nudvJoyDeviceNumber = new System.Windows.Forms.NumericUpDown();
            this.nudHorizontalActivationZone = new System.Windows.Forms.NumericUpDown();
            this.nudVerticalActivationZone = new System.Windows.Forms.NumericUpDown();
            this.cbxInputN = new System.Windows.Forms.ComboBox();
            this.cbxInputR = new System.Windows.Forms.ComboBox();
            this.pnlOutputType = new System.Windows.Forms.Panel();
            this.rbtnKeyboardMode = new System.Windows.Forms.RadioButton();
            this.rbtnvJoyMode = new System.Windows.Forms.RadioButton();
            this.btnUpdateDInputDevices = new System.Windows.Forms.Button();
            this.lbxInputDevicesList = new System.Windows.Forms.ListBox();
            this.chkMappingMode = new System.Windows.Forms.CheckBox();
            this.lblGearIndicator = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblControllerInputReverse = new System.Windows.Forms.Label();
            this.lblControllerInputNeutral = new System.Windows.Forms.Label();
            this.lblKeyboardOutput1 = new System.Windows.Forms.Label();
            this.lblKeyboardOutput2 = new System.Windows.Forms.Label();
            this.lblKeyboardOutput3 = new System.Windows.Forms.Label();
            this.lblKeyboardOutput4 = new System.Windows.Forms.Label();
            this.lblKeyboardOutput5 = new System.Windows.Forms.Label();
            this.lblKeyboardOutput6 = new System.Windows.Forms.Label();
            this.lblKeyboardOutputR = new System.Windows.Forms.Label();
            this.lblKeyboardOutputN = new System.Windows.Forms.Label();
            this.lblVerticalActivationZone = new System.Windows.Forms.Label();
            this.lblHorizontalActivationZone = new System.Windows.Forms.Label();
            this.lblInputDevicesList = new System.Windows.Forms.Label();
            this.pnlProfileManagement.SuspendLayout();
            this.pnlConfiguration.SuspendLayout();
            this.pnlKeyboardOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudvJoyDeviceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontalActivationZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerticalActivationZone)).BeginInit();
            this.pnlOutputType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(30, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlProfileManagement
            // 
            this.pnlProfileManagement.Controls.Add(this.lblProfileName);
            this.pnlProfileManagement.Controls.Add(this.lbxProfilesList);
            this.pnlProfileManagement.Controls.Add(this.tboxProfileName);
            this.pnlProfileManagement.Controls.Add(this.btnDeleteProfile);
            this.pnlProfileManagement.Controls.Add(this.btnSaveProfile);
            this.pnlProfileManagement.Location = new System.Drawing.Point(21, 60);
            this.pnlProfileManagement.Name = "pnlProfileManagement";
            this.pnlProfileManagement.Size = new System.Drawing.Size(211, 255);
            this.pnlProfileManagement.TabIndex = 1;
            // 
            // lbxProfilesList
            // 
            this.lbxProfilesList.FormattingEnabled = true;
            this.lbxProfilesList.Location = new System.Drawing.Point(9, 71);
            this.lbxProfilesList.Name = "lbxProfilesList";
            this.lbxProfilesList.Size = new System.Drawing.Size(120, 95);
            this.lbxProfilesList.TabIndex = 2;
            this.lbxProfilesList.SelectedIndexChanged += new System.EventHandler(this.lbxProfilesList_SelectedIndexChanged);
            // 
            // tboxProfileName
            // 
            this.tboxProfileName.Location = new System.Drawing.Point(9, 45);
            this.tboxProfileName.Name = "tboxProfileName";
            this.tboxProfileName.Size = new System.Drawing.Size(100, 20);
            this.tboxProfileName.TabIndex = 2;
            this.tboxProfileName.TextChanged += new System.EventHandler(this.tboxProfileName_TextChanged);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Enabled = false;
            this.btnDeleteProfile.Location = new System.Drawing.Point(90, 0);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProfile.TabIndex = 2;
            this.btnDeleteProfile.Text = "Delete";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(9, 0);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProfile.TabIndex = 2;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // pnlConfiguration
            // 
            this.pnlConfiguration.Controls.Add(this.lblHorizontalActivationZone);
            this.pnlConfiguration.Controls.Add(this.lblVerticalActivationZone);
            this.pnlConfiguration.Controls.Add(this.lblControllerInputNeutral);
            this.pnlConfiguration.Controls.Add(this.lblControllerInputReverse);
            this.pnlConfiguration.Controls.Add(this.pnlKeyboardOutput);
            this.pnlConfiguration.Controls.Add(this.btnDetectInputN);
            this.pnlConfiguration.Controls.Add(this.btnDetectInputR);
            this.pnlConfiguration.Controls.Add(this.nudvJoyDeviceNumber);
            this.pnlConfiguration.Controls.Add(this.nudHorizontalActivationZone);
            this.pnlConfiguration.Controls.Add(this.nudVerticalActivationZone);
            this.pnlConfiguration.Controls.Add(this.cbxInputN);
            this.pnlConfiguration.Controls.Add(this.cbxInputR);
            this.pnlConfiguration.Controls.Add(this.pnlOutputType);
            this.pnlConfiguration.Location = new System.Drawing.Point(339, 130);
            this.pnlConfiguration.Name = "pnlConfiguration";
            this.pnlConfiguration.Size = new System.Drawing.Size(446, 308);
            this.pnlConfiguration.TabIndex = 2;
            // 
            // pnlKeyboardOutput
            // 
            this.pnlKeyboardOutput.Controls.Add(this.btnDetectKeyboardOutput1);
            this.pnlKeyboardOutput.Controls.Add(this.lblKeyboardOutputN);
            this.pnlKeyboardOutput.Controls.Add(this.lblKeyboardOutputR);
            this.pnlKeyboardOutput.Controls.Add(this.lblKeyboardOutput6);
            this.pnlKeyboardOutput.Controls.Add(this.lblKeyboardOutput5);
            this.pnlKeyboardOutput.Controls.Add(this.lblKeyboardOutput4);
            this.pnlKeyboardOutput.Controls.Add(this.lblKeyboardOutput3);
            this.pnlKeyboardOutput.Controls.Add(this.lblKeyboardOutput2);
            this.pnlKeyboardOutput.Controls.Add(this.lblKeyboardOutput1);
            this.pnlKeyboardOutput.Controls.Add(this.cbxKeyboardOutput1);
            this.pnlKeyboardOutput.Controls.Add(this.cbxKeyboardOutput2);
            this.pnlKeyboardOutput.Controls.Add(this.btnDetectKeyboardOutputN);
            this.pnlKeyboardOutput.Controls.Add(this.cbxKeyboardOutput3);
            this.pnlKeyboardOutput.Controls.Add(this.btnDetectKeyboardOutputR);
            this.pnlKeyboardOutput.Controls.Add(this.cbxKeyboardOutput4);
            this.pnlKeyboardOutput.Controls.Add(this.btnDetectKeyboardOutput6);
            this.pnlKeyboardOutput.Controls.Add(this.cbxKeyboardOutput5);
            this.pnlKeyboardOutput.Controls.Add(this.btnDetectKeyboardOutput5);
            this.pnlKeyboardOutput.Controls.Add(this.cbxKeyboardOutput6);
            this.pnlKeyboardOutput.Controls.Add(this.btnDetectKeyboardOutput4);
            this.pnlKeyboardOutput.Controls.Add(this.cbxKeyboardOutputR);
            this.pnlKeyboardOutput.Controls.Add(this.btnDetectKeyboardOutput3);
            this.pnlKeyboardOutput.Controls.Add(this.cbxKeyboardOutputN);
            this.pnlKeyboardOutput.Controls.Add(this.btnDetectKeyboardOutput2);
            this.pnlKeyboardOutput.Location = new System.Drawing.Point(227, 6);
            this.pnlKeyboardOutput.Name = "pnlKeyboardOutput";
            this.pnlKeyboardOutput.Size = new System.Drawing.Size(210, 299);
            this.pnlKeyboardOutput.TabIndex = 3;
            // 
            // btnDetectKeyboardOutput1
            // 
            this.btnDetectKeyboardOutput1.Location = new System.Drawing.Point(5, 18);
            this.btnDetectKeyboardOutput1.Name = "btnDetectKeyboardOutput1";
            this.btnDetectKeyboardOutput1.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput1.TabIndex = 16;
            this.btnDetectKeyboardOutput1.Text = "Detect";
            this.btnDetectKeyboardOutput1.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput1.Click += new System.EventHandler(this.btnDetectKeyboardOutput1_Click);
            // 
            // cbxKeyboardOutput1
            // 
            this.cbxKeyboardOutput1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput1.FormattingEnabled = true;
            this.cbxKeyboardOutput1.Location = new System.Drawing.Point(86, 18);
            this.cbxKeyboardOutput1.Name = "cbxKeyboardOutput1";
            this.cbxKeyboardOutput1.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput1.TabIndex = 7;
            // 
            // cbxKeyboardOutput2
            // 
            this.cbxKeyboardOutput2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput2.FormattingEnabled = true;
            this.cbxKeyboardOutput2.Location = new System.Drawing.Point(86, 53);
            this.cbxKeyboardOutput2.Name = "cbxKeyboardOutput2";
            this.cbxKeyboardOutput2.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput2.TabIndex = 8;
            // 
            // btnDetectKeyboardOutputN
            // 
            this.btnDetectKeyboardOutputN.Location = new System.Drawing.Point(5, 263);
            this.btnDetectKeyboardOutputN.Name = "btnDetectKeyboardOutputN";
            this.btnDetectKeyboardOutputN.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutputN.TabIndex = 23;
            this.btnDetectKeyboardOutputN.Text = "Detect";
            this.btnDetectKeyboardOutputN.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutputN.Click += new System.EventHandler(this.btnDetectKeyboardOutputN_Click);
            // 
            // cbxKeyboardOutput3
            // 
            this.cbxKeyboardOutput3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput3.FormattingEnabled = true;
            this.cbxKeyboardOutput3.Location = new System.Drawing.Point(86, 88);
            this.cbxKeyboardOutput3.Name = "cbxKeyboardOutput3";
            this.cbxKeyboardOutput3.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput3.TabIndex = 9;
            // 
            // btnDetectKeyboardOutputR
            // 
            this.btnDetectKeyboardOutputR.Location = new System.Drawing.Point(5, 228);
            this.btnDetectKeyboardOutputR.Name = "btnDetectKeyboardOutputR";
            this.btnDetectKeyboardOutputR.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutputR.TabIndex = 22;
            this.btnDetectKeyboardOutputR.Text = "Detect";
            this.btnDetectKeyboardOutputR.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutputR.Click += new System.EventHandler(this.btnDetectKeyboardOutputR_Click);
            // 
            // cbxKeyboardOutput4
            // 
            this.cbxKeyboardOutput4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput4.FormattingEnabled = true;
            this.cbxKeyboardOutput4.Location = new System.Drawing.Point(86, 123);
            this.cbxKeyboardOutput4.Name = "cbxKeyboardOutput4";
            this.cbxKeyboardOutput4.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput4.TabIndex = 10;
            // 
            // btnDetectKeyboardOutput6
            // 
            this.btnDetectKeyboardOutput6.Location = new System.Drawing.Point(5, 193);
            this.btnDetectKeyboardOutput6.Name = "btnDetectKeyboardOutput6";
            this.btnDetectKeyboardOutput6.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput6.TabIndex = 21;
            this.btnDetectKeyboardOutput6.Text = "Detect";
            this.btnDetectKeyboardOutput6.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput6.Click += new System.EventHandler(this.btnDetectKeyboardOutput6_Click);
            // 
            // cbxKeyboardOutput5
            // 
            this.cbxKeyboardOutput5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput5.FormattingEnabled = true;
            this.cbxKeyboardOutput5.Location = new System.Drawing.Point(86, 158);
            this.cbxKeyboardOutput5.Name = "cbxKeyboardOutput5";
            this.cbxKeyboardOutput5.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput5.TabIndex = 11;
            // 
            // btnDetectKeyboardOutput5
            // 
            this.btnDetectKeyboardOutput5.Location = new System.Drawing.Point(5, 158);
            this.btnDetectKeyboardOutput5.Name = "btnDetectKeyboardOutput5";
            this.btnDetectKeyboardOutput5.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput5.TabIndex = 20;
            this.btnDetectKeyboardOutput5.Text = "Detect";
            this.btnDetectKeyboardOutput5.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput5.Click += new System.EventHandler(this.btnDetectKeyboardOutput5_Click);
            // 
            // cbxKeyboardOutput6
            // 
            this.cbxKeyboardOutput6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput6.FormattingEnabled = true;
            this.cbxKeyboardOutput6.Location = new System.Drawing.Point(86, 193);
            this.cbxKeyboardOutput6.Name = "cbxKeyboardOutput6";
            this.cbxKeyboardOutput6.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput6.TabIndex = 12;
            // 
            // btnDetectKeyboardOutput4
            // 
            this.btnDetectKeyboardOutput4.Location = new System.Drawing.Point(5, 123);
            this.btnDetectKeyboardOutput4.Name = "btnDetectKeyboardOutput4";
            this.btnDetectKeyboardOutput4.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput4.TabIndex = 19;
            this.btnDetectKeyboardOutput4.Text = "Detect";
            this.btnDetectKeyboardOutput4.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput4.Click += new System.EventHandler(this.btnDetectKeyboardOutput4_Click);
            // 
            // cbxKeyboardOutputR
            // 
            this.cbxKeyboardOutputR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutputR.FormattingEnabled = true;
            this.cbxKeyboardOutputR.Location = new System.Drawing.Point(86, 228);
            this.cbxKeyboardOutputR.Name = "cbxKeyboardOutputR";
            this.cbxKeyboardOutputR.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutputR.TabIndex = 13;
            // 
            // btnDetectKeyboardOutput3
            // 
            this.btnDetectKeyboardOutput3.Location = new System.Drawing.Point(5, 88);
            this.btnDetectKeyboardOutput3.Name = "btnDetectKeyboardOutput3";
            this.btnDetectKeyboardOutput3.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput3.TabIndex = 18;
            this.btnDetectKeyboardOutput3.Text = "Detect";
            this.btnDetectKeyboardOutput3.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput3.Click += new System.EventHandler(this.btnDetectKeyboardOutput3_Click);
            // 
            // cbxKeyboardOutputN
            // 
            this.cbxKeyboardOutputN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutputN.FormattingEnabled = true;
            this.cbxKeyboardOutputN.Location = new System.Drawing.Point(86, 263);
            this.cbxKeyboardOutputN.Name = "cbxKeyboardOutputN";
            this.cbxKeyboardOutputN.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutputN.TabIndex = 14;
            // 
            // btnDetectKeyboardOutput2
            // 
            this.btnDetectKeyboardOutput2.Location = new System.Drawing.Point(5, 53);
            this.btnDetectKeyboardOutput2.Name = "btnDetectKeyboardOutput2";
            this.btnDetectKeyboardOutput2.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput2.TabIndex = 17;
            this.btnDetectKeyboardOutput2.Text = "Detect";
            this.btnDetectKeyboardOutput2.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput2.Click += new System.EventHandler(this.btnDetectKeyboardOutput2_Click);
            // 
            // btnDetectInputN
            // 
            this.btnDetectInputN.Location = new System.Drawing.Point(9, 163);
            this.btnDetectInputN.Name = "btnDetectInputN";
            this.btnDetectInputN.Size = new System.Drawing.Size(75, 23);
            this.btnDetectInputN.TabIndex = 3;
            this.btnDetectInputN.Text = "Detect";
            this.btnDetectInputN.UseVisualStyleBackColor = true;
            this.btnDetectInputN.Click += new System.EventHandler(this.btnDetectInputN_Click);
            // 
            // btnDetectInputR
            // 
            this.btnDetectInputR.Location = new System.Drawing.Point(9, 116);
            this.btnDetectInputR.Name = "btnDetectInputR";
            this.btnDetectInputR.Size = new System.Drawing.Size(75, 23);
            this.btnDetectInputR.TabIndex = 3;
            this.btnDetectInputR.Text = "Detect";
            this.btnDetectInputR.UseVisualStyleBackColor = true;
            this.btnDetectInputR.Click += new System.EventHandler(this.btnDetectInputR_Click);
            // 
            // nudvJoyDeviceNumber
            // 
            this.nudvJoyDeviceNumber.Enabled = false;
            this.nudvJoyDeviceNumber.Location = new System.Drawing.Point(89, 11);
            this.nudvJoyDeviceNumber.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudvJoyDeviceNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudvJoyDeviceNumber.Name = "nudvJoyDeviceNumber";
            this.nudvJoyDeviceNumber.Size = new System.Drawing.Size(34, 20);
            this.nudvJoyDeviceNumber.TabIndex = 15;
            this.nudvJoyDeviceNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudHorizontalActivationZone
            // 
            this.nudHorizontalActivationZone.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHorizontalActivationZone.Location = new System.Drawing.Point(12, 256);
            this.nudHorizontalActivationZone.Name = "nudHorizontalActivationZone";
            this.nudHorizontalActivationZone.Size = new System.Drawing.Size(47, 20);
            this.nudHorizontalActivationZone.TabIndex = 5;
            this.nudHorizontalActivationZone.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // nudVerticalActivationZone
            // 
            this.nudVerticalActivationZone.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudVerticalActivationZone.Location = new System.Drawing.Point(12, 212);
            this.nudVerticalActivationZone.Name = "nudVerticalActivationZone";
            this.nudVerticalActivationZone.Size = new System.Drawing.Size(47, 20);
            this.nudVerticalActivationZone.TabIndex = 4;
            this.nudVerticalActivationZone.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // cbxInputN
            // 
            this.cbxInputN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInputN.FormattingEnabled = true;
            this.cbxInputN.Items.AddRange(new object[] {
            "Button 1",
            "Button 2",
            "Button 3",
            "Button 4",
            "Button 5",
            "Button 6",
            "Button 7",
            "Button 8",
            "Button 9",
            "Button 10",
            "Button 11",
            "Button 12",
            "Button 13",
            "Button 14",
            "Button 15",
            "Button 16",
            "Button 17",
            "Button 18",
            "Button 19",
            "Button 20",
            "Button 21",
            "Button 22",
            "Button 23",
            "Button 24",
            "Button 25",
            "Button 26",
            "Button 27",
            "Button 28",
            "Button 29",
            "Button 30",
            "Button 31",
            "Button 32",
            "Button 33",
            "Button 34",
            "Button 35",
            "Button 36",
            "Button 37",
            "Button 38",
            "Button 39",
            "Button 40",
            "Button 41",
            "Button 42",
            "Button 43",
            "Button 44",
            "Button 45",
            "Button 46",
            "Button 47",
            "Button 48",
            "Button 49",
            "Button 50",
            "Button 51",
            "Button 52",
            "Button 53",
            "Button 54",
            "Button 55",
            "Button 56",
            "Button 57",
            "Button 58",
            "Button 59",
            "Button 60",
            "Button 61",
            "Button 62",
            "Button 63",
            "Button 64",
            "Button 65",
            "Button 66",
            "Button 67",
            "Button 68",
            "Button 69",
            "Button 70",
            "Button 71",
            "Button 72",
            "Button 73",
            "Button 74",
            "Button 75",
            "Button 76",
            "Button 77",
            "Button 78",
            "Button 79",
            "Button 80",
            "Button 81",
            "Button 82",
            "Button 83",
            "Button 84",
            "Button 85",
            "Button 86",
            "Button 87",
            "Button 88",
            "Button 89",
            "Button 90",
            "Button 91",
            "Button 92",
            "Button 93",
            "Button 94",
            "Button 95",
            "Button 96",
            "Button 97",
            "Button 98",
            "Button 99",
            "Button 100",
            "Button 101",
            "Button 102",
            "Button 103",
            "Button 104",
            "Button 105",
            "Button 106",
            "Button 107",
            "Button 108",
            "Button 109",
            "Button 110",
            "Button 111",
            "Button 112",
            "Button 113",
            "Button 114",
            "Button 115",
            "Button 116",
            "Button 117",
            "Button 118",
            "Button 119",
            "Button 120",
            "Button 121",
            "Button 122",
            "Button 123",
            "Button 124",
            "Button 125",
            "Button 126",
            "Button 127",
            "Button 128"});
            this.cbxInputN.Location = new System.Drawing.Point(89, 164);
            this.cbxInputN.Name = "cbxInputN";
            this.cbxInputN.Size = new System.Drawing.Size(121, 21);
            this.cbxInputN.TabIndex = 3;
            // 
            // cbxInputR
            // 
            this.cbxInputR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInputR.FormattingEnabled = true;
            this.cbxInputR.Items.AddRange(new object[] {
            "Button 1",
            "Button 2",
            "Button 3",
            "Button 4",
            "Button 5",
            "Button 6",
            "Button 7",
            "Button 8",
            "Button 9",
            "Button 10",
            "Button 11",
            "Button 12",
            "Button 13",
            "Button 14",
            "Button 15",
            "Button 16",
            "Button 17",
            "Button 18",
            "Button 19",
            "Button 20",
            "Button 21",
            "Button 22",
            "Button 23",
            "Button 24",
            "Button 25",
            "Button 26",
            "Button 27",
            "Button 28",
            "Button 29",
            "Button 30",
            "Button 31",
            "Button 32",
            "Button 33",
            "Button 34",
            "Button 35",
            "Button 36",
            "Button 37",
            "Button 38",
            "Button 39",
            "Button 40",
            "Button 41",
            "Button 42",
            "Button 43",
            "Button 44",
            "Button 45",
            "Button 46",
            "Button 47",
            "Button 48",
            "Button 49",
            "Button 50",
            "Button 51",
            "Button 52",
            "Button 53",
            "Button 54",
            "Button 55",
            "Button 56",
            "Button 57",
            "Button 58",
            "Button 59",
            "Button 60",
            "Button 61",
            "Button 62",
            "Button 63",
            "Button 64",
            "Button 65",
            "Button 66",
            "Button 67",
            "Button 68",
            "Button 69",
            "Button 70",
            "Button 71",
            "Button 72",
            "Button 73",
            "Button 74",
            "Button 75",
            "Button 76",
            "Button 77",
            "Button 78",
            "Button 79",
            "Button 80",
            "Button 81",
            "Button 82",
            "Button 83",
            "Button 84",
            "Button 85",
            "Button 86",
            "Button 87",
            "Button 88",
            "Button 89",
            "Button 90",
            "Button 91",
            "Button 92",
            "Button 93",
            "Button 94",
            "Button 95",
            "Button 96",
            "Button 97",
            "Button 98",
            "Button 99",
            "Button 100",
            "Button 101",
            "Button 102",
            "Button 103",
            "Button 104",
            "Button 105",
            "Button 106",
            "Button 107",
            "Button 108",
            "Button 109",
            "Button 110",
            "Button 111",
            "Button 112",
            "Button 113",
            "Button 114",
            "Button 115",
            "Button 116",
            "Button 117",
            "Button 118",
            "Button 119",
            "Button 120",
            "Button 121",
            "Button 122",
            "Button 123",
            "Button 124",
            "Button 125",
            "Button 126",
            "Button 127",
            "Button 128"});
            this.cbxInputR.Location = new System.Drawing.Point(88, 116);
            this.cbxInputR.Name = "cbxInputR";
            this.cbxInputR.Size = new System.Drawing.Size(121, 21);
            this.cbxInputR.TabIndex = 2;
            // 
            // pnlOutputType
            // 
            this.pnlOutputType.Controls.Add(this.rbtnKeyboardMode);
            this.pnlOutputType.Controls.Add(this.rbtnvJoyMode);
            this.pnlOutputType.Location = new System.Drawing.Point(9, 8);
            this.pnlOutputType.Name = "pnlOutputType";
            this.pnlOutputType.Size = new System.Drawing.Size(75, 49);
            this.pnlOutputType.TabIndex = 0;
            // 
            // rbtnKeyboardMode
            // 
            this.rbtnKeyboardMode.AutoSize = true;
            this.rbtnKeyboardMode.Checked = true;
            this.rbtnKeyboardMode.Location = new System.Drawing.Point(3, 31);
            this.rbtnKeyboardMode.Name = "rbtnKeyboardMode";
            this.rbtnKeyboardMode.Size = new System.Drawing.Size(70, 17);
            this.rbtnKeyboardMode.TabIndex = 1;
            this.rbtnKeyboardMode.TabStop = true;
            this.rbtnKeyboardMode.Text = "Keyboard";
            this.rbtnKeyboardMode.UseVisualStyleBackColor = true;
            this.rbtnKeyboardMode.CheckedChanged += new System.EventHandler(this.rbtnKeyboardMode_CheckedChanged);
            // 
            // rbtnvJoyMode
            // 
            this.rbtnvJoyMode.AutoSize = true;
            this.rbtnvJoyMode.Location = new System.Drawing.Point(3, 3);
            this.rbtnvJoyMode.Name = "rbtnvJoyMode";
            this.rbtnvJoyMode.Size = new System.Drawing.Size(47, 17);
            this.rbtnvJoyMode.TabIndex = 0;
            this.rbtnvJoyMode.Text = "vJoy";
            this.rbtnvJoyMode.UseVisualStyleBackColor = true;
            this.rbtnvJoyMode.CheckedChanged += new System.EventHandler(this.rbtnvJoyMode_CheckedChanged);
            // 
            // btnUpdateDInputDevices
            // 
            this.btnUpdateDInputDevices.Location = new System.Drawing.Point(710, 8);
            this.btnUpdateDInputDevices.Name = "btnUpdateDInputDevices";
            this.btnUpdateDInputDevices.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDInputDevices.TabIndex = 4;
            this.btnUpdateDInputDevices.Text = "Update";
            this.btnUpdateDInputDevices.UseVisualStyleBackColor = true;
            this.btnUpdateDInputDevices.Click += new System.EventHandler(this.btnUpdateDInputDevices_Click);
            // 
            // lbxInputDevicesList
            // 
            this.lbxInputDevicesList.FormattingEnabled = true;
            this.lbxInputDevicesList.HorizontalScrollbar = true;
            this.lbxInputDevicesList.Location = new System.Drawing.Point(351, 34);
            this.lbxInputDevicesList.Name = "lbxInputDevicesList";
            this.lbxInputDevicesList.Size = new System.Drawing.Size(434, 95);
            this.lbxInputDevicesList.TabIndex = 1;
            // 
            // chkMappingMode
            // 
            this.chkMappingMode.AutoSize = true;
            this.chkMappingMode.Location = new System.Drawing.Point(111, 8);
            this.chkMappingMode.Name = "chkMappingMode";
            this.chkMappingMode.Size = new System.Drawing.Size(97, 17);
            this.chkMappingMode.TabIndex = 5;
            this.chkMappingMode.Text = "Mapping Mode";
            this.chkMappingMode.UseVisualStyleBackColor = true;
            // 
            // lblGearIndicator
            // 
            this.lblGearIndicator.AutoSize = true;
            this.lblGearIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGearIndicator.Location = new System.Drawing.Point(246, 34);
            this.lblGearIndicator.Name = "lblGearIndicator";
            this.lblGearIndicator.Size = new System.Drawing.Size(60, 20);
            this.lblGearIndicator.TabIndex = 6;
            this.lblGearIndicator.Text = "Gear N";
            this.lblGearIndicator.Visible = false;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(6, 29);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(70, 13);
            this.lblProfileName.TabIndex = 3;
            this.lblProfileName.Text = "ProfileName: ";
            // 
            // lblControllerInputReverse
            // 
            this.lblControllerInputReverse.AutoSize = true;
            this.lblControllerInputReverse.Location = new System.Drawing.Point(86, 100);
            this.lblControllerInputReverse.Name = "lblControllerInputReverse";
            this.lblControllerInputReverse.Size = new System.Drawing.Size(127, 13);
            this.lblControllerInputReverse.TabIndex = 16;
            this.lblControllerInputReverse.Text = "Controller Input Reverse: ";
            // 
            // lblControllerInputNeutral
            // 
            this.lblControllerInputNeutral.AutoSize = true;
            this.lblControllerInputNeutral.Location = new System.Drawing.Point(86, 150);
            this.lblControllerInputNeutral.Name = "lblControllerInputNeutral";
            this.lblControllerInputNeutral.Size = new System.Drawing.Size(121, 13);
            this.lblControllerInputNeutral.TabIndex = 17;
            this.lblControllerInputNeutral.Text = "Controller Input Neutral: ";
            // 
            // lblKeyboardOutput1
            // 
            this.lblKeyboardOutput1.AutoSize = true;
            this.lblKeyboardOutput1.Location = new System.Drawing.Point(86, 5);
            this.lblKeyboardOutput1.Name = "lblKeyboardOutput1";
            this.lblKeyboardOutput1.Size = new System.Drawing.Size(102, 13);
            this.lblKeyboardOutput1.TabIndex = 16;
            this.lblKeyboardOutput1.Text = "Keyboard Output 1: ";
            // 
            // lblKeyboardOutput2
            // 
            this.lblKeyboardOutput2.AutoSize = true;
            this.lblKeyboardOutput2.Location = new System.Drawing.Point(86, 40);
            this.lblKeyboardOutput2.Name = "lblKeyboardOutput2";
            this.lblKeyboardOutput2.Size = new System.Drawing.Size(102, 13);
            this.lblKeyboardOutput2.TabIndex = 16;
            this.lblKeyboardOutput2.Text = "Keyboard Output 2: ";
            // 
            // lblKeyboardOutput3
            // 
            this.lblKeyboardOutput3.AutoSize = true;
            this.lblKeyboardOutput3.Location = new System.Drawing.Point(86, 75);
            this.lblKeyboardOutput3.Name = "lblKeyboardOutput3";
            this.lblKeyboardOutput3.Size = new System.Drawing.Size(102, 13);
            this.lblKeyboardOutput3.TabIndex = 16;
            this.lblKeyboardOutput3.Text = "Keyboard Output 3: ";
            // 
            // lblKeyboardOutput4
            // 
            this.lblKeyboardOutput4.AutoSize = true;
            this.lblKeyboardOutput4.Location = new System.Drawing.Point(86, 110);
            this.lblKeyboardOutput4.Name = "lblKeyboardOutput4";
            this.lblKeyboardOutput4.Size = new System.Drawing.Size(102, 13);
            this.lblKeyboardOutput4.TabIndex = 16;
            this.lblKeyboardOutput4.Text = "Keyboard Output 4: ";
            // 
            // lblKeyboardOutput5
            // 
            this.lblKeyboardOutput5.AutoSize = true;
            this.lblKeyboardOutput5.Location = new System.Drawing.Point(86, 145);
            this.lblKeyboardOutput5.Name = "lblKeyboardOutput5";
            this.lblKeyboardOutput5.Size = new System.Drawing.Size(102, 13);
            this.lblKeyboardOutput5.TabIndex = 16;
            this.lblKeyboardOutput5.Text = "Keyboard Output 5: ";
            // 
            // lblKeyboardOutput6
            // 
            this.lblKeyboardOutput6.AutoSize = true;
            this.lblKeyboardOutput6.Location = new System.Drawing.Point(86, 180);
            this.lblKeyboardOutput6.Name = "lblKeyboardOutput6";
            this.lblKeyboardOutput6.Size = new System.Drawing.Size(102, 13);
            this.lblKeyboardOutput6.TabIndex = 16;
            this.lblKeyboardOutput6.Text = "Keyboard Output 6: ";
            // 
            // lblKeyboardOutputR
            // 
            this.lblKeyboardOutputR.AutoSize = true;
            this.lblKeyboardOutputR.Location = new System.Drawing.Point(86, 215);
            this.lblKeyboardOutputR.Name = "lblKeyboardOutputR";
            this.lblKeyboardOutputR.Size = new System.Drawing.Size(104, 13);
            this.lblKeyboardOutputR.TabIndex = 16;
            this.lblKeyboardOutputR.Text = "Keyboard Output R: ";
            // 
            // lblKeyboardOutputN
            // 
            this.lblKeyboardOutputN.AutoSize = true;
            this.lblKeyboardOutputN.Location = new System.Drawing.Point(86, 250);
            this.lblKeyboardOutputN.Name = "lblKeyboardOutputN";
            this.lblKeyboardOutputN.Size = new System.Drawing.Size(104, 13);
            this.lblKeyboardOutputN.TabIndex = 16;
            this.lblKeyboardOutputN.Text = "Keyboard Output N: ";
            // 
            // lblVerticalActivationZone
            // 
            this.lblVerticalActivationZone.AutoSize = true;
            this.lblVerticalActivationZone.Location = new System.Drawing.Point(9, 199);
            this.lblVerticalActivationZone.Name = "lblVerticalActivationZone";
            this.lblVerticalActivationZone.Size = new System.Drawing.Size(153, 13);
            this.lblVerticalActivationZone.TabIndex = 18;
            this.lblVerticalActivationZone.Text = "Stick Vertical Activation Zone: ";
            // 
            // lblHorizontalActivationZone
            // 
            this.lblHorizontalActivationZone.AutoSize = true;
            this.lblHorizontalActivationZone.Location = new System.Drawing.Point(9, 242);
            this.lblHorizontalActivationZone.Name = "lblHorizontalActivationZone";
            this.lblHorizontalActivationZone.Size = new System.Drawing.Size(165, 13);
            this.lblHorizontalActivationZone.TabIndex = 18;
            this.lblHorizontalActivationZone.Text = "Stick Horizontal Activation Zone: ";
            // 
            // lblInputDevicesList
            // 
            this.lblInputDevicesList.AutoSize = true;
            this.lblInputDevicesList.Location = new System.Drawing.Point(348, 18);
            this.lblInputDevicesList.Name = "lblInputDevicesList";
            this.lblInputDevicesList.Size = new System.Drawing.Size(98, 13);
            this.lblInputDevicesList.TabIndex = 7;
            this.lblInputDevicesList.Text = "Input Devices List: ";
            // 
            // JoystickShifter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInputDevicesList);
            this.Controls.Add(this.lblGearIndicator);
            this.Controls.Add(this.chkMappingMode);
            this.Controls.Add(this.pnlConfiguration);
            this.Controls.Add(this.pnlProfileManagement);
            this.Controls.Add(this.btnUpdateDInputDevices);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbxInputDevicesList);
            this.Name = "JoystickShifter";
            this.Text = "Joystick Shifter";
            this.pnlProfileManagement.ResumeLayout(false);
            this.pnlProfileManagement.PerformLayout();
            this.pnlConfiguration.ResumeLayout(false);
            this.pnlConfiguration.PerformLayout();
            this.pnlKeyboardOutput.ResumeLayout(false);
            this.pnlKeyboardOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudvJoyDeviceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontalActivationZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerticalActivationZone)).EndInit();
            this.pnlOutputType.ResumeLayout(false);
            this.pnlOutputType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlProfileManagement;
        private System.Windows.Forms.ListBox lbxProfilesList;
        private System.Windows.Forms.TextBox tboxProfileName;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Panel pnlConfiguration;
        private System.Windows.Forms.Panel pnlOutputType;
        private System.Windows.Forms.RadioButton rbtnKeyboardMode;
        private System.Windows.Forms.RadioButton rbtnvJoyMode;
        private System.Windows.Forms.ListBox lbxInputDevicesList;
        private System.Windows.Forms.ComboBox cbxInputR;
        private System.Windows.Forms.NumericUpDown nudHorizontalActivationZone;
        private System.Windows.Forms.NumericUpDown nudVerticalActivationZone;
        private System.Windows.Forms.ComboBox cbxInputN;
        private System.Windows.Forms.ComboBox cbxKeyboardOutputN;
        private System.Windows.Forms.ComboBox cbxKeyboardOutputR;
        private System.Windows.Forms.ComboBox cbxKeyboardOutput6;
        private System.Windows.Forms.ComboBox cbxKeyboardOutput5;
        private System.Windows.Forms.ComboBox cbxKeyboardOutput4;
        private System.Windows.Forms.ComboBox cbxKeyboardOutput3;
        private System.Windows.Forms.ComboBox cbxKeyboardOutput2;
        private System.Windows.Forms.NumericUpDown nudvJoyDeviceNumber;
        private System.Windows.Forms.Button btnDetectKeyboardOutputN;
        private System.Windows.Forms.Button btnDetectKeyboardOutputR;
        private System.Windows.Forms.Button btnDetectKeyboardOutput6;
        private System.Windows.Forms.Button btnDetectKeyboardOutput5;
        private System.Windows.Forms.Button btnDetectKeyboardOutput4;
        private System.Windows.Forms.Button btnDetectKeyboardOutput3;
        private System.Windows.Forms.Button btnDetectKeyboardOutput2;
        private System.Windows.Forms.Button btnDetectKeyboardOutput1;
        private System.Windows.Forms.Button btnDetectInputR;
        private System.Windows.Forms.Button btnDetectInputN;
        private System.Windows.Forms.Button btnUpdateDInputDevices;
        private System.Windows.Forms.Panel pnlKeyboardOutput;
        private System.Windows.Forms.CheckBox chkMappingMode;
        private System.Windows.Forms.ComboBox cbxKeyboardOutput1;
        private System.Windows.Forms.Label lblGearIndicator;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblControllerInputNeutral;
        private System.Windows.Forms.Label lblControllerInputReverse;
        private System.Windows.Forms.Label lblKeyboardOutput1;
        private System.Windows.Forms.Label lblKeyboardOutput2;
        private System.Windows.Forms.Label lblKeyboardOutput4;
        private System.Windows.Forms.Label lblKeyboardOutput3;
        private System.Windows.Forms.Label lblKeyboardOutputN;
        private System.Windows.Forms.Label lblKeyboardOutputR;
        private System.Windows.Forms.Label lblKeyboardOutput6;
        private System.Windows.Forms.Label lblKeyboardOutput5;
        private System.Windows.Forms.Label lblHorizontalActivationZone;
        private System.Windows.Forms.Label lblVerticalActivationZone;
        private System.Windows.Forms.Label lblInputDevicesList;
    }
}

