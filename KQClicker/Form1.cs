using KQClicker.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;

namespace KQClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwdata, int dwextrainfo);

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //global variables//

        //left mb clicker//
        public bool left_clicker_on = false;
        public bool left_toggle_on = false;
        public bool left_clicker_toggle = false;

        //left mb clicker//
        public bool right_clicker_on = false;
        public bool right_toggle_on = false;
        public bool right_clicker_toggle = false;

        public Form1()
        {
            InitializeComponent();
            bar.MouseDown += new System.Windows.Forms.MouseEventHandler(move_window);
        }

        //moving window with bar//
        private void move_window(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        //turn off on left clicker//
        private void left_clicker_b_click(object sender, EventArgs e)
        {
            //switch on/off left mb clicker//
            left_clicker_on = !left_clicker_on;
            
            //changing button style//
            if(left_clicker_on == true)
            {
                left_clicker_b.BackColor = Color.FromArgb(29, 143, 29);
                left_clicker_b.Text = "ENABLED";
            } else
            {
                left_clicker_b.BackColor = Color.FromArgb(140, 24, 24);
                left_clicker_b.Text = "DISABLED";
            }
        }

        //left clicker timer//
        bool left_can = true;
        private void LeftClicker_Tick(object sender, EventArgs e)
        {
            if(left_clicker_on == true)
            {
                Process[] proccess = Process.GetProcessesByName("javaw");
                foreach (Process process in proccess)
                {
                    if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                    {
                        Key left_key = KeyInterop.KeyFromVirtualKey((int)left_bind_key);
                        if(left_clicker_toggle == false)
                        {
                            if (Keyboard.IsKeyDown(left_key))
                                if (MouseButtons == MouseButtons.Left) left_toggle_on = true;
                            if (!(MouseButtons == MouseButtons.Left)) left_toggle_on = false;

                            if (left_toggle_on == true)
                            {
                                LeftClicker.Interval = 1000 / left_cps_trackBar.Value;
                                mouse_event(0x0002, MousePosition.X, MousePosition.Y, 0, 0);
                            }
                        } else
                        {
                            
                            if (Keyboard.IsKeyDown(left_key))
                                if (MouseButtons == MouseButtons.Left)
                                {
                                    if (left_can == true)
                                    {
                                        left_toggle_on = !left_toggle_on;
                                        left_can = false;
                                    }
                                }
                            if (Keyboard.IsKeyUp(left_key)) left_can = true;

                            if (left_toggle_on == true)
                            {
                                LeftClicker.Interval = 1000 / left_cps_trackBar.Value;
                                mouse_event(0x0002, MousePosition.X, MousePosition.Y, 0, 0);
                            }
                        }
                    }
                }
            }
        }
        
        //turn off on right clicker//
        private void right_clicker_b_Click_1(object sender, EventArgs e)
        {
            //switch on/off right mb clicker//
            right_clicker_on = !right_clicker_on;

            //changing button style//
            if (right_clicker_on == true)
            {
                right_clicker_b.BackColor = Color.FromArgb(29, 143, 29);
                right_clicker_b.Text = "ENABLED";
            }
            else
            {
                right_clicker_b.BackColor = Color.FromArgb(140, 24, 24);
                right_clicker_b.Text = "DISABLED";
            }
        }

        //right clicker timer//
        bool right_can = true;
        private void RightClicker_Tick(object sender, EventArgs e)
        {
            //if right mb clicker is on//
            if (right_clicker_on == true)
            {
                //get every proccess javaw//
                Process[] proccess = Process.GetProcessesByName("javaw");
                //check every proccess//
                foreach (Process process in proccess)
                {
                    //if current window is minecraft (javaw process)//
                    if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                    {
                        Key right_key = KeyInterop.KeyFromVirtualKey((int)right_bind_key);
                        if(right_clicker_toggle == false)
                        {
                            if (Keyboard.IsKeyDown(right_key))
                                if (MouseButtons == MouseButtons.Right) right_toggle_on = true;
                            if (!(MouseButtons == MouseButtons.Right)) right_toggle_on = false;

                            if (right_toggle_on == true)
                            {
                                //set interval//
                                RightClicker.Interval = 1000 / right_cps_trackBar.Value;
                                //start clicking//
                                mouse_event(0x0008, MousePosition.X, MousePosition.Y, 0, 0);
                            }
                        } else
                        {
                            if (Keyboard.IsKeyDown(right_key))
                                if (MouseButtons == MouseButtons.Right)
                                {
                                    if (right_can == true)
                                    {
                                        right_toggle_on = !right_toggle_on;
                                        right_can = false;
                                    }
                                }
                            if (Keyboard.IsKeyUp(right_key)) right_can = true;

                            if (right_toggle_on == true)
                            {
                                //set interval//
                                RightClicker.Interval = 1000 / right_cps_trackBar.Value;
                                //start clicking//
                                mouse_event(0x0008, MousePosition.X, MousePosition.Y, 0, 0);
                            }
                        }
                    }
                }
            }
        }

        //on app load//
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();

            //window bar//
            bar.BackColor = Color.FromArgb(37, 37, 37);
            app_title.ForeColor = Color.FromArgb(140, 24, 24);
            exit_b.BackColor = Color.Red;
            minimize_b.BackColor = Color.Orange;

            //left mb clicker panel//
            left_clicker_b.ForeColor = Color.FromArgb(24, 24, 24);
            left_clicker_b.BackColor = Color.Red;
            panel_left.BackColor = Color.FromArgb(24, 24, 24);
            cps_left.ForeColor = Color.FromArgb(140, 24, 24);
            title_left.ForeColor = Color.FromArgb(140, 24, 24);
            title_panel_left.BackColor = Color.FromArgb(33, 33, 33);
            bind_left.ForeColor = Color.FromArgb(24, 24, 24);
            left_clicker_b.BackColor = Color.FromArgb(140, 24, 24);
            bind_left.BackColor = Color.FromArgb(29, 143, 29);
            display_cps_left.ForeColor = Color.FromArgb(140, 24, 24);
            left_toggle.BackColor = Color.FromArgb(140, 24, 24);

            //right mb clicker panel//
            right_clicker_b.ForeColor = Color.FromArgb(24, 24, 24);
            right_clicker_b.BackColor = Color.Red;
            panel_right.BackColor = Color.FromArgb(24, 24, 24);
            cps_right.ForeColor = Color.FromArgb(140, 24, 24);
            display_cps_right.ForeColor = Color.FromArgb(140, 24, 24);
            title_right.ForeColor = Color.FromArgb(140, 24, 24);
            title_panel_right.BackColor = Color.FromArgb(33, 33, 33);
            bind_right.ForeColor = Color.FromArgb(24, 24, 24);
            right_clicker_b.BackColor = Color.FromArgb(140, 24, 24);
            bind_right.BackColor = Color.FromArgb(29, 143, 29);
            right_toggle.BackColor = Color.FromArgb(140, 24, 24);

            //app background//
            this.BackColor = Color.FromArgb(17, 17, 17);

            //start left mb clicker//
            LeftClicker.Enabled = true;
            LeftClicker.Start();

            //start right mb clicker//
            RightClicker.Enabled = true;
            RightClicker.Start();
        }

        //window exit button//
        private void exit_b_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //window minimize button//
        private void minimize_b_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //custom key bind//
        Keys left_bind_key = Keys.R;
        bool waiting_left_for_input = false;
        private void bind_left_Click(object sender, EventArgs e)
        {
            waiting_left_for_input = !waiting_left_for_input;
            if(waiting_left_for_input == true) bind_left.BackColor = Color.FromArgb(140, 24, 24);
            else bind_left.BackColor = Color.FromArgb(29, 143, 29);
        }

        private void bind_left_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (waiting_left_for_input == true)
            {
                left_bind_key = e.KeyData;
                Settings.Default.left_key_bind = left_bind_key.ToString();
                Settings.Default.Save();
                bind_left.Text = "BIND: " + left_bind_key.ToString() + "+LMB"; 
                bind_left.BackColor = Color.FromArgb(29, 143, 29);
                waiting_left_for_input = false;
            }
        }

        Keys right_bind_key = Keys.F;
        bool waiting_right_for_input = false;
        private void bind_right_Click(object sender, EventArgs e)
        {
            waiting_right_for_input = !waiting_right_for_input;
            if (waiting_right_for_input == true) bind_right.BackColor = Color.FromArgb(140, 24, 24);
            else bind_right.BackColor = Color.FromArgb(29, 143, 29);
        }

        private void bind_right_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (waiting_right_for_input == true)
            {
                right_bind_key = e.KeyData;
                Settings.Default.right_key_bind = right_bind_key.ToString();
                Settings.Default.Save();
                bind_right.Text = "BIND: " + right_bind_key.ToString() + "+LMB";
                bind_right.BackColor = Color.FromArgb(29, 143, 29);
                waiting_right_for_input = false;
            }
        }

        public void loadData()
        {
            try
            {
                right_bind_key = (Keys)Enum.Parse(typeof(Keys), Settings.Default.right_key_bind);
                bind_right.Text = "BIND: " + right_bind_key.ToString() + "+LMB";
                left_bind_key = (Keys)Enum.Parse(typeof(Keys), Settings.Default.left_key_bind);
                bind_left.Text = "BIND: " + left_bind_key.ToString() + "+LMB";

                left_cps_trackBar.Value = Settings.Default.left_cps;
                right_cps_trackBar.Value = Settings.Default.right_cps;
                display_cps_left.Text = left_cps_trackBar.Value.ToString();
                display_cps_right.Text = right_cps_trackBar.Value.ToString();

                left_clicker_toggle = Settings.Default.left_toggle;
                right_clicker_toggle = Settings.Default.right_toggle;
                if (left_clicker_toggle == true) left_toggle.Text = "TOGGLE";
                else left_toggle.Text = "HOLD";
                if (right_clicker_toggle == true) right_toggle.Text = "TOGGLE";
                else right_toggle.Text = "HOLD";
            } catch(Exception ex)
            {
                return;
            }

        }

        private void left_cps_trackBar_Scroll(object sender, EventArgs e)
        {
            display_cps_left.Text = left_cps_trackBar.Value.ToString();
            Settings.Default.left_cps = left_cps_trackBar.Value;
            Settings.Default.Save();
        }

        private void right_cps_trackBar_Scroll(object sender, EventArgs e)
        {
            display_cps_right.Text = right_cps_trackBar.Value.ToString();
            Settings.Default.right_cps = right_cps_trackBar.Value;
            Settings.Default.Save();
        }

        private void left_toggle_Click(object sender, EventArgs e)
        {
            left_clicker_toggle = !left_clicker_toggle;
            Settings.Default.left_toggle = left_clicker_toggle;
            Settings.Default.Save();
            if (left_clicker_toggle == true)
            {
                left_toggle.Text = "TOGGLE";
            } else
            {
                left_toggle.Text = "HOLD";
            }
        }

        private void right_toggle_Click(object sender, EventArgs e)
        {
            right_clicker_toggle = !right_clicker_toggle;
            Settings.Default.right_toggle = right_clicker_toggle;
            Settings.Default.Save();
            if (right_clicker_toggle == true)
            {
                right_toggle.Text = "TOGGLE";
            }
            else
            {
                right_toggle.Text = "HOLD";
            }
        }
    }
}