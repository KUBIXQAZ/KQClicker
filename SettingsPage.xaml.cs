using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using static KQClicker.MainPage;

namespace KQClicker
{
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            Frame mainFrame = (Frame)parentWindow.FindName("Main");
            mainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

            mainFrame.Content = new MainPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            clickersettings.auto_on_left = !clickersettings.auto_on_left;
            if (clickersettings.auto_on_left == true)
            {
                auto_turnonoff_clicker_b_l.Content = "ENABLED";
                auto_turnonoff_clicker_b_l.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
            }
            else
            {
                auto_turnonoff_clicker_b_l.Content = "DISABLED";
                auto_turnonoff_clicker_b_l.Background = new SolidColorBrush(Color.FromRgb(4, 27, 41));
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            clickersettings.auto_on_right = !clickersettings.auto_on_right;
            if (clickersettings.auto_on_right == true)
            {
                auto_turnonoff_clicker_b_r.Content = "ENABLED";
                auto_turnonoff_clicker_b_r.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
            }
            
            else
            {
                auto_turnonoff_clicker_b_r.Content = "DISABLED";
                auto_turnonoff_clicker_b_r.Background = new SolidColorBrush(Color.FromRgb(4, 27, 41));
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            if (clickersettings.auto_on_left == true)
            {
                auto_turnonoff_clicker_b_l.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
                auto_turnonoff_clicker_b_l.Content = "ENABLED";
            }
            else
            {
                auto_turnonoff_clicker_b_l.Background = new SolidColorBrush(Color.FromRgb(4, 27, 41));
                auto_turnonoff_clicker_b_l.Content = "DISABLED";
            }
            if (clickersettings.auto_on_right == true)
            {
                auto_turnonoff_clicker_b_r.Background = new SolidColorBrush(Color.FromRgb(0, 20, 45));
                auto_turnonoff_clicker_b_r.Content = "ENABLED";
            }
            else
            {
                auto_turnonoff_clicker_b_r.Background = new SolidColorBrush(Color.FromRgb(4, 27, 41));
                auto_turnonoff_clicker_b_r.Content = "DISABLED";
            }
        }
    }
}
