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
    /// Interaction logic for JVC_Page.xaml
    /// </summary>
    public partial class JVC_Page : Window
    {
        public JVC_Page()
        {
            InitializeComponent();
        }

        private void ApplyNowButton_Click(object sender, RoutedEventArgs e)
        {
            JVC_Form jvcForm = new JVC_Form();
            jvcForm.Show();
        }
    }
}
