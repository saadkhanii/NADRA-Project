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
    /// Interaction logic for ConfirmationDialog.xaml
    /// </summary>
    public partial class ConfirmationDialog : Window
    {
        public bool IsConfirmed { get; private set; } = false;
        public ConfirmationDialog(string message, string CnfBtnText = "Confirm", string CnlBtnText = "Cancel")
        {
            InitializeComponent();
            MessageTextBlock.Text = message;
            ConfirmButton.Content = CnfBtnText;
            CancelButton.Content = CnlBtnText;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            IsConfirmed = true;
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            IsConfirmed = false;
            this.DialogResult = false;
        }
    }
}
