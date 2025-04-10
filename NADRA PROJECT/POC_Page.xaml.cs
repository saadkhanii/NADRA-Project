using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for POC_Page.xaml
    /// </summary>
    public partial class POC_Page : Window
    {
        public POC_Page()
        {
            InitializeComponent();
        }


        private void ShowLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (countries.Visibility == Visibility.Visible)
            {
                countries.Visibility = Visibility.Hidden;
                ShowLabel.Content = "Show...";
            }
            else
            {
                countries.Visibility = Visibility.Visible;
                ShowLabel.Content = "Hide";
            }
        }

        private void ApplyNowButton_Click(object sender, RoutedEventArgs e)
        {
            POC_Form pocForm = new POC_Form();
            pocForm.Show();
        }
    }
}
