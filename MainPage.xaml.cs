using System.Runtime.InteropServices;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Navigation;
using static KQClicker.MainWindow;
using static System.Net.Mime.MediaTypeNames;

namespace KQClicker
{
    public partial class MainPage : Page
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);

        public bool left_clicker_working = false;
        public bool right_clicker_working = false;

        public class ClickerSettings
        {
            public Key keybind_left { get; set; } = Key.R;
            public bool left_clicker_toggle { get; set; } = true;
            public int cps_left { get; set; } = 10;
            public bool auto_on_left { get; set; } = false;

            public Key keybind_right { get; set; } = Key.F;
            public bool right_clicker_toggle { get; set; } = true;
            public int cps_right { get; set; } = 10;
            public bool auto_on_right { get; set; } = false;
        }

        bool x = true;
        bool y = true;

        public static ClickerSettings clickersettings = new ClickerSettings();

        public MainPage()
        {
            InitializeComponent();

            bind_left_button.Content = "BIND: " + clickersettings.keybind_left.ToString() + "+LMB";
            leftClicker_slider.Value = clickersettings.cps_left;

            bind_right_button.Content = "BIND: " + clickersettings.keybind_right.ToString() + "+RMB";
            rightClicker_slider.Value = clickersettings.cps_right;

            display_cps_left.Text = leftClicker_slider.Value.ToString();
            display_cps_right.Text = rightClicker_slider.Value.ToString();

            if (clickersettings.left_clicker_toggle == true) left_toggle_button.Content = "TOGGLE";
            else left_toggle_button.Content = "HOLD";
            if (clickersettings.right_clicker_toggle == true) right_toggle_button.Content = "TOGGLE";
            else right_toggle_button.Content = "HOLD";

            if (loadMain == false)
            {
                loadMain = true;

                if (clickersettings.auto_on_left == true)
                {
                    left_clicker_on = true;
                    initializeClicker("L");
                }
                else left_clicker_on = false;

                if (clickersettings.auto_on_right == true)
                {
                    right_clicker_on = true;
                    initializeClicker("R");
                }
                else right_clicker_on = false;
            }
            if (left_clicker_on == true)
            {
                on_off_leftClicker_button.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
                on_off_leftClicker_button.Content = "ENABLED";
            }
            else
            {
                on_off_leftClicker_button.Background = new SolidColorBrush(Color.FromRgb(4, 27, 41));
                on_off_leftClicker_button.Content = "DISABLED";
            }
            if (right_clicker_on == true)
            {
                on_off_rightClicker_button.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
                on_off_rightClicker_button.Content = "ENABLED";
            }
            else
            {
                on_off_rightClicker_button.Background = new SolidColorBrush(Color.FromRgb(4, 27, 41));
                on_off_rightClicker_button.Content = "DISABLED";
            }
        }

        private async void initializeClicker(string LR)
        {
            if (LR == "L") await StartLeftClicker();
            else if (LR == "R") await StartRightClicker();
            else throw new Exception("initializeClicker parameter is wrong (L/R).");
        }

        private void on_off_leftClicker(object sender, RoutedEventArgs e)
        {
            left_clicker_on = !left_clicker_on;
            if (left_clicker_on == true)
            {
                on_off_leftClicker_button.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
                on_off_leftClicker_button.Content = "ENABLED";
                initializeClicker("L");
            }
            else
            {
                on_off_leftClicker_button.Background = new SolidColorBrush(Color.FromRgb(4, 27, 41));
                on_off_leftClicker_button.Content = "DISABLED";
            }
        }

        private async Task StartLeftClicker()
        {
            while (left_clicker_on)
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                    {
                        if (clickersettings.left_clicker_toggle == true)
                        {
                            if (Keyboard.IsKeyDown(clickersettings.keybind_left) && System.Windows.Forms.Control.MouseButtons == MouseButtons.Left && x == true)
                            {
                                x = false;
                                left_clicker_working = !left_clicker_working;
                            }
                            if (Keyboard.IsKeyUp(clickersettings.keybind_left)) x = true;
                        }
                        else
                        {
                            if (Keyboard.IsKeyDown(clickersettings.keybind_left) && System.Windows.Forms.Control.MouseButtons == MouseButtons.Left) left_clicker_working = true;
                            if (!(System.Windows.Forms.Control.MouseButtons == MouseButtons.Left)) left_clicker_working = false;
                        }

                        if (left_clicker_working == true)
                        {
                            IntPtr hwnd = GetForegroundWindow();
                            PostMessage(hwnd, 0x0201, 0, 0);
                            PostMessage(hwnd, 0x0202, 0, 0);
                        }
                    }
                }
                await Task.Delay((int)(1000.0 / clickersettings.cps_left));
            }
        }

        private void left_cps_slider_scroll(object sender, EventArgs e)
        {
            display_cps_left.Text = leftClicker_slider.Value.ToString();
            clickersettings.cps_left = (int)leftClicker_slider.Value;
        }

        private void left_toggle_hold_switch(object sender, EventArgs e)
        {
            clickersettings.left_clicker_toggle = !clickersettings.left_clicker_toggle;
            if (clickersettings.left_clicker_toggle == true)
            {
                left_toggle_button.Content = "TOGGLE";
            }
            else
            {
                left_toggle_button.Content = "HOLD";
            }
        }

        bool waiting_left_for_input = false;
        private void bind_left(object sender, EventArgs e)
        {
            waiting_left_for_input = !waiting_left_for_input;
            if (waiting_left_for_input == true)
            {
                bind_left_button.Background = new SolidColorBrush(Color.FromRgb(4, 27, 41));
                bind_left_button.Content = "...+LMB";
            }
            else
            {
                bind_left_button.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
                bind_left_button.Content = "BIND: " + clickersettings.keybind_left.ToString() + "+LMB";
            }
        }

        private void bind_left_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (waiting_left_for_input == true)
            {
                clickersettings.keybind_left = e.Key;
                bind_left_button.Content = "BIND: " + clickersettings.keybind_left.ToString() + "+LMB";
                bind_left_button.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
                waiting_left_for_input = false;
            }
        }

        private void on_off_rightClicker(object sender, EventArgs e)
        {
            right_clicker_on = !right_clicker_on;

            if (right_clicker_on == true)
            {
                on_off_rightClicker_button.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
                on_off_rightClicker_button.Content = "ENABLED";
                initializeClicker("R");
            }
            else
            {
                on_off_rightClicker_button.Background = new SolidColorBrush(Color.FromRgb(4, 27, 41));
                on_off_rightClicker_button.Content = "DISABLED";
            }
        }

        private async Task StartRightClicker()
        {
            while (right_clicker_on)
            {
                Process[] proccess = Process.GetProcessesByName("javaw");
                foreach (Process process in proccess)
                {
                    if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                    {
                        if (clickersettings.right_clicker_toggle == true)
                        {
                            if (Keyboard.IsKeyDown(clickersettings.keybind_right) && System.Windows.Forms.Control.MouseButtons == MouseButtons.Right && y == true)
                            {
                                right_clicker_working = !right_clicker_working;
                                y = false;
                            }
                            if (Keyboard.IsKeyUp(clickersettings.keybind_right) && System.Windows.Forms.Control.MouseButtons != MouseButtons.Right) y = true;
                        }
                        else
                        {
                            if (Keyboard.IsKeyDown(clickersettings.keybind_right) && System.Windows.Forms.Control.MouseButtons == MouseButtons.Right) right_clicker_working = true;
                            if (!(System.Windows.Forms.Control.MouseButtons == MouseButtons.Right)) right_clicker_working = false;
                        }

                        if (right_clicker_working == true)
                        {
                            IntPtr hwnd = GetForegroundWindow();
                            PostMessage(hwnd, 0x0204, 0, 0);
                            PostMessage(hwnd, 0x0205, 0, 0);
                        }
                    }
                }
                await Task.Delay((int)(1000.0 / clickersettings.cps_right));
            }
        }

        private void right_cps_slider_scroll(object sender, EventArgs e)
        {
            display_cps_right.Text = rightClicker_slider.Value.ToString();
            clickersettings.cps_right = (int)rightClicker_slider.Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clickersettings.right_clicker_toggle = !clickersettings.right_clicker_toggle;
            if (clickersettings.right_clicker_toggle == true)
            {
                right_toggle_button.Content = "TOGGLE";
            }
            else
            {
                right_toggle_button.Content = "HOLD";
            }
        }

        bool waiting_right_for_input = false;
        private void bind_right(object sender, EventArgs e)
        {
            waiting_right_for_input = !waiting_right_for_input;
            if (waiting_right_for_input == true)
            {
                bind_right_button.Background = new SolidColorBrush(Color.FromRgb(4, 27, 41));
                bind_right_button.Content = "...+LMB";
            }
            else
            {
                bind_right_button.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
                bind_right_button.Content = "BIND: " + clickersettings.keybind_right.ToString() + "+LMB";
            }
        }

        private void bind_right_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (waiting_right_for_input == true)
            {
                clickersettings.keybind_right = e.Key;
                bind_right_button.Content = "BIND: " + clickersettings.keybind_right.ToString() + "+LMB";
                bind_right_button.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
                waiting_right_for_input = false;
            }
        }

        private void Settings_button(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            Frame mainFrame = (Frame)parentWindow.FindName("Main");
            mainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

            mainFrame.Navigate(new SettingsPage());
        }
    }
}
