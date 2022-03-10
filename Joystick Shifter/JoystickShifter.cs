using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using SharpDX.DirectInput;
using vJoyInterfaceWrap;
using WindowsInput; //InputSimulator
using WindowsInput.Native; //vk database for InputSimulator

namespace Joystick_Shifter
{
    public partial class JoystickShifter : Form
    {
        //TODO: check all vJoy statuses before allowing to continue
        static public vJoy vJoyController = new vJoy();
        
        DirectInput directInput = new DirectInput();
        Joystick diJoystick;
        
        InputSimulator inputSimulator = new InputSimulator();

        List<string> inputName = new List<string>();
        List<string> inputGuid = new List<string>();
        string[] settings = new string[16];

        string[] gears = {"1", "2", "3", "4", "5", "6", "R", "N"}; //just a list of gears (for the purposes of simplifying R and N) for the gear indicator
        public JoystickShifter()
        {
            InitializeComponent();

            #region Initialise vJoy
            vJoyController = new vJoy();
            
            if (!vJoyController.vJoyEnabled())
            {
                rbtnvJoyMode.Enabled = false;
                rbtnvJoyMode.Text = "(vJoy isn't enabled)";
            }
            #endregion

            initialiseDInput(); //first initialisation of DInput; happens again on pressing Start button or Update button

            #region Initialise input/output buttons values
            //populate keyboard output comboboxes
            cbxKeyboardOutput1.DataSource = Enum.GetValues(typeof(VirtualKeyCode));
            cbxKeyboardOutput2.DataSource = Enum.GetValues(typeof(VirtualKeyCode));
            cbxKeyboardOutput3.DataSource = Enum.GetValues(typeof(VirtualKeyCode));
            cbxKeyboardOutput4.DataSource = Enum.GetValues(typeof(VirtualKeyCode));
            cbxKeyboardOutput5.DataSource = Enum.GetValues(typeof(VirtualKeyCode));
            cbxKeyboardOutput6.DataSource = Enum.GetValues(typeof(VirtualKeyCode));
            cbxKeyboardOutputR.DataSource = Enum.GetValues(typeof(VirtualKeyCode));
            cbxKeyboardOutputN.DataSource = Enum.GetValues(typeof(VirtualKeyCode));

            //set default values for keyboard output comboboxes
            cbxKeyboardOutput1.Text = Enum.GetName(typeof(VirtualKeyCode), VirtualKeyCode.NUMPAD1);
            cbxKeyboardOutput2.Text = Enum.GetName(typeof(VirtualKeyCode), VirtualKeyCode.NUMPAD2);
            cbxKeyboardOutput3.Text = Enum.GetName(typeof(VirtualKeyCode), VirtualKeyCode.NUMPAD3);
            cbxKeyboardOutput4.Text = Enum.GetName(typeof(VirtualKeyCode), VirtualKeyCode.NUMPAD4);
            cbxKeyboardOutput5.Text = Enum.GetName(typeof(VirtualKeyCode), VirtualKeyCode.NUMPAD5);
            cbxKeyboardOutput6.Text = Enum.GetName(typeof(VirtualKeyCode), VirtualKeyCode.NUMPAD6);
            cbxKeyboardOutputR.Text = Enum.GetName(typeof(VirtualKeyCode), VirtualKeyCode.NUMPAD7);
            cbxKeyboardOutputN.Text = Enum.GetName(typeof(VirtualKeyCode), VirtualKeyCode.NUMPAD8);

            //set default values for joystick input comboboxes
            cbxInputR.Text = "Button 1";
            cbxInputN.Text = "Button 2";
            #endregion

            #region Initialise list of profiles
            string[] profileFiles = Directory.GetFiles("profiles/");
            for (int i = 0; i < profileFiles.Length; i++)
            {
                string profileName = profileFiles[i];
                int directoryIndex = profileName.IndexOf("/");
                int extensionIndex = profileName.IndexOf(".txt");
                lbxProfilesList.Items.Add(profileName.Substring(directoryIndex + 1, extensionIndex - directoryIndex - 1));
            }
            #endregion
        }
        
