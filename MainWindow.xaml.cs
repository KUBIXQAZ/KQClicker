using System;
using System.Windows;
using System.Windows.Input;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;
using static KQClicker.MainPage;

namespace KQClicker
{
    public partial class MainWindow : Window
    {
        public static bool loadMain = false;

        public static bool left_clicker_on = false;
        public static bool right_clicker_on = false;

        public static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string myAppFolder = Path.Combine(appDataPath, "KUBIXQAZ/KQClicker");
        public static string settingsFilePath = Path.Combine(myAppFolder, "settings.json");

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                if(File.Exists(settingsFilePath))
                {
                    string settingsJson = File.ReadAllText(settingsFilePath);
                    ClickerSettings settings = JsonConvert.DeserializeObject<ClickerSettings>(settingsJson);

                    MainPage.clickersettings = settings;
                }
            }
            catch (Exception) { return; }

            Main.Content = new MainPage();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ClosingApp(object sender, CancelEventArgs e)
        {
            ClickerSettings settings = MainPage.clickersettings;

            if (!Directory.Exists(myAppFolder))
            {
                Directory.CreateDirectory(myAppFolder);
            }

            string settingsJson = JsonConvert.SerializeObject(settings);
            File.WriteAllText(settingsFilePath, settingsJson);
        }
    }
}
