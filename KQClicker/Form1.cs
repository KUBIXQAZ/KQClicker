using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
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
        public static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //LMB CLICKER//
        public bool left_clicker_on = false;
        public bool left_clicker_working = false;
        //TO SAVE//
        public Keys keybind_left = Keys.R;
        public bool left_clicker_toggle = false;
        public int cps_left = 10;
        public bool auto_on_left = false;

        //RMB CLICKER//
        public bool right_clicker_on = false;
        public bool right_clicker_working = false;
        //TO SAVE//
        public Keys keybind_right = Keys.F;
        public bool right_clicker_toggle = false;
        public int cps_right = 10;
        public bool auto_on_right = false;

        public class ClickerSettings
        {
            //LMB CLICKER//
            public Keys keybind_left { get; set; } = Keys.R;
            public bool left_clicker_toggle { get; set; } = false;
            public int cps_left { get; set; } = 10;
            public int left_delay { get; set; } = 20;
            public bool auto_on_left { get; set; } = false;
            //RBM CLICKER//
            public Keys keybind_right { get; set; } = Keys.F;
            public bool right_clicker_toggle { get; set; } = false;
            public int cps_right { get; set; } = 10;
            public int right_delay { get; set; } = 20;
            public bool auto_on_right { get; set; } = false;
        }

        public Form1()
        {
            InitializeComponent();
            bar.MouseDown += new System.Windows.Forms.MouseEventHandler(move_window);
            app_title.MouseDown += new System.Windows.Forms.MouseEventHandler(move_window);
        }

        //MOVING WINDOW WITH BAR//
        private void move_window(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                PostMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        //TURN ON/OFF LEFT CLICKER//
        private void left_clicker_b_click(object sender, EventArgs e)
        {
            left_clicker_on = !left_clicker_on;

            if (left_clicker_on == true)
            {
                left_clicker_b.BackColor = Color.FromArgb(4, 27, 41);
                left_clicker_b.Text = "ENABLED";
                LeftClicker.Start();
            }
            else
            {
                left_clicker_b.BackColor = Color.FromArgb(0, 20, 45);
                left_clicker_b.Text = "DISABLED";
                LeftClicker.Stop();
            }
        }

        //LEFT CLICKER TIMER//
        bool x = true;
        private void LeftClicker_Tick(object sender, EventArgs e)
        {
            Process[] proccess = Process.GetProcessesByName("javaw");
            foreach (Process process in proccess)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    Key left_key = KeyInterop.KeyFromVirtualKey((int)keybind_left);
                    if (left_clicker_toggle == true)
                    {
                        if (Keyboard.IsKeyDown(left_key) && MouseButtons == MouseButtons.Left && x == true)
                        {
                            left_clicker_working = !left_clicker_working;
                            x = false;
                        }
                        if (Keyboard.IsKeyUp(left_key) && MouseButtons != MouseButtons.Left) x = true;
                    }
                    else
                    {
                        if (Keyboard.IsKeyDown(left_key) && MouseButtons == MouseButtons.Left) left_clicker_working = true;
                        if (!(MouseButtons == MouseButtons.Left)) left_clicker_working = false;
                    }

                    if (left_clicker_working == true)
                    {
                        LeftClicker.Interval = 1000 / cps_left;
                        IntPtr hwnd = GetForegroundWindow();
                        PostMessage(hwnd, 0x0201, 0, 0);
                        Thread.Sleep(10);
                        PostMessage(hwnd, 0x0202, 0, 0);
                    }
                }
            }
        }

        //TURN ON/OFF RIGHT CLICKER//
        private void right_clicker_b_Click_1(object sender, EventArgs e)
        {
            //switch on/off right mb clicker//
            right_clicker_on = !right_clicker_on;

            //changing button style//
            if (right_clicker_on == true)
            {
                right_clicker_b.BackColor = Color.FromArgb(4, 27, 41);
                right_clicker_b.Text = "ENABLED";
                RightClicker.Start();
            }
            else
            {
                right_clicker_b.BackColor = Color.FromArgb(0, 20, 45);
                right_clicker_b.Text = "DISABLED";
                RightClicker.Stop();
            }
        }

        //RIGHT CLICKER TIMER//
        bool y = true;
        private void RightClicker_Tick(object sender, EventArgs e)
        {
            Process[] proccess = Process.GetProcessesByName("javaw");
            foreach (Process process in proccess)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (right_clicker_on == true)
                    {
                        Key right_key = KeyInterop.KeyFromVirtualKey((int)keybind_right);
                        if (right_clicker_toggle == true)
                        {
                            if (Keyboard.IsKeyDown(right_key) && MouseButtons == MouseButtons.Right && y == true)
                            {
                                right_clicker_working = !right_clicker_working;
                                y = false;
                            }
                            if (Keyboard.IsKeyUp(right_key) && MouseButtons != MouseButtons.Right) y = true;
                        }
                        else
                        {
                            if (Keyboard.IsKeyDown(right_key) && MouseButtons == MouseButtons.Right) right_clicker_working = true;
                            if (!(MouseButtons == MouseButtons.Right)) right_clicker_working = false;
                        }

                        if (right_clicker_working == true)
                        {
                            RightClicker.Interval = 1000 / cps_right;
                            IntPtr hwnd = GetForegroundWindow();
                            PostMessage(hwnd, 0x0204, 0, 0);
                            Thread.Sleep(10);
                            PostMessage(hwnd, 0x0205, 0, 0);
                        }
                    }
                }
            }
        }


        //ON APP LOAD//
        private void Form1_Load(object sender, EventArgs e)
        {
            //WINDOW BAR STYLES//
            bar.BackColor = Color.FromArgb(0, 12, 20);
            app_title.ForeColor = Color.FromArgb(36, 112, 171);
            exit_b.BackColor = Color.Red;
            minimize_b.BackColor = Color.Orange;

            //LMB CLICKER PANEL STYLES//
            //TITLE BAR//
            title_left.ForeColor = Color.FromArgb(36, 112, 171);
            title_panel_left.BackColor = Color.FromArgb(0, 12, 20);
            panel_left.BackColor = Color.FromArgb(0, 8, 13);
            //TURN ON/OFF CLICKER BUTTON//
            left_clicker_b.ForeColor = Color.FromArgb(36, 112, 171);
            left_clicker_b.BackColor = Color.FromArgb(0, 20, 45);
            //CPS TITLE//
            cps_left_title.ForeColor = Color.FromArgb(36, 112, 171);
            //KEYBIND BUTTON//
            bind_left.ForeColor = Color.FromArgb(36, 112, 171);
            bind_left.BackColor = Color.FromArgb(4, 27, 41);
            //DISPLAY CPS//
            display_cps_left.ForeColor = Color.FromArgb(36, 112, 171);
            //TOGGLE/HOLD BUTTON//
            left_toggle.BackColor = Color.FromArgb(4, 27, 41);
            left_toggle.ForeColor = Color.FromArgb(36, 112, 171);

            //RMB CLICKER PANEL STYLES//
            //TITLE BAR//
            title_right.ForeColor = Color.FromArgb(36, 112, 171);
            title_panel_right.BackColor = Color.FromArgb(0, 12, 20);
            panel_right.BackColor = Color.FromArgb(0, 8, 13);
            //TURN ON/OFF CLICKER BUTTON//
            right_clicker_b.ForeColor = Color.FromArgb(36, 112, 171);
            right_clicker_b.BackColor = Color.FromArgb(0, 20, 45);
            //CPS TITLE//
            cps_right_title.ForeColor = Color.FromArgb(36, 112, 171);
            //KEYBIND BUTTON//
            bind_right.ForeColor = Color.FromArgb(36, 112, 171);
            bind_right.BackColor = Color.FromArgb(4, 27, 41);
            //DISPLAY CPS//
            display_cps_right.ForeColor = Color.FromArgb(36, 112, 171);
            //TOGGLE/HOLD BUTTON//
            right_toggle.BackColor = Color.FromArgb(4, 27, 41);
            right_toggle.ForeColor = Color.FromArgb(36, 112, 171);

            //CONFIGURATE BUTTON//
            conf_clicker.BackColor = Color.FromArgb(4, 27, 41);
            conf_clicker.ForeColor = Color.FromArgb(36, 112, 171);

            //SIMPLE PANEL//
            panel_simple.BackColor = Color.FromArgb(0, 6, 10);

            //ADVANCED PANEL//
            title_advanced.ForeColor = Color.FromArgb(36, 112, 171);
            title_panel_advanced.BackColor = Color.FromArgb(0, 12, 20);
            panel_advanced.BackColor = Color.FromArgb(0, 8, 13);
            conf_panel.BackColor = Color.FromArgb(0, 6, 10);
            advanced2_left_text.ForeColor = Color.FromArgb(36, 112, 171);
            advanced2_right_text.ForeColor = Color.FromArgb(36, 112, 171);
            auto_turnonoff_clicker_b_r.ForeColor = Color.FromArgb(36, 112, 171);
            auto_turnonoff_clicker_b_l.ForeColor = Color.FromArgb(36, 112, 171);
            advanced_settings_title_1.ForeColor = Color.FromArgb(36, 112, 171);

            //APP BACKGROUND//
            this.BackColor = Color.FromArgb(0, 6, 10);

            //START LMB CLICKER TIMER//
            LeftClicker.Enabled = true;
            LeftClicker.Start();

            //START RMB CLICKER TIMER//
            RightClicker.Enabled = true;
            RightClicker.Start();

            //LOAD USER SETTINGS//
            loadSettings();
        }

        public void loadSettings()
        {
            try
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string myAppFolder = Path.Combine(appDataPath, "KQClicker");
                string settingsFilePath = Path.Combine(myAppFolder, "settings.json");
                string settingsJson = File.ReadAllText(settingsFilePath);
                ClickerSettings settings = JsonConvert.DeserializeObject<ClickerSettings>(settingsJson);

                keybind_left = settings.keybind_left;
                cps_left = settings.cps_left;
                auto_on_left = settings.auto_on_left;
                left_clicker_toggle = settings.left_clicker_toggle;

                keybind_right = settings.keybind_right;
                cps_right = settings.cps_right;
                auto_on_right = settings.auto_on_right;
                right_clicker_toggle = settings.right_clicker_toggle;

                bind_left.Text = "BIND: " + keybind_left.ToString() + "+LMB";
                left_cps_trackBar.Value = cps_left;

                bind_right.Text = "BIND: " + keybind_right.ToString() + "+RMB";
                right_cps_trackBar.Value = cps_right;

                display_cps_left.Text = left_cps_trackBar.Value.ToString();
                display_cps_right.Text = right_cps_trackBar.Value.ToString();

                if (left_clicker_toggle == true) left_toggle.Text = "TOGGLE";
                else left_toggle.Text = "HOLD";
                if (right_clicker_toggle == true) right_toggle.Text = "TOGGLE";
                else right_toggle.Text = "HOLD";

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
            }
            catch (Exception ex) { return; }
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
                bind_left.Text = "BIND: " + keybind_left.ToString() + "+LMB";
            }
        }

        private void bind_left_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (waiting_left_for_input == true)
            {
                keybind_left = e.KeyData;
                bind_left.Text = "BIND: " + keybind_left.ToString() + "+LMB";
                bind_left.BackColor = Color.FromArgb(4, 27, 41);
                waiting_left_for_input = false;
            }
        }

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
                bind_left.Text = "BIND: " + keybind_right.ToString() + "+RMB";
            }
        }

        private void bind_right_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (waiting_right_for_input == true)
            {
                keybind_right = e.KeyData;
                bind_right.Text = "BIND: " + keybind_right.ToString() + "+RMB";
                bind_right.BackColor = Color.FromArgb(4, 27, 41);
                waiting_right_for_input = false;
            }
        }

        private void left_cps_trackBar_Scroll(object sender, EventArgs e)
        {
            display_cps_left.Text = left_cps_trackBar.Value.ToString();
            cps_left = left_cps_trackBar.Value;
        }

        private void right_cps_trackBar_Scroll(object sender, EventArgs e)
        {
            display_cps_right.Text = right_cps_trackBar.Value.ToString();
            cps_right = right_cps_trackBar.Value;
        }

        bool open = false;
        private void conf_clicker_Click(object sender, EventArgs e)
        {
            open = !open;
            if (open == true)
            {
                conf_panel.Enabled = true;
                conf_panel.Visible = true;
                conf_clicker.Text = "APPLY AND LEAVE";
            }
            else
            {
                conf_panel.Enabled = false;
                conf_panel.Visible = false;
                conf_clicker.Text = "CONFIGURE CLICKER";
            }
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

        public void save_settings()
        {
            ClickerSettings settings = new ClickerSettings();

            settings.keybind_left = keybind_left;
            settings.cps_left = cps_left;
            settings.auto_on_left = auto_on_left;
            settings.left_clicker_toggle = left_clicker_toggle;

            settings.keybind_right = keybind_right;
            settings.cps_right = cps_right;
            settings.auto_on_right = auto_on_right;
            settings.right_clicker_toggle = right_clicker_toggle;

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string myAppFolder = Path.Combine(appDataPath, "KQClicker");
            string settingsFilePath = Path.Combine(myAppFolder, "settings.json");

            if (!Directory.Exists(myAppFolder))
            {
                Directory.CreateDirectory(myAppFolder);
            }

            string settingsJson = JsonConvert.SerializeObject(settings);
            File.WriteAllText(settingsFilePath, settingsJson);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }

        private void left_toggle_Click(object sender, EventArgs e)
        {
            left_clicker_toggle = !left_clicker_toggle;
            if (left_clicker_toggle == true)
            {
                left_toggle.Text = "TOGGLE";
            }
            else
            {
                left_toggle.Text = "HOLD";
            }
        }

        private void right_toggle_Click(object sender, EventArgs e)
        {
            right_clicker_toggle = !right_clicker_toggle;
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