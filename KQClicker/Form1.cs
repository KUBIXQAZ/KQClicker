using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
        public bool left_type_const = true;
        public int left_ms;

        //left mb clicker//
        public bool right_clicker_on = false;
        public bool right_type_const = true;
        public int right_ms;

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
                left_clicker_b.BackColor = Color.Green;
                left_clicker_b.Text = "ENABLED";
            } else
            {
                left_clicker_b.BackColor = Color.Red;
                left_clicker_b.Text = "DISABLED";
            }
        }
        
        //left clicker timer//
        private void LeftClicker_Tick(object sender, EventArgs e)
        {
            if(left_clicker_on == true)
            {
                Process[] proccess = Process.GetProcessesByName("javaw");
                foreach (Process process in proccess)
                {
                    if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            if (int.Parse(cps_input_left.Text) <= 0) cps_input_left.Text = "1";
                            if (int.Parse(min_random_left.Text) >= int.Parse(max_random_left.Text)) max_random_left.Text = (int.Parse(min_random_left.Text) + 1).ToString();
                            if (int.Parse(max_random_left.Text) > 100) max_random_left.Text = "100";
                            if (left_type_const == false)
                            {
                                Random random = new Random();
                                int random_cps = random.Next(int.Parse(min_random_left.Text), int.Parse(max_random_left.Text) + 1);
                                left_ms = 1000 / random_cps;
                            }
                            else
                            {
                                left_ms = 1000 / int.Parse(cps_input_left.Text);
                            }
                            LeftClicker.Interval = left_ms;
                            mouse_event(0x0002, MousePosition.X, MousePosition.Y, 0, 0);
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
                right_clicker_b.BackColor = Color.Green;
                right_clicker_b.Text = "ENABLED";
            }
            else
            {
                right_clicker_b.BackColor = Color.Red;
                right_clicker_b.Text = "DISABLED";
            }
        }
        
        //right clicker timer//
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
                        //if right mb is clicked//
                        if (MouseButtons == MouseButtons.Right)
                        {
                            //max and min and cps inputs protection//
                            if (int.Parse(cps_input_right.Text) <= 0) cps_input_right.Text = "1";
                            if (int.Parse(min_random_right.Text) >= int.Parse(max_random_right.Text)) max_random_right.Text = (int.Parse(min_random_right.Text) + 1).ToString();
                            if (int.Parse(max_random_right.Text) > 100) max_random_right.Text = "100";
                            //calculating cps for clicker type//
                            if (right_type_const == false)
                            {
                                //for random//
                                Random random = new Random();
                                int random_cps = random.Next(int.Parse(min_random_right.Text), int.Parse(max_random_right.Text) + 1);
                                right_ms = 1000 / random_cps;
                            }
                            else
                            {
                                //for const//
                                right_ms = 1000 / int.Parse(cps_input_right.Text);
                            }
                            //set interval//
                            RightClicker.Interval = right_ms;
                            //start clicking//
                            mouse_event(0x0008, MousePosition.X, MousePosition.Y, 0, 0);
                        }
                    }
                }
            }
        }
        
        //on app load//
        private void Form1_Load(object sender, EventArgs e)
        {
            //window bar//
            bar.BackColor = Color.FromArgb(37, 37, 37);
            app_title.ForeColor = Color.FromArgb(255, 20, 20);
            exit_b.BackColor = Color.Red;
            minimize_b.BackColor = Color.Orange;

            //left mb clicker panel//
            left_clicker_b.ForeColor = Color.FromArgb(24, 24, 24);
            left_clicker_b.BackColor = Color.Red;
            panel_left.BackColor = Color.FromArgb(24, 24, 24);
            cps_input_left.BackColor = Color.FromArgb(24, 24, 24);
            cps_input_left.ForeColor = Color.FromArgb(255, 20, 20);
            min_random_left.BackColor = Color.FromArgb(24, 24, 24);
            min_random_left.ForeColor = Color.FromArgb(255, 20, 20);
            max_random_left.BackColor = Color.FromArgb(24, 24, 24);
            max_random_left.ForeColor = Color.FromArgb(255, 20, 20);
            cps_left.ForeColor = Color.FromArgb(255, 20, 20);
            title_left.ForeColor = Color.FromArgb(255, 20, 20);
            title_panel_left.BackColor = Color.FromArgb(33, 33, 33);
            left_type.BackColor = Color.Red;
            min_random_left.Enabled = false;
            max_random_left.Enabled = false;

            //right mb clicker panel//
            right_clicker_b.ForeColor = Color.FromArgb(24, 24, 24);
            right_clicker_b.BackColor = Color.Red;
            panel_right.BackColor = Color.FromArgb(24, 24, 24);
            cps_input_right.BackColor = Color.FromArgb(24, 24, 24);
            cps_input_right.ForeColor = Color.FromArgb(255, 20, 20);
            min_random_right.BackColor = Color.FromArgb(24, 24, 24);
            min_random_right.ForeColor = Color.FromArgb(255, 20, 20);
            max_random_right.BackColor = Color.FromArgb(24, 24, 24);
            max_random_right.ForeColor = Color.FromArgb(255, 20, 20);
            cps_right.ForeColor = Color.FromArgb(255, 20, 20);
            title_right.ForeColor = Color.FromArgb(255, 20, 20);
            title_panel_right.BackColor = Color.FromArgb(33, 33, 33);
            right_type.BackColor = Color.Red;
            min_random_right.Enabled = false;
            max_random_right.Enabled = false;

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

        //type of left mb clicker const or random//
        private void left_type_Click(object sender, EventArgs e)
        {
            left_type_const = !left_type_const;

            if(left_type_const == true)
            {
                left_type.Text = "CONST";
                min_random_left.Enabled = false;
                max_random_left.Enabled = false;
                cps_input_left.Enabled = true;
            } else
            {
                left_type.Text = "RANDOM";
                min_random_left.Enabled = true;
                max_random_left.Enabled = true;
                cps_input_left.Enabled = false;
            }
        }

        //type of right mb clicker const or random//
        private void right_type_Click(object sender, EventArgs e)
        {
           right_type_const = !right_type_const;

            if (right_type_const == true)
            {
                right_type.Text = "CONST";
                min_random_right.Enabled = false;
                max_random_right.Enabled = false;
                cps_input_right.Enabled = true;
            }
            else
            {
                right_type.Text = "RANDOM";
                min_random_right.Enabled = true;
                max_random_right.Enabled = true;
                cps_input_right.Enabled = false;
            }
        }

        //cps input left mb clicker protection//
        private void cps_input_left_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cps_input_left_Leave(object sender, EventArgs e)
        {
            if (int.Parse(cps_input_left.Text) <= 0) cps_input_left.Text = "1";
            if (int.Parse(cps_input_left.Text) > 100) cps_input_left.Text = "100";
        }

        //min random left mb clicker input protection//
        private void min_random_left_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void min_random_left_Leave(object sender, EventArgs e)
        {
            if (int.Parse(min_random_left.Text) <= 0) cps_input_left.Text = "1";
            if(int.Parse(min_random_left.Text) >= int.Parse(max_random_left.Text))
            {
                max_random_left.Text = (int.Parse(min_random_left.Text) + 1).ToString();
            }
        }

        //max random left mb clicker input protection//
        private void max_random_left_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void max_random_left_Leave(object sender, EventArgs e)
        {
            if (int.Parse(max_random_left.Text) > 100) max_random_left.Text = "100";
            if (int.Parse(max_random_left.Text) <= int.Parse(min_random_left.Text))
            {
                max_random_left.Text = (int.Parse(min_random_left.Text) + 1).ToString();
            }
        }
    }
}