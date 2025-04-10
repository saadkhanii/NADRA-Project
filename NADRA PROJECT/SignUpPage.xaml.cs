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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class SignUpPage : Window
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        public static String result = "user";
        public static void ButtonPressed(String getresult)
        {
            result = getresult;
        }
        private void login_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Password))
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string connectionString = "Data Source=Saad;Initial Catalog=nadra;Integrated Security=SSPI;"; 

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query;

                    if (result == "admin")
                    {
                        query = $"INSERT INTO dbo.admin_login (name, password) VALUES (@Name, @Password)";
                    }
                    else
                    {
                        query = $"INSERT INTO dbo.user_login (name, password) VALUES (@Name, @Password)";
                    }

                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Replace placeholders with actual data
                    cmd.Parameters.AddWithValue("@Name", username.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Password);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        if (result == "admin")
                        {
                            Admin_Dashboard Admin_Dashboard = new Admin_Dashboard();
                            Admin_Dashboard.Show();
                            this.Close();
                        }
                        else
                        {
                            User_Dashboard dashboard = new User_Dashboard();
                            dashboard.Show();
                            this.Close();
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit data. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
