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
    /// Interaction logic for FRC_Form.xaml
    /// </summary>
    public partial class FRC_Form : Window
    {
        public FRC_Form()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(fathername.Text) ||
                string.IsNullOrEmpty(fathernic.Text) ||
                string.IsNullOrEmpty(mothername.Text) ||
                string.IsNullOrEmpty(mothernic.Text) ||
                string.IsNullOrEmpty(applicantname.Text) ||
                string.IsNullOrEmpty(applicantnic.Text) ||
                string.IsNullOrEmpty(relationship.Text) ||
                string.IsNullOrEmpty(frn.Text) ||
                string.IsNullOrEmpty(numberofmembers.Text) ||
                string.IsNullOrEmpty(religion.Text) ||
                string.IsNullOrEmpty(permanentaddress.Text) ||
                string.IsNullOrEmpty(currentaddress.Text))
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

                    string query = "INSERT INTO dbo.frc (fathername, fathernic, mothername, mothernic, applicantname, applicantnic, relationship, frn, numberofmembers, religion, permanentaddress, currentaddress) " +
                                   "VALUES (@Fathername, @Fathernic, @Mothername, @Mothernic, @Applicantname, @Applicantnic, @Relationship, @FRN, @Numberofmembers, @Religion, @PermanentAddress, @CurrentAddress)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Replace placeholders with actual data
                        cmd.Parameters.AddWithValue("@Fathername", fathername.Text);
                        cmd.Parameters.AddWithValue("@Fathernic", fathernic.Text);
                        cmd.Parameters.AddWithValue("@Mothername", mothername.Text);
                        cmd.Parameters.AddWithValue("@Mothernic", mothernic.Text);
                        cmd.Parameters.AddWithValue("@Applicantname", applicantname.Text);
                        cmd.Parameters.AddWithValue("@Applicantnic", applicantnic.Text);
                        cmd.Parameters.AddWithValue("@Relationship", relationship.Text);
                        cmd.Parameters.AddWithValue("@FRN", frn.Text);
                        cmd.Parameters.AddWithValue("@Numberofmembers", numberofmembers.Text);
                        cmd.Parameters.AddWithValue("@Religion", religion.Text);
                        cmd.Parameters.AddWithValue("@PermanentAddress", permanentaddress.Text);
                        cmd.Parameters.AddWithValue("@CurrentAddress", currentaddress.Text);

                        // Show confirmation dialog
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
