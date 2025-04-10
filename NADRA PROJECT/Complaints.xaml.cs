using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for Complaints.xaml
    /// </summary>
    public partial class Complaints : Window
    {
        public Complaints()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(country.Text) ||
                string.IsNullOrEmpty(province.Text) ||
                string.IsNullOrEmpty(district.Text) ||
                string.IsNullOrEmpty(tehsil.Text) ||
                string.IsNullOrEmpty(officeid.Text) ||
                string.IsNullOrEmpty(fullname.Text) ||
                string.IsNullOrEmpty(nicnumber.Text) ||
                string.IsNullOrEmpty(email.Text) ||
                string.IsNullOrEmpty(dailingcode.Text) ||
                string.IsNullOrEmpty(contact.Text) ||
                string.IsNullOrEmpty(complaint.Text))
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

                    string query = "INSERT INTO dbo.complaints (country, province, district, tehsil, officeid, fullname, nicnumber, email, dailingcode, contactnumber, complaint) " +
                                   "VALUES (@Country, @Province, @District, @Tehsil, @OfficeID, @Fullname, @NICnumber, @Email, @Dailingcode, @ContactNumber, @Complaint)";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Replace placeholders with actual data
                    cmd.Parameters.AddWithValue("@Country", country.Text);
                    cmd.Parameters.AddWithValue("@Province", province.Text);
                    cmd.Parameters.AddWithValue("@District", district.Text);
                    cmd.Parameters.AddWithValue("@Tehsil", tehsil.Text);
                    cmd.Parameters.AddWithValue("@OfficeID", officeid.Text);
                    cmd.Parameters.AddWithValue("@Fullname", fullname.Text);
                    cmd.Parameters.AddWithValue("@NICnumber", nicnumber.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@Dailingcode", dailingcode.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", contact.Text);
                    cmd.Parameters.AddWithValue("@Complaint", complaint.Text);

                    ConfirmationDialog dialog = new ConfirmationDialog(
                        "Are you sure you want to submit the data?","Confirm","Cancel");

                    if (dialog.ShowDialog() == true && dialog.IsConfirmed)
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data submitted successfully!", "Success",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit data. Please try again.", "Error",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

}
