using KQClicker.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
        public int left_delay = 20;
        public bool auto_on_left = false;

        //left mb clicker//
        public bool right_clicker_on = false;
        public bool right_toggle_on = false;
        public bool right_clicker_toggle = false;
        public int right_delay = 20;
        public bool auto_on_right = false;

        public Form1()
        {
            InitializeComponent();
            bar.MouseDown += new System.Windows.Forms.MouseEventHandler(move_window);
            app_title.MouseDown += new System.Windows.Forms.MouseEventHandler(move_window);
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
                left_clicker_b.BackColor = Color.FromArgb(4, 27, 41);
                left_clicker_b.Text = "ENABLED";
            } else
            {
                left_clicker_b.BackColor = Color.FromArgb(0, 20, 45);
                left_clicker_b.Text = "DISABLED";
            }
        }

        public async Task left_click()
        {
            await Task.Delay(left_delay);
            LeftClicker.Interval = 1000 / left_cps_trackBar.Value;
            mouse_event(0x0002, MousePosition.X, MousePosition.Y, 0, 0);
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
                        Key left_key = KeyInterop.KeyFromVirtualKey((int)left_bind_key);
                        if(left_clicker_toggle == false)
                        {
                            if (Keyboard.IsKeyDown(left_key))
                                if (MouseButtons == MouseButtons.Left) left_toggle_on = true;
                            if (!(MouseButtons == MouseButtons.Left)) left_toggle_on = false;

                            if (left_toggle_on == true)
                            {
                                left_click();
                            }
                        } else
                        {
                            bool left_can = true;
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
                right_clicker_b.BackColor = Color.FromArgb(4, 27, 41);
                right_clicker_b.Text = "ENABLED";
            }
            else
            {
                right_clicker_b.BackColor = Color.FromArgb(0, 20, 45);
                right_clicker_b.Text = "DISABLED";
            }
        }

        public async Task right_click()
        {
            await Task.Delay(right_delay);
            //set interval//
            RightClicker.Interval = 1000 / right_cps_trackBar.Value;
            //start clicking//
            mouse_event(0x0008, MousePosition.X, MousePosition.Y, 0, 0);
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
                    //if current window is minecraft (javaw process)
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
                                right_click();
                            }
                        } else
                        {
                            bool right_can = true;
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
            //window bar//
            bar.BackColor = Color.FromArgb(0, 12, 20);
            app_title.ForeColor = Color.FromArgb(36, 112, 171);
            exit_b.BackColor = Color.Red;
            minimize_b.BackColor = Color.Orange;

            //left mb clicker panel//
            //left title bar//
            title_left.ForeColor = Color.FromArgb(36, 112, 171);
            title_panel_left.BackColor = Color.FromArgb(0, 12, 20);
            //left clicker panel
            panel_left.BackColor = Color.FromArgb(0, 8, 13);
            //turn on off left clicker
            left_clicker_b.ForeColor = Color.FromArgb(36, 112, 171);
            left_clicker_b.BackColor = Color.FromArgb(0, 20, 45);
            //cps text left clicker
            cps_left.ForeColor = Color.FromArgb(36, 112, 171);
            //bind button left clicker
            bind_left.ForeColor = Color.FromArgb(36, 112, 171);
            bind_left.BackColor = Color.FromArgb(4, 27, 41);
            //display cps text left clicker
            display_cps_left.ForeColor = Color.FromArgb(36, 112, 171);
            //toggle hold button
            left_toggle.BackColor = Color.FromArgb(4, 27, 41);
            left_toggle.ForeColor = Color.FromArgb(36, 112, 171);

            //right mb clicker panel//
            //right title bar
            title_right.ForeColor = Color.FromArgb(36, 112, 171);
            title_panel_right.BackColor = Color.FromArgb(0, 12, 20);
            //right clicker panel
            panel_right.BackColor = Color.FromArgb(0, 8, 13);
            //turn on off right clicker 
            right_clicker_b.ForeColor = Color.FromArgb(36, 112, 171);
            right_clicker_b.BackColor = Color.FromArgb(0, 20, 45);
            //cps text right clicker
            cps_right.ForeColor = Color.FromArgb(36, 112, 171);
            //bind button right clicker
            bind_right.ForeColor = Color.FromArgb(36, 112, 171);
            bind_right.BackColor = Color.FromArgb(4, 27, 41);
            //display cps text right button
            display_cps_right.ForeColor = Color.FromArgb(36, 112, 171);
            //toggle hold button
            right_toggle.BackColor = Color.FromArgb(4, 27, 41);
            right_toggle.ForeColor = Color.FromArgb(36, 112, 171);

            //conf button//
            conf_clicker.BackColor = Color.FromArgb(4, 27, 41);
            conf_clicker.ForeColor = Color.FromArgb(36, 112, 171);
            //simple panel//
            panel_simple.BackColor = Color.FromArgb(0, 6, 10);
            //advanced panel//
            title_advanced.ForeColor = Color.FromArgb(36, 112, 171);
            title_panel_advanced.BackColor = Color.FromArgb(0, 12, 20);
            panel_advanced.BackColor = Color.FromArgb(0, 8, 13);
            conf_panel.BackColor = Color.FromArgb(0, 6, 10);
            advanced_settings_title_1.ForeColor = Color.FromArgb(36, 112, 171);
            advanced_settings_title_2.ForeColor = Color.FromArgb(36, 112, 171);
            advanced1_left_text.ForeColor = Color.FromArgb(36, 112, 171);
            advanced1_right_text.ForeColor = Color.FromArgb(36, 112, 171);
            advanced2_left_text.ForeColor = Color.FromArgb(36, 112, 171);
            advanced2_right_text.ForeColor = Color.FromArgb(36, 112, 171);
            auto_turnonoff_clicker_b_r.ForeColor = Color.FromArgb(36, 112, 171);
            auto_turnonoff_clicker_b_l.ForeColor = Color.FromArgb(36, 112, 171);
            left_delay_input.BackColor = Color.FromArgb(4, 27, 41);
            left_delay_input.ForeColor = Color.FromArgb(36, 112, 171);
            right_delay_input.BackColor = Color.FromArgb(4, 27, 41);
            right_delay_input.ForeColor = Color.FromArgb(36, 112, 171);

            //app background//
            this.BackColor = Color.FromArgb(0, 6, 10);

            //start left mb clicker//
            LeftClicker.Enabled = true;
            LeftClicker.Start();

            //start right mb clicker//
            RightClicker.Enabled = true;
            RightClicker.Start();

            if (open == true)
            {
                conf_panel.Enabled = true;
                conf_panel.Visible = true;
            }
            else
            {
                conf_panel.Enabled = false;
                conf_panel.Visible = false;
            }

            if (auto_on_right == true)
            {
                auto_turnonoff_clicker_b_r.Text = "ENABLED";
                auto_turnonoff_clicker_b_r.BackColor = Color.FromArgb(4, 27, 41);
            }
            else
            {
                auto_turnonoff_clicker_b_r.Text = "DISABLED";
                auto_turnonoff_clicker_b_r.BackColor = Color.FromArgb(0, 20, 45);
            }

            if (auto_on_left == true)
            {
                auto_turnonoff_clicker_b_l.Text = "ENABLED";
                auto_turnonoff_clicker_b_l.BackColor = Color.FromArgb(4, 27, 41);
            }
            else
            {
                auto_turnonoff_clicker_b_l.Text = "DISABLED";
                auto_turnonoff_clicker_b_l.BackColor = Color.FromArgb(0, 20, 45);
            }
            loadData();
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
            if (waiting_left_for_input == true)
            {
                bind_left.BackColor = Color.FromArgb(0, 20, 45);
                bind_left.Text = "...+LMB"; 
            }
            else
            {
                bind_left.BackColor = Color.FromArgb(4, 27, 41);
                bind_left.Text = "BIND: " + left_bind_key.ToString() + "+LMB";
            }
        }

        private void bind_left_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (waiting_left_for_input == true)
            {
                left_bind_key = e.KeyData;
                Settings.Default.left_key_bind = left_bind_key.ToString();
                Settings.Default.Save();
                bind_left.Text = "BIND: " + left_bind_key.ToString() + "+LMB"; 
                bind_left.BackColor = Color.FromArgb(4, 27, 41);
                waiting_left_for_input = false;
            }
        }

        Keys right_bind_key = Keys.F;
        bool waiting_right_for_input = false;
        private void bind_right_Click(object sender, EventArgs e)
        {
            waiting_right_for_input = !waiting_right_for_input;
            if (waiting_right_for_input == true)
            {
                bind_right.BackColor = Color.FromArgb(0, 20, 45);
                bind_right.Text = "...+RMB";
            }
            else
            {
                bind_right.BackColor = Color.FromArgb(4, 27, 41);
                bind_left.Text = "BIND: " + left_bind_key.ToString() + "+RMB";
            }
        }

        private void bind_right_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (waiting_right_for_input == true)
            {
                right_bind_key = e.KeyData;
                Settings.Default.right_key_bind = right_bind_key.ToString();
                Settings.Default.Save();
                bind_right.Text = "BIND: " + right_bind_key.ToString() + "+RMB";
                bind_right.BackColor = Color.FromArgb(4, 27, 41);
                waiting_right_for_input = false;
            }
        }

        public void loadData()
        {
            try
            {
                right_bind_key = (Keys)Enum.Parse(typeof(Keys), Settings.Default.right_key_bind);
                bind_right.Text = "BIND: " + right_bind_key.ToString() + "+RMB";
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

                left_delay = Settings.Default.left_delay;
                right_delay = Settings.Default.right_delay;
                
                auto_on_left = Settings.Default.auto_on_left;
                auto_on_right = Settings.Default.auto_on_right;
                if (auto_on_left == true) left_clicker_on = true;
                if (auto_on_right == true) right_clicker_on = true;
                if (left_clicker_on == true)
                {
                    left_clicker_b.BackColor = Color.FromArgb(4, 27, 41);
                    left_clicker_b.Text = "ENABLED";
                }
                else
                {
                    left_clicker_b.BackColor = Color.FromArgb(0, 20, 45);
                    left_clicker_b.Text = "DISABLED";
                }
                if (right_clicker_on == true)
                {
                    right_clicker_b.BackColor = Color.FromArgb(4, 27, 41);
                    right_clicker_b.Text = "ENABLED";
                }
                else
                {
                    right_clicker_b.BackColor = Color.FromArgb(0, 20, 45);
                    right_clicker_b.Text = "DISABLED";
                }
                if (auto_on_right == true)
                {
                    auto_turnonoff_clicker_b_r.Text = "ENABLED";
                    auto_turnonoff_clicker_b_r.BackColor = Color.FromArgb(4, 27, 41);
                }
                else
                {
                    auto_turnonoff_clicker_b_r.Text = "DISABLED";
                    auto_turnonoff_clicker_b_r.BackColor = Color.FromArgb(0, 20, 45);
                }
                if (auto_on_left == true)
                {
                    auto_turnonoff_clicker_b_l.Text = "ENABLED";
                    auto_turnonoff_clicker_b_l.BackColor = Color.FromArgb(4, 27, 41);
                }
                else
                {
                    auto_turnonoff_clicker_b_l.Text = "DISABLED";
                    auto_turnonoff_clicker_b_l.BackColor = Color.FromArgb(0, 20, 45);
                }
                left_delay_input.Text = left_delay.ToString();
                right_delay_input.Text = right_delay.ToString();
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

        bool open = false;
        private void conf_clicker_Click(object sender, EventArgs e)
        {
            open = !open;
            if(open == true) {
                conf_panel.Enabled = true;
                conf_panel.Visible = true;
                conf_clicker.Text = "SAVE AND LEAVE";
            } else
            {
                bool parse_left_delay_asnwer = int.TryParse(left_delay_input.Text, out int parsed_left_delay);
                bool parse_right_delay_asnwer = int.TryParse(right_delay_input.Text, out int parsed_right_delay);
                if(parse_left_delay_asnwer == true && parsed_left_delay >= 0)
                {
                    left_delay = parsed_left_delay;
                    Settings.Default.left_delay = parsed_left_delay;
                    Settings.Default.Save();
                } else
                {
                    left_delay_input.Text = left_delay.ToString();
                    Settings.Default.left_delay = left_delay;
                    Settings.Default.Save();
                }
                if(parse_right_delay_asnwer == true && parsed_right_delay >= 0)
                {
                    right_delay = parsed_right_delay;
                    Settings.Default.right_delay = parsed_right_delay;
                    Settings.Default.Save();
                } else
                {
                    right_delay_input.Text = right_delay.ToString();
                    Settings.Default.right_delay = right_delay;
                    Settings.Default.Save();
                }

                conf_panel.Enabled = false;
                conf_panel.Visible = false;
                conf_clicker.Text = "CONFIGURE CLICKER";
            }
            Settings.Default.auto_on_right = auto_on_right;
            Settings.Default.auto_on_left = auto_on_left;
            Settings.Default.Save();
        }

        private void auto_turnonoff_clicker_b_r_Click(object sender, EventArgs e)
        {
            auto_on_right = !auto_on_right;
            if (auto_on_right == true)
            {
                auto_turnonoff_clicker_b_r.Text = "ENABLED";
                auto_turnonoff_clicker_b_r.BackColor = Color.FromArgb(4, 27, 41);
            }
            else
            {
                auto_turnonoff_clicker_b_r.Text = "DISABLED";
                auto_turnonoff_clicker_b_r.BackColor = Color.FromArgb(0, 20, 45);
            } 
        }

        private void auto_turnonoff_clicker_b_l_Click(object sender, EventArgs e)
        {
            auto_on_left = !auto_on_left;
            if (auto_on_left == true)
            {
                auto_turnonoff_clicker_b_l.Text = "ENABLED";
                auto_turnonoff_clicker_b_l.BackColor = Color.FromArgb(4, 27, 41);
            }
            else
            {
                auto_turnonoff_clicker_b_l.Text = "DISABLED";
                auto_turnonoff_clicker_b_l.BackColor = Color.FromArgb(0, 20, 45);
            }
        }
    }
}