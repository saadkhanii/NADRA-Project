//using NADRA_PROJECT.pictures;
using System.Diagnostics;
using System.Windows;

namespace NADRA_PROJECT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
        }


        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
        
                for (int i = 0; i <= 100; i++)
                {
                    progressBar.Value = i;
                    await Task.Delay(30);
                }
             
                WelcomeScreen welcomeScreen = new WelcomeScreen();
                Application.Current.MainWindow = welcomeScreen;
                welcomeScreen.Show();
                this.Close();
            
        }
    }
}