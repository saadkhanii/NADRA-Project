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
    /// Interaction logic for FRC_Page.xaml
    /// </summary>
    public partial class FRC_Page : Window
    {
        public FRC_Page()
        {
            InitializeComponent();
        }

        private void ApplyNowButton_Click(object sender, RoutedEventArgs e)
        {
            FRC_Form fRC_Form = new FRC_Form();
            fRC_Form.Show();
        }

        private void ByBirthLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {   if (ByBirthText.Visibility == Visibility.Visible)
            { 
                ByBirthText.Visibility = Visibility.Hidden; 
            }
            else
            {
                ByBirthText.Visibility = Visibility.Visible;
                ByMarriageText.Visibility = Visibility.Hidden;
                ByAdoptionText.Visibility = Visibility.Hidden;
            }
        }

        private void ByMarriageLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (ByMarriageText.Visibility == Visibility.Visible)
            {
                ByMarriageText.Visibility = Visibility.Hidden;
            }
            else
            {
                ByMarriageText.Visibility = Visibility.Visible;
                ByBirthText.Visibility = Visibility.Hidden;
                ByAdoptionText.Visibility = Visibility.Hidden;
            }
        }

        private void ByAdoptionLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (ByAdoptionText.Visibility == Visibility.Visible)
            {
                ByAdoptionText.Visibility = Visibility.Hidden;
            }
            else
            {
                ByAdoptionText.Visibility = Visibility.Visible;
                ByBirthText.Visibility = Visibility.Hidden;
                ByMarriageText.Visibility = Visibility.Hidden;
            }
        }
    }
}
