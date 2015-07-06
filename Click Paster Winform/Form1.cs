using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Paster_WinForm
{
    public partial class Form1 : Form
    {
        #region Declare Variables
        //if program is 'recording' input
        bool recording = false;
        //lists with the cordinated of the mouse positon
        List<int> xloc = new List<int>();
        List<int> yloc = new List<int>();
        //List of the events that happen during playback
        List<string> playbackEvents = new List<string>();
        //Variable that is used to show what event is currently being done
        int currentevent = 0;
        //Variable that counts which position in the location of the
        int currentLocation = 0;
        //checks how many times its looped
        double looptimes = 0;
        #endregion
        #region Import Mouse
        //Imports the ability to click mouse
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        #endregion
        //My Methods
        #region Methods
        //Checks which event is next and what function to use
        void DoEvent(string cEvent)
        {
            //Checks if the current event is Click or Move Mouse
            if (cEvent == "Click")
            {
                DoMouseClick();
            }
            if (cEvent == "Move Mouse")
            {
                MoveMouse(currentLocation);
                currentLocation++;
            }
            if (cEvent == "Right Click")
            {
                DoRightMouseClick();
            }
            //Adds 1 to the amount of times looped
            looptimes++;
            label1.Text = Math.Floor(looptimes/playbackEvents.Count()).ToString();
            if (looptimes > Convert.ToInt32(looptimesBox.Text)*playbackEvents.Count())
            {
                loopBox.Checked = false;
                looptimes = 0;
                
            }
        }
        //Moves mouse to next location in array
        void MoveMouse(int cEvent)
        {
            Cursor.Position = new Point(xloc[cEvent], yloc[cEvent]);
        }
        //Click Mouse Method
        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
        //Right Click Mouse
        public void DoRightMouseClick()
        {
            //Call the imported function with the cursor's current position
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }
        #endregion
        //Checks if keys are pressed if the record timer is running
        #region CheckKeyPressed
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Q)
            {
                if (loopBox.Checked == true)
                {
                    loopBox.Checked = false;
                }
                else if (loopBox.Checked == false)
                {
                    loopBox.Checked = true;
                }
            }
            if (keyData == Keys.C && recording == true)
            {
                //Gets the mouse cursor location and puts them in a variable
                int X = Cursor.Position.X;
                int Y = Cursor.Position.Y;

                //Adds to the event list that it should click
                playbackEvents.Add("Click");

                //Adds the event to the textbox
                string eventadd = string.Format("\r\nClick Mouse at current Location");
                eventBox.AppendText(eventadd);
                return true;
            }
            if (keyData == Keys.M && recording == true)
            {
                //Gets the mouse cursor location and puts them in a variable
                int X = Cursor.Position.X;
                int Y = Cursor.Position.Y;

                //Adds to the event that it should move the mouse to the specified location
                playbackEvents.Add("Move Mouse");

                //Adds the cursor position to the cordinate arrays;
                xloc.Add(X);
                yloc.Add(Y);

                //Adds the event to the textbox
                string eventadd = string.Format("\r\nMove Mouse to ( {0},{1} )", X.ToString(), Y.ToString());
                eventBox.AppendText(eventadd);
                return true;
            }
            if (keyData == Keys.X && recording == true)
            {
                //Gets the mouse cursor location and puts them in a variable
                int X = Cursor.Position.X;
                int Y = Cursor.Position.Y;

                //Adds to the event list that it should click
                playbackEvents.Add("Right Click");

                //Adds the event to the textbox
                string eventadd = string.Format("\r\nRight Click Mouse at current Location");
                eventBox.AppendText(eventadd);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        //Button Click Events
        #region ButtonClick
        private void recordButton_Click(object sender, EventArgs e)
        {
            recording = true;
            //Resets lists
            xloc.Clear();
            yloc.Clear();
            playbackEvents.Clear();
            eventBox.Text = "EVENTS:";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playTimer.Start();
            if (intervalBox.Text != "")
            {
                playTimer.Interval = Convert.ToInt32(intervalBox.Text);
            }
            looptimes = 0;
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            //Stops both timers (play & record)
            recording = false;
            playTimer.Stop();
            //Resets the variables
            currentevent = 0;
            currentLocation = 0;
        }
        #endregion
        //Timers
        #region Timers
        private void playTimer_Tick(object sender, EventArgs e)
        {
            
            //Checks if the currentevent is larger then the list/array of events
            if (currentevent >= playbackEvents.Count())
            {
                currentLocation = 0;
                currentevent = 0;
                if (loopBox.Checked == false)
                {
                    playTimer.Stop();
                }
            }
            else
            {
                //Does the next action in the event list
                DoEvent(playbackEvents[currentevent]);

                //Moves to the next event
                currentevent++;
            }
            
        }
        #endregion
    }
}
