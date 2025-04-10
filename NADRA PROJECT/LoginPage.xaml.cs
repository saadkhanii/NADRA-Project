using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
    public partial class LoginPage : Window
    {
        public static String result = "user";
        public LoginPage()
        {
            InitializeComponent();
        }

        public static void ButtonPressed(String getresult)
        {
            result = getresult;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=Saad;Initial Catalog=nadra;Integrated Security=SSPI;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query;

                    if (result == "admin")
                    {
                        query = $"SELECT COUNT(*) FROM dbo.admin_login WHERE name = @Name AND password = @Password";
                    }
                    else
                    {
                        query = $"SELECT COUNT(*) FROM dbo.user_login WHERE name = @Name AND password = @Password";
                    }

                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Replace placeholders with actual data
                    cmd.Parameters.AddWithValue("@Name", username.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
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
                        MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void signin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
            this.Close();
        }
    }
}
