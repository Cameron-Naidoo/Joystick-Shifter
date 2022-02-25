
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
            this.btnDetectKeyboardOutputN = new System.Windows.Forms.Button();
            this.btnDetectKeyboardOutputR = new System.Windows.Forms.Button();
            this.btnDetectKeyboardOutput6 = new System.Windows.Forms.Button();
            this.btnDetectKeyboardOutput5 = new System.Windows.Forms.Button();
            this.btnDetectKeyboardOutput4 = new System.Windows.Forms.Button();
            this.btnDetectKeyboardOutput3 = new System.Windows.Forms.Button();
            this.btnDetectKeyboardOutput2 = new System.Windows.Forms.Button();
            this.btnDetectKeyboardOutput1 = new System.Windows.Forms.Button();
            this.nudvJoyDeviceNumber = new System.Windows.Forms.NumericUpDown();
            this.cbxKeyboardOutputN = new System.Windows.Forms.ComboBox();
            this.cbxKeyboardOutputR = new System.Windows.Forms.ComboBox();
            this.cbxKeyboardOutput6 = new System.Windows.Forms.ComboBox();
            this.cbxKeyboardOutput5 = new System.Windows.Forms.ComboBox();
            this.cbxKeyboardOutput4 = new System.Windows.Forms.ComboBox();
            this.cbxKeyboardOutput3 = new System.Windows.Forms.ComboBox();
            this.cbxKeyboardOutput2 = new System.Windows.Forms.ComboBox();
            this.cbxKeyboardOutput1 = new System.Windows.Forms.ComboBox();
            this.nudHorizontalActivationZone = new System.Windows.Forms.NumericUpDown();
            this.nudVerticalActivationZone = new System.Windows.Forms.NumericUpDown();
            this.cbxInputN = new System.Windows.Forms.ComboBox();
            this.cbxInputR = new System.Windows.Forms.ComboBox();
            this.lbxInputDevicesList = new System.Windows.Forms.ListBox();
            this.pnlOutputType = new System.Windows.Forms.Panel();
            this.rbtnKeyboardMode = new System.Windows.Forms.RadioButton();
            this.rbtnvJoyMode = new System.Windows.Forms.RadioButton();
            this.btnDetectInputR = new System.Windows.Forms.Button();
            this.btnDetectInputN = new System.Windows.Forms.Button();
            this.btnUpdateDInputDevices = new System.Windows.Forms.Button();
            this.pnlProfileManagement.SuspendLayout();
            this.pnlConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudvJoyDeviceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontalActivationZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerticalActivationZone)).BeginInit();
            this.pnlOutputType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(30, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlProfileManagement
            // 
            this.pnlProfileManagement.Controls.Add(this.lbxProfilesList);
            this.pnlProfileManagement.Controls.Add(this.tboxProfileName);
            this.pnlProfileManagement.Controls.Add(this.btnDeleteProfile);
            this.pnlProfileManagement.Controls.Add(this.btnSaveProfile);
            this.pnlProfileManagement.Location = new System.Drawing.Point(30, 55);
            this.pnlProfileManagement.Name = "pnlProfileManagement";
            this.pnlProfileManagement.Size = new System.Drawing.Size(211, 255);
            this.pnlProfileManagement.TabIndex = 1;
            // 
            // lbxProfilesList
            // 
            this.lbxProfilesList.FormattingEnabled = true;
            this.lbxProfilesList.Location = new System.Drawing.Point(0, 71);
            this.lbxProfilesList.Name = "lbxProfilesList";
            this.lbxProfilesList.Size = new System.Drawing.Size(120, 95);
            this.lbxProfilesList.TabIndex = 2;
            this.lbxProfilesList.SelectedIndexChanged += new System.EventHandler(this.lbxProfilesList_SelectedIndexChanged);
            // 
            // tboxProfileName
            // 
            this.tboxProfileName.Location = new System.Drawing.Point(0, 45);
            this.tboxProfileName.Name = "tboxProfileName";
            this.tboxProfileName.Size = new System.Drawing.Size(100, 20);
            this.tboxProfileName.TabIndex = 2;
            this.tboxProfileName.Text = "profilename";
            this.tboxProfileName.TextChanged += new System.EventHandler(this.tboxProfileName_TextChanged);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Enabled = false;
            this.btnDeleteProfile.Location = new System.Drawing.Point(81, 0);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProfile.TabIndex = 2;
            this.btnDeleteProfile.Text = "Delete";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(0, 0);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProfile.TabIndex = 2;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // pnlConfiguration
            // 
            this.pnlConfiguration.Controls.Add(this.btnUpdateDInputDevices);
            this.pnlConfiguration.Controls.Add(this.btnDetectKeyboardOutputN);
            this.pnlConfiguration.Controls.Add(this.btnDetectKeyboardOutputR);
            this.pnlConfiguration.Controls.Add(this.btnDetectKeyboardOutput6);
            this.pnlConfiguration.Controls.Add(this.btnDetectKeyboardOutput5);
            this.pnlConfiguration.Controls.Add(this.btnDetectKeyboardOutput4);
            this.pnlConfiguration.Controls.Add(this.btnDetectKeyboardOutput3);
            this.pnlConfiguration.Controls.Add(this.btnDetectKeyboardOutput2);
            this.pnlConfiguration.Controls.Add(this.btnDetectKeyboardOutput1);
            this.pnlConfiguration.Controls.Add(this.nudvJoyDeviceNumber);
            this.pnlConfiguration.Controls.Add(this.cbxKeyboardOutputN);
            this.pnlConfiguration.Controls.Add(this.cbxKeyboardOutputR);
            this.pnlConfiguration.Controls.Add(this.cbxKeyboardOutput6);
            this.pnlConfiguration.Controls.Add(this.cbxKeyboardOutput5);
            this.pnlConfiguration.Controls.Add(this.cbxKeyboardOutput4);
            this.pnlConfiguration.Controls.Add(this.cbxKeyboardOutput3);
            this.pnlConfiguration.Controls.Add(this.cbxKeyboardOutput2);
            this.pnlConfiguration.Controls.Add(this.cbxKeyboardOutput1);
            this.pnlConfiguration.Controls.Add(this.nudHorizontalActivationZone);
            this.pnlConfiguration.Controls.Add(this.nudVerticalActivationZone);
            this.pnlConfiguration.Controls.Add(this.cbxInputN);
            this.pnlConfiguration.Controls.Add(this.cbxInputR);
            this.pnlConfiguration.Controls.Add(this.lbxInputDevicesList);
            this.pnlConfiguration.Controls.Add(this.pnlOutputType);
            this.pnlConfiguration.Location = new System.Drawing.Point(400, 12);
            this.pnlConfiguration.Name = "pnlConfiguration";
            this.pnlConfiguration.Size = new System.Drawing.Size(388, 434);
            this.pnlConfiguration.TabIndex = 2;
            // 
            // btnDetectKeyboardOutputN
            // 
            this.btnDetectKeyboardOutputN.Location = new System.Drawing.Point(173, 391);
            this.btnDetectKeyboardOutputN.Name = "btnDetectKeyboardOutputN";
            this.btnDetectKeyboardOutputN.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutputN.TabIndex = 23;
            this.btnDetectKeyboardOutputN.Text = "Detect";
            this.btnDetectKeyboardOutputN.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutputN.Click += new System.EventHandler(this.btnDetectKeyboardOutputN_Click);
            // 
            // btnDetectKeyboardOutputR
            // 
            this.btnDetectKeyboardOutputR.Location = new System.Drawing.Point(173, 348);
            this.btnDetectKeyboardOutputR.Name = "btnDetectKeyboardOutputR";
            this.btnDetectKeyboardOutputR.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutputR.TabIndex = 22;
            this.btnDetectKeyboardOutputR.Text = "Detect";
            this.btnDetectKeyboardOutputR.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutputR.Click += new System.EventHandler(this.btnDetectKeyboardOutputR_Click);
            // 
            // btnDetectKeyboardOutput6
            // 
            this.btnDetectKeyboardOutput6.Location = new System.Drawing.Point(173, 312);
            this.btnDetectKeyboardOutput6.Name = "btnDetectKeyboardOutput6";
            this.btnDetectKeyboardOutput6.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput6.TabIndex = 21;
            this.btnDetectKeyboardOutput6.Text = "Detect";
            this.btnDetectKeyboardOutput6.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput6.Click += new System.EventHandler(this.btnDetectKeyboardOutput6_Click);
            // 
            // btnDetectKeyboardOutput5
            // 
            this.btnDetectKeyboardOutput5.Location = new System.Drawing.Point(173, 277);
            this.btnDetectKeyboardOutput5.Name = "btnDetectKeyboardOutput5";
            this.btnDetectKeyboardOutput5.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput5.TabIndex = 20;
            this.btnDetectKeyboardOutput5.Text = "Detect";
            this.btnDetectKeyboardOutput5.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput5.Click += new System.EventHandler(this.btnDetectKeyboardOutput5_Click);
            // 
            // btnDetectKeyboardOutput4
            // 
            this.btnDetectKeyboardOutput4.Location = new System.Drawing.Point(173, 248);
            this.btnDetectKeyboardOutput4.Name = "btnDetectKeyboardOutput4";
            this.btnDetectKeyboardOutput4.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput4.TabIndex = 19;
            this.btnDetectKeyboardOutput4.Text = "Detect";
            this.btnDetectKeyboardOutput4.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput4.Click += new System.EventHandler(this.btnDetectKeyboardOutput4_Click);
            // 
            // btnDetectKeyboardOutput3
            // 
            this.btnDetectKeyboardOutput3.Location = new System.Drawing.Point(173, 205);
            this.btnDetectKeyboardOutput3.Name = "btnDetectKeyboardOutput3";
            this.btnDetectKeyboardOutput3.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput3.TabIndex = 18;
            this.btnDetectKeyboardOutput3.Text = "Detect";
            this.btnDetectKeyboardOutput3.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput3.Click += new System.EventHandler(this.btnDetectKeyboardOutput3_Click);
            // 
            // btnDetectKeyboardOutput2
            // 
            this.btnDetectKeyboardOutput2.Location = new System.Drawing.Point(173, 171);
            this.btnDetectKeyboardOutput2.Name = "btnDetectKeyboardOutput2";
            this.btnDetectKeyboardOutput2.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput2.TabIndex = 17;
            this.btnDetectKeyboardOutput2.Text = "Detect";
            this.btnDetectKeyboardOutput2.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput2.Click += new System.EventHandler(this.btnDetectKeyboardOutput2_Click);
            // 
            // btnDetectKeyboardOutput1
            // 
            this.btnDetectKeyboardOutput1.Location = new System.Drawing.Point(173, 132);
            this.btnDetectKeyboardOutput1.Name = "btnDetectKeyboardOutput1";
            this.btnDetectKeyboardOutput1.Size = new System.Drawing.Size(75, 23);
            this.btnDetectKeyboardOutput1.TabIndex = 16;
            this.btnDetectKeyboardOutput1.Text = "Detect";
            this.btnDetectKeyboardOutput1.UseVisualStyleBackColor = true;
            this.btnDetectKeyboardOutput1.Click += new System.EventHandler(this.btnDetectKeyboardOutput1_Click);
            // 
            // nudvJoyDeviceNumber
            // 
            this.nudvJoyDeviceNumber.Enabled = false;
            this.nudvJoyDeviceNumber.Location = new System.Drawing.Point(19, 20);
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
            // cbxKeyboardOutputN
            // 
            this.cbxKeyboardOutputN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutputN.FormattingEnabled = true;
            this.cbxKeyboardOutputN.Location = new System.Drawing.Point(254, 393);
            this.cbxKeyboardOutputN.Name = "cbxKeyboardOutputN";
            this.cbxKeyboardOutputN.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutputN.TabIndex = 14;
            // 
            // cbxKeyboardOutputR
            // 
            this.cbxKeyboardOutputR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutputR.FormattingEnabled = true;
            this.cbxKeyboardOutputR.Location = new System.Drawing.Point(254, 350);
            this.cbxKeyboardOutputR.Name = "cbxKeyboardOutputR";
            this.cbxKeyboardOutputR.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutputR.TabIndex = 13;
            // 
            // cbxKeyboardOutput6
            // 
            this.cbxKeyboardOutput6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput6.FormattingEnabled = true;
            this.cbxKeyboardOutput6.Location = new System.Drawing.Point(254, 314);
            this.cbxKeyboardOutput6.Name = "cbxKeyboardOutput6";
            this.cbxKeyboardOutput6.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput6.TabIndex = 12;
            // 
            // cbxKeyboardOutput5
            // 
            this.cbxKeyboardOutput5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput5.FormattingEnabled = true;
            this.cbxKeyboardOutput5.Location = new System.Drawing.Point(254, 277);
            this.cbxKeyboardOutput5.Name = "cbxKeyboardOutput5";
            this.cbxKeyboardOutput5.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput5.TabIndex = 11;
            // 
            // cbxKeyboardOutput4
            // 
            this.cbxKeyboardOutput4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput4.FormattingEnabled = true;
            this.cbxKeyboardOutput4.Location = new System.Drawing.Point(254, 250);
            this.cbxKeyboardOutput4.Name = "cbxKeyboardOutput4";
            this.cbxKeyboardOutput4.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput4.TabIndex = 10;
            // 
            // cbxKeyboardOutput3
            // 
            this.cbxKeyboardOutput3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput3.FormattingEnabled = true;
            this.cbxKeyboardOutput3.Location = new System.Drawing.Point(254, 207);
            this.cbxKeyboardOutput3.Name = "cbxKeyboardOutput3";
            this.cbxKeyboardOutput3.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput3.TabIndex = 9;
            // 
            // cbxKeyboardOutput2
            // 
            this.cbxKeyboardOutput2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput2.FormattingEnabled = true;
            this.cbxKeyboardOutput2.Location = new System.Drawing.Point(254, 171);
            this.cbxKeyboardOutput2.Name = "cbxKeyboardOutput2";
            this.cbxKeyboardOutput2.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput2.TabIndex = 8;
            // 
            // cbxKeyboardOutput1
            // 
            this.cbxKeyboardOutput1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKeyboardOutput1.FormattingEnabled = true;
            this.cbxKeyboardOutput1.Location = new System.Drawing.Point(254, 132);
            this.cbxKeyboardOutput1.Name = "cbxKeyboardOutput1";
            this.cbxKeyboardOutput1.Size = new System.Drawing.Size(121, 21);
            this.cbxKeyboardOutput1.TabIndex = 7;
            // 
            // nudHorizontalActivationZone
            // 
            this.nudHorizontalActivationZone.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHorizontalActivationZone.Location = new System.Drawing.Point(19, 261);
            this.nudHorizontalActivationZone.Name = "nudHorizontalActivationZone";
            this.nudHorizontalActivationZone.Size = new System.Drawing.Size(120, 20);
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
            this.nudVerticalActivationZone.Location = new System.Drawing.Point(18, 226);
            this.nudVerticalActivationZone.Name = "nudVerticalActivationZone";
            this.nudVerticalActivationZone.Size = new System.Drawing.Size(120, 20);
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
            this.cbxInputN.Location = new System.Drawing.Point(18, 171);
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
            this.cbxInputR.Location = new System.Drawing.Point(18, 132);
            this.cbxInputR.Name = "cbxInputR";
            this.cbxInputR.Size = new System.Drawing.Size(121, 21);
            this.cbxInputR.TabIndex = 2;
            // 
            // lbxInputDevicesList
            // 
            this.lbxInputDevicesList.FormattingEnabled = true;
            this.lbxInputDevicesList.Location = new System.Drawing.Point(156, 31);
            this.lbxInputDevicesList.MultiColumn = true;
            this.lbxInputDevicesList.Name = "lbxInputDevicesList";
            this.lbxInputDevicesList.Size = new System.Drawing.Size(219, 95);
            this.lbxInputDevicesList.TabIndex = 1;
            // 
            // pnlOutputType
            // 
            this.pnlOutputType.Controls.Add(this.rbtnKeyboardMode);
            this.pnlOutputType.Controls.Add(this.rbtnvJoyMode);
            this.pnlOutputType.Location = new System.Drawing.Point(15, 43);
            this.pnlOutputType.Name = "pnlOutputType";
            this.pnlOutputType.Size = new System.Drawing.Size(135, 49);
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
            // btnDetectInputR
            // 
            this.btnDetectInputR.Location = new System.Drawing.Point(337, 142);
            this.btnDetectInputR.Name = "btnDetectInputR";
            this.btnDetectInputR.Size = new System.Drawing.Size(75, 23);
            this.btnDetectInputR.TabIndex = 3;
            this.btnDetectInputR.Text = "Detect";
            this.btnDetectInputR.UseVisualStyleBackColor = true;
            this.btnDetectInputR.Click += new System.EventHandler(this.btnDetectInputR_Click);
            // 
            // btnDetectInputN
            // 
            this.btnDetectInputN.Location = new System.Drawing.Point(337, 183);
            this.btnDetectInputN.Name = "btnDetectInputN";
            this.btnDetectInputN.Size = new System.Drawing.Size(75, 23);
            this.btnDetectInputN.TabIndex = 3;
            this.btnDetectInputN.Text = "Detect";
            this.btnDetectInputN.UseVisualStyleBackColor = true;
            this.btnDetectInputN.Click += new System.EventHandler(this.btnDetectInputN_Click);
            // 
            // btnUpdateDInputDevices
            // 
            this.btnUpdateDInputDevices.Location = new System.Drawing.Point(300, 3);
            this.btnUpdateDInputDevices.Name = "btnUpdateDInputDevices";
            this.btnUpdateDInputDevices.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDInputDevices.TabIndex = 4;
            this.btnUpdateDInputDevices.Text = "Update";
            this.btnUpdateDInputDevices.UseVisualStyleBackColor = true;
            this.btnUpdateDInputDevices.Click += new System.EventHandler(this.btnUpdateDInputDevices_Click);
            // 
            // JoystickShifter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetectInputN);
            this.Controls.Add(this.btnDetectInputR);
            this.Controls.Add(this.pnlConfiguration);
            this.Controls.Add(this.pnlProfileManagement);
            this.Controls.Add(this.btnStart);
            this.Name = "JoystickShifter";
            this.Text = "Joystick Shifter";
            this.pnlProfileManagement.ResumeLayout(false);
            this.pnlProfileManagement.PerformLayout();
            this.pnlConfiguration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudvJoyDeviceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontalActivationZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerticalActivationZone)).EndInit();
            this.pnlOutputType.ResumeLayout(false);
            this.pnlOutputType.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cbxKeyboardOutput1;
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
    }
}

