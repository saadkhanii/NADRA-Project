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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class User_Dashboard : Window
    {
        public User_Dashboard()
        {
            InitializeComponent();
        }

        
        //Mouse Clicks
        private void NIC_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NIC_Page nIC_Page = new NIC_Page();
            nIC_Page.Show();
        }
        private void JVC_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            JVC_Page jVC_Page = new JVC_Page();
            jVC_Page.Show();
        }
        private void POC_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            POC_Page pOC_Page = new POC_Page();
            pOC_Page.Show();
        }
        private void CRC_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CRC_Page cRC_Page = new CRC_Page();
            cRC_Page.Show();
        }
        private void FRC_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FRC_Page fRC_Page = new FRC_Page();
            fRC_Page.Show();
        }
        private void NICOP_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NICOP_Page nICOP_Page = new NICOP_Page();
            nICOP_Page.Show();
        }

        //Mouse Enter/leave....
        private void NIC_MouseEnter(object sender, MouseEventArgs e)
        {
            NIC.Background = Brushes.Gainsboro;
        }
        private void NIC_MouseLeave(object sender, MouseEventArgs e)
        {
            NIC.Background = Brushes.White;
        }
        private void JVC_MouseEnter(object sender, MouseEventArgs e)
        {
            JVC.Background = Brushes.Gainsboro;
        }
        private void JVC_MouseLeave(object sender, MouseEventArgs e)
        {
            JVC.Background = Brushes.White;
        }
        private void POC_MouseEnter(object sender, MouseEventArgs e)
        {
            POC.Background = Brushes.Gainsboro;
        }
        private void POC_MouseLeave(object sender, MouseEventArgs e)
        {
            POC.Background = Brushes.White;
        }
        private void FRC_MouseEnter(object sender, MouseEventArgs e)
        {
            FRC.Background = Brushes.Gainsboro;
        }
        private void FRC_MouseLeave(object sender, MouseEventArgs e)
        {
            FRC.Background = Brushes.White;
        }
        private void CRC_MouseEnter(object sender, MouseEventArgs e)
        {
            CRC.Background = Brushes.Gainsboro;
        }
        private void CRC_MouseLeave(object sender, MouseEventArgs e)
        {
            CRC.Background = Brushes.White;
        }
        private void NICOP_MouseEnter(object sender, MouseEventArgs e)
        {
            NICOP.Background = Brushes.Gainsboro;
        }
        private void NICOP_MouseLeave(object sender, MouseEventArgs e)
        {
            NICOP.Background = Brushes.White;
        }


        private void about_Click(object sender, RoutedEventArgs e)
        {
            AboutNADRA aboutNADRA = new AboutNADRA();
            aboutNADRA.Show();
        }

        private void contactUs_Click(object sender, RoutedEventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            contactUs.Show();
        }

        private void complaints_Click(object sender, RoutedEventArgs e)
        {
            Complaints complaints = new Complaints();  
            complaints.Show();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            WelcomeScreen welcomeScreen = new WelcomeScreen();
            welcomeScreen.Show();
            this.Close();
        }

        private void media_Click(object sender, RoutedEventArgs e)
        {
           Media media = new Media();   
           media.Show();
        }

        private void careers_Click(object sender, RoutedEventArgs e)
        {
            Careers careers = new Careers();
            careers.Show();
        }

        private void offices_Click(object sender, RoutedEventArgs e)
        {
            Offices offices = new Offices();
            offices.Show();
        }
    }
}