        #region Initialise DInput
        private void initialiseDInput()
        {
            //clear everthing to create fresh lists
            lbxInputDevicesList.Items.Clear();
            inputName.Clear();
            inputGuid.Clear();

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
            {
                lbxInputDevicesList.Items.Add(deviceInstance.InstanceName + " (" + deviceInstance.InstanceGuid + ")");
                inputName.Add(deviceInstance.InstanceName);
                inputGuid.Add(deviceInstance.InstanceGuid.ToString());
            }
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Flight, DeviceEnumerationFlags.AllDevices))
            {
                lbxInputDevicesList.Items.Add(deviceInstance.InstanceName + " (" + deviceInstance.InstanceGuid + ")");
                inputName.Add(deviceInstance.InstanceName);
                inputGuid.Add(deviceInstance.InstanceGuid.ToString());
            }
            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                lbxInputDevicesList.Items.Add(deviceInstance.InstanceName + " (" + deviceInstance.InstanceGuid + ")");
                inputName.Add(deviceInstance.InstanceName);
                inputGuid.Add(deviceInstance.InstanceGuid.ToString());
            }
            if (lbxInputDevicesList.Items.Count > 0)
            {
                lbxInputDevicesList.SelectedIndex = 0;
                pnlConfiguration.Enabled = true;
            }
            else
                pnlConfiguration.Enabled = false;

        }
        private void btnUpdateDInputDevices_Click(object sender, EventArgs e)
        {
            initialiseDInput();
        }
        #endregion

        #region Profile handling
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            //TODO: only allow vJoy devices that are enabled to be selected as vJoy device; start saving controller name so that the user knows what controller was assigned
            //TODO start thinking about differect/optional save directory, migration, for when there are updates and such
            //TODO must clearly describe how vertical/horizontal activation zone is intrepreted
            
            //prevent saving if no input devices are connected
            if (inputGuid.Count == 0)
            {
                MessageBox.Show("No input devices are connected", "Can't save");
                return;
            }

            string profileFile = "profiles/" + tboxProfileName.Text + ".txt";
            if (!System.IO.Directory.Exists("profiles/"))
                System.IO.Directory.CreateDirectory("profiles");

            //prompt to overwrite if file already exists
            if (File.Exists(profileFile))
            {
                if (MessageBox.Show("Overwrite " + tboxProfileName.Text + "?", "Profile exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            //or else if file doesn't already exist, create new ProfilesList listbox entry
            else
            {
                lbxProfilesList.Items.Add(tboxProfileName.Text);
                btnDeleteProfile.Enabled = true;
            }

            File.WriteAllText(profileFile, nudvJoyDeviceNumber.Value + Environment.NewLine);
            if (rbtnvJoyMode.Checked)
                File.AppendAllText(profileFile, "vJoy" + Environment.NewLine);
            else if (rbtnKeyboardMode.Checked)
                File.AppendAllText(profileFile, "Keyboard" + Environment.NewLine);
            File.AppendAllText(profileFile, inputGuid[lbxInputDevicesList.SelectedIndex] + Environment.NewLine);
            
            File.AppendAllText(profileFile, cbxInputR.Text + Environment.NewLine);
            File.AppendAllText(profileFile, cbxInputN.Text + Environment.NewLine);
            File.AppendAllText(profileFile, nudVerticalActivationZone.Value + Environment.NewLine);
            File.AppendAllText(profileFile, nudHorizontalActivationZone.Value + Environment.NewLine);
            
            File.AppendAllText(profileFile, cbxKeyboardOutput1.Text + Environment.NewLine);
            File.AppendAllText(profileFile, cbxKeyboardOutput2.Text + Environment.NewLine);
            File.AppendAllText(profileFile, cbxKeyboardOutput3.Text + Environment.NewLine);
            File.AppendAllText(profileFile, cbxKeyboardOutput4.Text + Environment.NewLine);
            File.AppendAllText(profileFile, cbxKeyboardOutput5.Text + Environment.NewLine);
            File.AppendAllText(profileFile, cbxKeyboardOutput6.Text + Environment.NewLine);
            File.AppendAllText(profileFile, cbxKeyboardOutputR.Text + Environment.NewLine);
            File.AppendAllText(profileFile, cbxKeyboardOutputN.Text + Environment.NewLine);

            lbxProfilesList.SelectedItem = tboxProfileName.Text;
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete " + lbxProfilesList.SelectedItem + "?", "Delete profile?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {    
                File.Delete("profiles/" + lbxProfilesList.SelectedItem.ToString() + ".txt");
                
                //int nextSelectedIndex allows for the index being set appropriately after deletion from the listbox is done
                int nextSelectedIndex;
                if (lbxProfilesList.SelectedIndex == 0) //if first item, set first item
                    nextSelectedIndex = 0;
                else //if not first item, set previous item
                    nextSelectedIndex = lbxProfilesList.SelectedIndex - 1;
                lbxProfilesList.Items.Remove(lbxProfilesList.SelectedItem);
                if (lbxProfilesList.Items.Count != 0)
                {
                    lbxProfilesList.SelectedIndex = nextSelectedIndex;
                    tboxProfileName.Text = lbxProfilesList.SelectedItem.ToString();
                }
            }
        }

        //load profile settings
        private void lbxProfilesList_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if (lbxProfilesList.SelectedIndex == -1)
            {
                btnDeleteProfile.Enabled = false;
                btnStart.Enabled = false;
                tboxProfileName.Text = "";
            }
            else
            {               
                int index = 0;
                foreach (string line in File.ReadAllLines("profiles/" + lbxProfilesList.SelectedItem.ToString() + ".txt"))
                {
                    settings[index] = line;
                    index++;
                }

                nudvJoyDeviceNumber.Value = Int32.Parse(settings[0]);
                if (settings[1] == "Keyboard")
                    rbtnKeyboardMode.Checked = true;
                else if (settings[1] == "vJoy")
                    rbtnvJoyMode.Checked = true;

                cbxInputR.Text = settings[3];
                cbxInputN.Text = settings[4];

                nudVerticalActivationZone.Value = Int32.Parse(settings[5]);
                nudHorizontalActivationZone.Value = Int32.Parse(settings[6]);

                cbxKeyboardOutput1.Text = settings[7];
                cbxKeyboardOutput2.Text = settings[8];
                cbxKeyboardOutput3.Text = settings[9];
                cbxKeyboardOutput4.Text = settings[10];
                cbxKeyboardOutput5.Text = settings[11];
                cbxKeyboardOutput6.Text = settings[12];
                cbxKeyboardOutputR.Text = settings[13];
                cbxKeyboardOutputN.Text = settings[14];

                btnDeleteProfile.Enabled = true;
                btnStart.Enabled = true;
                tboxProfileName.Text = lbxProfilesList.SelectedItem.ToString();
            }
        }

        //disable or enable save button based on empty textbox
        private void tboxProfileName_TextChanged(object sender, EventArgs e)
        {
            if (tboxProfileName.Text == "")
                btnSaveProfile.Enabled = false;
            else
                btnSaveProfile.Enabled = true;
        }

        //disable or enable vJoy device number spin edit based on if vJoy mode
        private void rbtnvJoyMode_CheckedChanged(object sender, EventArgs e)
        {
            nudvJoyDeviceNumber.Enabled = rbtnvJoyMode.Checked;
        }

        private void rbtnKeyboardMode_CheckedChanged(object sender, EventArgs e)
        {
            pnlKeyboardOutput.Enabled = rbtnKeyboardMode.Checked;
        }

        #endregion

        #region Map keyboard output
        private VirtualKeyCode GetPressedKeyboardKey()
        {
            //TODO allow abortion?
            //TODO BUGWATCH vk 60 was being reported as soon as this was called. There isn't even a vk 60...a restart fixed the issue
            while (true)
            {
                for (int i = 1; i < 255; i++)
                    if (inputSimulator.InputDeviceState.IsHardwareKeyDown((VirtualKeyCode)i))
                        return (VirtualKeyCode)i;
            }
        }

        private void btnDetectKeyboardOutput1_Click(object sender, EventArgs e)
        {
            btnDetectKeyboardOutput1.Text = "Listening...";
            btnDetectKeyboardOutput1.Refresh();
            cbxKeyboardOutput1.Text = GetPressedKeyboardKey().ToString();
            btnDetectKeyboardOutput1.Text = "Detect";
        }

        private void btnDetectKeyboardOutput2_Click(object sender, EventArgs e)
        {
            btnDetectKeyboardOutput2.Text = "Listening...";
            btnDetectKeyboardOutput2.Refresh();
            cbxKeyboardOutput2.Text = GetPressedKeyboardKey().ToString();
            btnDetectKeyboardOutput2.Text = "Detect";
        }

        private void btnDetectKeyboardOutput3_Click(object sender, EventArgs e)
        {
            btnDetectKeyboardOutput3.Text = "Listening...";
            btnDetectKeyboardOutput3.Refresh();
            cbxKeyboardOutput3.Text = GetPressedKeyboardKey().ToString();
            btnDetectKeyboardOutput3.Text = "Detect";
        }

        private void btnDetectKeyboardOutput4_Click(object sender, EventArgs e)
        {
            btnDetectKeyboardOutput4.Text = "Listening...";
            btnDetectKeyboardOutput4.Refresh();
            cbxKeyboardOutput4.Text = GetPressedKeyboardKey().ToString();
            btnDetectKeyboardOutput4.Text = "Detect";
        }

        private void btnDetectKeyboardOutput5_Click(object sender, EventArgs e)
        {
            btnDetectKeyboardOutput5.Text = "Listening...";
            btnDetectKeyboardOutput5.Refresh();
            cbxKeyboardOutput5.Text = GetPressedKeyboardKey().ToString();
            btnDetectKeyboardOutput5.Text = "Detect";
        }

        private void btnDetectKeyboardOutput6_Click(object sender, EventArgs e)
        {
            btnDetectKeyboardOutput6.Text = "Listening...";
            btnDetectKeyboardOutput6.Refresh();
            cbxKeyboardOutput6.Text = GetPressedKeyboardKey().ToString();
            btnDetectKeyboardOutput6.Text = "Detect";
        }

        private void btnDetectKeyboardOutputR_Click(object sender, EventArgs e)
        {
            btnDetectKeyboardOutputR.Text = "Listening...";
            btnDetectKeyboardOutputR.Refresh();
            cbxKeyboardOutputR.Text = GetPressedKeyboardKey().ToString();
            btnDetectKeyboardOutputR.Text = "Detect";
        }

        private void btnDetectKeyboardOutputN_Click(object sender, EventArgs e)
        {
            btnDetectKeyboardOutputN.Text = "Listening...";
            btnDetectKeyboardOutputN.Refresh();
            cbxKeyboardOutputN.Text = GetPressedKeyboardKey().ToString();
            btnDetectKeyboardOutputN.Text = "Detect";
        }
        #endregion

        #region Map controller input
        private int GetPressedControllerKey()
        {
            diJoystick = new Joystick(directInput, new Guid(inputGuid[lbxInputDevicesList.SelectedIndex]));
            diJoystick.Acquire();
            while (true)
            {
                for (int i = 0; i < 128; i++)
                    if (diJoystick.GetCurrentState().Buttons[i] == true)
                        return i + 1;  //add 1 to account for indexing vs button number
            }
        }
        private void btnDetectInputR_Click(object sender, EventArgs e) //TODO BUGWATCH someone shows that program crashes when press input detect buttons
        {
            btnDetectInputR.Text = "Listening...";
            btnDetectInputR.Refresh();
            cbxInputR.Text = "Button " + GetPressedControllerKey().ToString();
            btnDetectInputR.Text = "Detect";
        }

        private void btnDetectInputN_Click(object sender, EventArgs e)
        {
            btnDetectInputN.Text = "Listening...";
            btnDetectInputN.Refresh();
            cbxInputN.Text = "Button " + GetPressedControllerKey().ToString();
            btnDetectInputN.Text = "Detect";
        }
        #endregion


        #region Feeding
        private void btnStart_Click(object sender, EventArgs e)
        {
            //TODO do all checks to see if vJoy or DInput devices are free to be acquired and whatever else
            //TODO mapping mode needs to be simpler to understand
            //TODO run with admin privileges?

            //potentially start feeding thread
            if (btnStart.Text == "Start")
            {
                initialiseDInput(); //initialise DInput again to check if dInput controller saved in config is actually connected right now
                if (inputGuid.Contains(settings[2])) //start feeding only if dInput controller saved in config is actually connected right now
                {
                    btnStart.Text = "Stop";
                    btnStart.Refresh();
                    pnlProfileManagement.Enabled = false;
                    lblGearIndicator.Visible = true;
                }
                else
                {
                    MessageBox.Show("Your saved controller is not connected", "Can't start");
                    return;
                }
            }
            //The feeding thread only runs so long as the button text is "Stop". If the text is "Stop", a click will turn it to "Start", so that the feeding thread stops.
            else if (btnStart.Text == "Stop")
            {
                btnStart.Text = "Start";
                btnStart.Refresh();
                selectGear(8);
                pnlProfileManagement.Enabled = true;
                lblGearIndicator.Visible = false;
                return;
            }

            diJoystick = new Joystick(directInput, new Guid(settings[2]));
            diJoystick.Acquire();
            if (settings[1] == "vJoy")
                vJoyController.AcquireVJD(uint.Parse(settings[0]));

            int vAZone = Int32.Parse(settings[5]); //vertical activation zone from settings
            int hAZone = Int32.Parse(settings[6]); //horizontal activation zone from settings
            const int hRange = 65535 / 100; //DInput range max value made into a hundredth, to be used as a percentage
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                //this thread will run until "Stop" is clicked
                while (btnStart.Text == "Stop")
                {
                    //check axes positions to ascertain desired gear
                    if ((diJoystick.GetCurrentState().X < hRange * (100 - hAZone)) && (diJoystick.GetCurrentState().Y < hRange * (100 - vAZone)))
                        selectGear(1);
                    if ((diJoystick.GetCurrentState().X < hRange * (100 - hAZone)) && (diJoystick.GetCurrentState().Y > hRange * (vAZone)))
                        selectGear(2);
                    if ((diJoystick.GetCurrentState().X > hRange * (100 - hAZone)) && (diJoystick.GetCurrentState().X < hRange * (hAZone)) && (diJoystick.GetCurrentState().Y < hRange * (100 - vAZone)))
                        selectGear(3);
                    if ((diJoystick.GetCurrentState().X > hRange * (100 - hAZone)) && (diJoystick.GetCurrentState().X < hRange * (hAZone)) && (diJoystick.GetCurrentState().Y > hRange * (vAZone)))
                        selectGear(4);
                    if ((diJoystick.GetCurrentState().X > hRange * (hAZone)) && (diJoystick.GetCurrentState().Y < hRange * (100 - vAZone)))
                        selectGear(5);
                    if ((diJoystick.GetCurrentState().X > hRange * (hAZone)) && (diJoystick.GetCurrentState().Y > hRange * (vAZone)))
                        selectGear(6);
                    //check button press to ascertain neutral or reverse
                    if (diJoystick.GetCurrentState().Buttons[Int32.Parse(settings[3].Substring(7, settings[3].Length - 7)) - 1])
                        selectGear(7); //reverse
                    if (diJoystick.GetCurrentState().Buttons[Int32.Parse(settings[4].Substring(7, settings[4].Length - 7)) - 1])
                        selectGear(8); //neutral
                }
            }).Start();
        }

        private void selectGear(uint gear) //uint gear 1-6, 7 is reverse, 8 is neutral
        {
            if (settings[1] == "vJoy")
            {
                //mapping mode
                if ((chkMappingMode.Checked) && (btnStart.Text == "Stop"))
                {
                    for (int i = 0; i < 3; i++) //beep 3 times
                    {
                        Console.Beep();
                        Thread.Sleep(200);
                    }
                    Console.Beep(1000, 100); //beep 4th time (pitch raised), just as key is to be pressed
                    //press key then release key
                    vJoyController.SetBtn(true, uint.Parse(settings[0]), gear);
                    Thread.Sleep(200);
                    vJoyController.SetBtn(false, uint.Parse(settings[0]), gear);
                    Console.Beep(500, 200); // beep 5th time (pitch lowered), just as key is released
                    return;
                }


                //release all gears but desired gear
                for (uint i = 1; i < 7; i++)
                    if (i != gear)
                        vJoyController.SetBtn(false, uint.Parse(settings[0]), i);

                //hold gear if desired gear is not neutral
                if (gear != 8)
                    vJoyController.SetBtn(true, uint.Parse(settings[0]), gear);
                //only _tap_ neutral if desired gear is neutral
                else if (gear == 8)
                {
                    vJoyController.SetBtn(true, uint.Parse(settings[0]), gear);
                    Thread.Sleep(150);
                    vJoyController.SetBtn(false, uint.Parse(settings[0]), gear);
                }
                lblGearIndicator.Invoke((MethodInvoker)(() => lblGearIndicator.Text = "Gear " + gears[gear - 1])); //show what gear is selected
            }

            else if (settings[1] == "Keyboard")
            {
                //mapping mode
                if ((chkMappingMode.Checked) && (btnStart.Text == "Stop"))
                {
                    for (int i = 0; i < 3; i++) //beep 3 times
                    {
                        Console.Beep();
                        Thread.Sleep(200);
                    }
                    Console.Beep(1000, 100); //beep 4th time (pitch raised), just as key is to be pressed
                    //press key then release key
                    inputSimulator.Keyboard.KeyDown((VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), settings[gear + 6]));
                    Thread.Sleep(150);
                    inputSimulator.Keyboard.KeyUp((VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), settings[gear + 6]));
                    Console.Beep(500, 200); // beep 5th time (pitch lowered), just as key is released
                    return;
                }


                //release all gears but desired gear
                for (int i = 1; i < 7; i++)
                    if (i != gear)
                        inputSimulator.Keyboard.KeyUp((VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), settings[i + 6]));

                Thread.Sleep(150); //sleep to prevent other programs from freezing
                //hold gear if desired gear is not neutral
                if (gear != 8)
                    inputSimulator.Keyboard.KeyDown((VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), settings[gear + 6]));
                //only _tap_ neutral if desired gear is neutral
                else if (gear == 8)
                {
                    inputSimulator.Keyboard.KeyDown((VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), settings[gear + 6]));
                    Thread.Sleep(150);
                    inputSimulator.Keyboard.KeyUp((VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), settings[gear + 6]));
                }
                lblGearIndicator.Invoke((MethodInvoker)(() => lblGearIndicator.Text = "Gear " + gears[gear - 1])); //show what gear is selected
            }   
        }
        #endregion

    }
}
