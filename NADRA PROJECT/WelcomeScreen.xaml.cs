using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NADRA_PROJECT
{
    /// <summary>
    /// Interaction logic for WelcomeScreen.xaml
    /// </summary>
    public partial class WelcomeScreen : Window
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }
        String WhichButton;
        
       
        private void userButton_MouseEnter(object sender, MouseEventArgs e)
        {
            userButton.Foreground= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#009846"));

            userButton.Background = Brushes.White;
        }
        private void userButton_MouseLeave(object sender, MouseEventArgs e)
        {
            userButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#009846"));

            userButton.Foreground = Brushes.White;
        }
        private void userButton_Click(object sender, RoutedEventArgs e)
        {
            WhichButton = "user";
            LoginPage.ButtonPressed(WhichButton);
            SignUpPage.ButtonPressed(WhichButton);

            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
           
        }

        private void adminButton_MouseEnter(object sender, MouseEventArgs e)
        {
            adminButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#009846"));

            adminButton.Foreground = Brushes.White;

        }

        private void adminButton_MouseLeave(object sender, MouseEventArgs e)
        {
            adminButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#009846"));

            adminButton.Background = Brushes.White;
        }

        private void adminButton_Click(object sender, RoutedEventArgs e)
        {
            WhichButton = "admin";
            LoginPage.ButtonPressed(WhichButton);
            SignUpPage.ButtonPressed(WhichButton);
            
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }
}
