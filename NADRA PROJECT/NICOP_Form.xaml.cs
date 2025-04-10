using Microsoft.Data.SqlClient;
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
    /// Interaction logic for NIC_Form.xaml
    /// </summary>
    public partial class NICOP_Form : Window
    {
        public NICOP_Form()
        {
            InitializeComponent();
        }


        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.Text) ||
                string.IsNullOrEmpty(lastname.Text) ||
                string.IsNullOrEmpty(fathername.Text) ||
                string.IsNullOrEmpty(dateofbirth.Text) ||
                string.IsNullOrEmpty(gender.Text) ||
                string.IsNullOrEmpty(religion.Text) ||
                string.IsNullOrEmpty(address.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return; 
            }

            string connectionString = "Data Source=Saad;Initial Catalog=nadra;Integrated Security=SSPI;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO dbo.nicop (firstname, lastname, fathername, dateofbirth, gender, religion, address) " +
                                   "VALUES (@Firstname, @Lastname, @Fathername, @DateOfBirth, @Gender, @Religion, @Address)";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Replace placeholders with actual data
                    cmd.Parameters.AddWithValue("@Firstname", firstname.Text);
                    cmd.Parameters.AddWithValue("@Lastname", lastname.Text);
                    cmd.Parameters.AddWithValue("@Fathername", fathername.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateofbirth.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender.Text);
                    cmd.Parameters.AddWithValue("@Religion", religion.Text);
                    cmd.Parameters.AddWithValue("@Address", address.Text);

                    ConfirmationDialog dialog = new ConfirmationDialog("Are you sure you want to submit the data?", "Confirm", "Cancel");
                    if (dialog.ShowDialog() == true && dialog.IsConfirmed)
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data submitted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit data. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
