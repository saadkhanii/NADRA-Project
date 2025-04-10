using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static NADRA_PROJECT.Admin_Dashboard;

namespace NADRA_PROJECT
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Admin_Dashboard : Window
    {
        string connectionString = "Data Source=Saad;Initial Catalog=nadra;Integrated Security=SSPI;";

        public Admin_Dashboard()
        {
            InitializeComponent();
        }
        public class Record1
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FatherName { get; set; }
            public string DOB { get; set; }
            public string Gender { get; set; }
            public string Religion { get; set; }
            public string Address { get; set; }
        }
        public class Record2
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FatherName { get; set; }
            public string FatherNic { get; set; }
            public string DOB { get; set; }
            public string Gender { get; set; }
            public string Religion { get; set; }
            public string Address { get; set; }
        }
        public class POCRecord
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FatherName { get; set; }
            public string FatherNic { get; set; }
            public string DOB { get; set; }
            public string Gender { get; set; }
            public string Religion { get; set; }
            public string Nationality { get; set; }
            public string MaritalStatus { get; set; }
            public string PassportNumber { get; set; }
        }
        public class FRCRecord
        {
            public string FatherName { get; set; }
            public string FatherNIC { get; set; }
            public string MotherName { get; set; }
            public string MotherNIC { get; set; }
            public string ApplicantName { get; set; }
            public string ApplicantNIC { get; set; }
            public string Relationship { get; set; }
            public string FRN { get; set; }
            public string FamilyMembers { get; set; }
            public string Religion { get; set; }
            public string PermanentAddress { get; set; }
            public string CurrentAddress { get; set; }
        }
        public class ComplaintsRecord
        {
            public string Country { get; set; }
            public string Province { get; set; }
            public string District { get; set; }
            public string Tehsil { get; set; }
            public string OfficeID { get; set; }
            public string FullName { get; set; }
            public string NICNumber { get; set; }
            public string Email { get; set; }
            public string DailingCode { get; set; }
            public string ContactNumber { get; set; }
            public string Complaint { get; set; }
        }
        private void NIC_AddMI_Click(object sender, RoutedEventArgs e)
        {
            NIC_Form nIC_Form = new NIC_Form();
            nIC_Form.Show();
        }
        private void NIC_ViewMI_Click(object sender, RoutedEventArgs e)
        {
            
            ButtonGrid.Visibility = Visibility.Visible;
            NIC_Record.Visibility = Visibility.Visible;
            NICOP_Record.Visibility = Visibility.Hidden;
            CRC_Record.Visibility = Visibility.Hidden;
            JVC_Record.Visibility = Visibility.Hidden;
            POC_Record.Visibility = Visibility.Hidden;
            FRC_Record.Visibility = Visibility.Hidden;
            Complaint_Record.Visibility = Visibility.Hidden;

           
            ObservableCollection<Record1> records = new ObservableCollection<Record1>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT firstname, lastname, fathername, dateofbirth, gender, religion, address FROM dbo.nic";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        records.Add(new Record1
                        {
                            FirstName = reader["firstname"].ToString(),
                            LastName = reader["lastname"].ToString(),
                            FatherName = reader["fathername"].ToString(),
                            DOB = reader["dateofbirth"].ToString(),
                            Gender = reader["gender"].ToString(),
                            Religion = reader["religion"].ToString(),
                            Address = reader["address"].ToString()
                        });
                    }
                    reader.Close();

                    NIC_Record.ItemsSource = records;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void JVC_AddMI_Click(object sender, RoutedEventArgs e)
        {
            JVC_Form jVC_Form = new JVC_Form();
            jVC_Form.Show();
        }

        private void JVC_ViewMI_Click(object sender, RoutedEventArgs e)
        {
            
            ButtonGrid.Visibility = Visibility.Visible;
            NIC_Record.Visibility = Visibility.Hidden;
            NICOP_Record.Visibility = Visibility.Hidden;
            JVC_Record.Visibility = Visibility.Visible;
            CRC_Record.Visibility = Visibility.Hidden;
            POC_Record.Visibility = Visibility.Hidden;
            FRC_Record.Visibility = Visibility.Hidden;
            Complaint_Record.Visibility = Visibility.Hidden;

           
            ObservableCollection<Record2> records = new ObservableCollection<Record2>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT firstname, lastname, fathername, fathernic, dateofbirth, gender, religion, address FROM dbo.jvc";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        records.Add(new Record2
                        {
                            FirstName = reader["firstname"].ToString(),
                            LastName = reader["lastname"].ToString(),
                            FatherName = reader["fathername"].ToString(),
                            FatherNic = reader["fathernic"].ToString(),
                            DOB = reader["dateofbirth"].ToString(),
                            Gender = reader["gender"].ToString(),
                            Religion = reader["religion"].ToString(),
                            Address = reader["address"].ToString()
                        });
                    }
                    reader.Close();

                    JVC_Record.ItemsSource = records;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }

        private void CRC_AddMI_Click(object sender, RoutedEventArgs e)
        {
            CRC_Form cRC_Form = new CRC_Form();
            cRC_Form.Show();
        }

        private void CRC_ViewMI_Click(object sender, RoutedEventArgs e)
        {
            
            
            ButtonGrid.Visibility = Visibility.Visible;
            NIC_Record.Visibility = Visibility.Hidden;
            NICOP_Record.Visibility = Visibility.Hidden;
            CRC_Record.Visibility = Visibility.Visible;
            JVC_Record.Visibility = Visibility.Hidden;
            POC_Record.Visibility = Visibility.Hidden;
            FRC_Record.Visibility = Visibility.Hidden;
            Complaint_Record.Visibility = Visibility.Hidden;

           
            ObservableCollection<Record2> records = new ObservableCollection<Record2>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT firstname, lastname, fathername, fathernic, dateofbirth, gender, religion, address FROM dbo.crc";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        records.Add(new Record2
                        {
                            FirstName = reader["firstname"].ToString(),
                            LastName = reader["lastname"].ToString(),
                            FatherName = reader["fathername"].ToString(),
                            FatherNic = reader["fathernic"].ToString(),
                            DOB = reader["dateofbirth"].ToString(),
                            Gender = reader["gender"].ToString(),
                            Religion = reader["religion"].ToString(),
                            Address = reader["address"].ToString()
                        });
                    }
                    reader.Close();

                    CRC_Record.ItemsSource = records;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }

        private void FRC_AddMI_Click(object sender, RoutedEventArgs e)
        {
            FRC_Form fRC_Form = new FRC_Form();
            fRC_Form.Show();
        }

        private void FRC_ViewMI_Click(object sender, RoutedEventArgs e)
        {
            
            ButtonGrid.Visibility = Visibility.Visible;
            NIC_Record.Visibility = Visibility.Hidden;
            NICOP_Record.Visibility = Visibility.Hidden;
            CRC_Record.Visibility = Visibility.Hidden;
            JVC_Record.Visibility = Visibility.Hidden;
            POC_Record.Visibility = Visibility.Hidden;
            FRC_Record.Visibility = Visibility.Visible;
            Complaint_Record.Visibility = Visibility.Hidden;

           
            ObservableCollection<FRCRecord> records = new ObservableCollection<FRCRecord>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT fathername, fathernic, mothername, mothernic, applicantname, applicantnic, relationship, frn, numberofmembers, religion, permanentaddress, currentaddress FROM dbo.frc";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        records.Add(new FRCRecord
                        {
                            FatherName = reader["fathername"].ToString(),
                            FatherNIC = reader["fathernic"].ToString(),
                            MotherName = reader["mothername"].ToString(),
                            MotherNIC = reader["mothernic"].ToString(),
                            ApplicantName = reader["applicantname"].ToString(),
                            ApplicantNIC = reader["applicantnic"].ToString(),
                            Relationship = reader["relationship"].ToString(),
                            FRN = reader["frn"].ToString(),
                            FamilyMembers = reader["numberofmembers"].ToString(),
                            Religion = reader["religion"].ToString(),
                            PermanentAddress = reader["permanentaddress"].ToString(),
                            CurrentAddress = reader["currentaddress"].ToString()
                        });
                    }
                    reader.Close();

                    FRC_Record.ItemsSource = records;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void POC_AddMI_Click(object sender, RoutedEventArgs e)
        {
            POC_Form pOC_Form = new POC_Form();
            pOC_Form.Show();
        }

        private void POC_ViewMI_Click(object sender, RoutedEventArgs e)
        {
            
            
            ButtonGrid.Visibility = Visibility.Visible;
            NIC_Record.Visibility = Visibility.Hidden;
            NICOP_Record.Visibility = Visibility.Hidden;
            CRC_Record.Visibility = Visibility.Hidden;
            JVC_Record.Visibility = Visibility.Hidden;
            POC_Record.Visibility = Visibility.Visible;
            FRC_Record.Visibility = Visibility.Hidden;
            Complaint_Record.Visibility = Visibility.Hidden;

           
            ObservableCollection<POCRecord> records = new ObservableCollection<POCRecord>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT firstname, lastname, fathername, dateofbirth, gender, religion, nationality, maritalstatus, passportnumber FROM dbo.poc";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        records.Add(new POCRecord
                        {
                            FirstName = reader["firstname"].ToString(),
                            LastName = reader["lastname"].ToString(),
                            FatherName = reader["fathername"].ToString(),
                            DOB = reader["dateofbirth"].ToString(),
                            Gender = reader["gender"].ToString(),
                            Religion = reader["religion"].ToString(),
                            Nationality = reader["nationality"].ToString(),
                            MaritalStatus = reader["maritalstatus"].ToString(),
                            PassportNumber = reader["passportnumber"].ToString()
                        });
                    }
                    reader.Close();

                    POC_Record.ItemsSource = records;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void NICOP_AddMI_Click(object sender, RoutedEventArgs e)
        {
            NICOP_Form nICOP_Form = new NICOP_Form();
            nICOP_Form.Show();
        }

        private void NICOP_ViewMI_Click(object sender, RoutedEventArgs e)
        {
            
            
            ButtonGrid.Visibility = Visibility.Visible;
            NIC_Record.Visibility = Visibility.Hidden;
            CRC_Record.Visibility = Visibility.Hidden;
            JVC_Record.Visibility = Visibility.Hidden;
            POC_Record.Visibility = Visibility.Hidden;
            FRC_Record.Visibility = Visibility.Hidden;
            NICOP_Record.Visibility = Visibility.Visible;
            Complaint_Record.Visibility = Visibility.Hidden;

           
            ObservableCollection<Record1> records = new ObservableCollection<Record1>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT firstname, lastname, fathername, dateofbirth, gender, religion, address FROM dbo.nicop";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        records.Add(new Record1
                        {
                            FirstName = reader["firstname"].ToString(),
                            LastName = reader["lastname"].ToString(),
                            FatherName = reader["fathername"].ToString(),
                            DOB = reader["dateofbirth"].ToString(),
                            Gender = reader["gender"].ToString(),
                            Religion = reader["religion"].ToString(),
                            Address = reader["address"].ToString()
                        });
                    }
                    reader.Close();

                    NICOP_Record.ItemsSource = records;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void COMP_ViewMI_Click(object sender, RoutedEventArgs e)
        {
            
            
            ButtonGrid.Visibility = Visibility.Visible;
            NIC_Record.Visibility = Visibility.Hidden;
            NICOP_Record.Visibility = Visibility.Hidden;
            JVC_Record.Visibility = Visibility.Hidden;
            CRC_Record.Visibility = Visibility.Hidden;
            POC_Record.Visibility = Visibility.Hidden;
            FRC_Record.Visibility = Visibility.Hidden;
            Complaint_Record.Visibility = Visibility.Visible;

            ObservableCollection<ComplaintsRecord> records = new ObservableCollection<ComplaintsRecord>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT country, province, district, tehsil, officeid, fullname, nicnumber, email, dailingcode, contactnumber, complaint FROM dbo.complaints";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        records.Add(new ComplaintsRecord
                        {
                            Country = reader["country"].ToString(),
                            Province = reader["province"].ToString(),
                            District = reader["district"].ToString(),
                            Tehsil = reader["tehsil"].ToString(),
                            OfficeID = reader["officeid"].ToString(),
                            FullName = reader["fullname"].ToString(),
                            NICNumber = reader["nicnumber"].ToString(),
                            Email = reader["email"].ToString(),
                            DailingCode = reader["dailingcode"].ToString(),
                            ContactNumber = reader["contactnumber"].ToString(),
                            Complaint = reader["complaint"].ToString(),
                        });
                    }
                    reader.Close();

                    Complaint_Record.ItemsSource = records;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void LOGOUT_MI_Click(object sender, RoutedEventArgs e)
        {
            WelcomeScreen welcomeScreen = new WelcomeScreen();
            welcomeScreen.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (NIC_Record.SelectedItem is Record1 nicSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM dbo.nic WHERE firstname = @FirstName AND lastname = @LastName AND fathername = @FatherName";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@FirstName", nicSelectedRecord.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", nicSelectedRecord.LastName);
                        cmd.Parameters.AddWithValue("@FatherName", nicSelectedRecord.FatherName);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            NIC_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be deleted.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (JVC_Record.SelectedItem is Record2 jvcSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM dbo.jvc WHERE firstname = @FirstName AND lastname = @LastName AND fathernic = @FatherNic";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", jvcSelectedRecord.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", jvcSelectedRecord.LastName);
                        cmd.Parameters.AddWithValue("@FatherNic", jvcSelectedRecord.FatherNic);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            JVC_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be deleted.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (CRC_Record.SelectedItem is Record2 crcSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM dbo.crc WHERE firstname = @FirstName AND lastname = @LastName AND fathernic = @FatherNic";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", crcSelectedRecord.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", crcSelectedRecord.LastName);
                        cmd.Parameters.AddWithValue("@FatherNic", crcSelectedRecord.FatherNic);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            CRC_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be deleted.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (FRC_Record.SelectedItem is FRCRecord frcSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM dbo.frc WHERE fathername = @FatherName AND fathernic = @FatherNic AND mothernic = @MotherNic";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FatherName", frcSelectedRecord.FatherName);
                        cmd.Parameters.AddWithValue("@FatherNic", frcSelectedRecord.FatherNIC);
                        cmd.Parameters.AddWithValue("@MotherNic", frcSelectedRecord.MotherNIC);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            FRC_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be deleted.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (POC_Record.SelectedItem is POCRecord pocSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM dbo.poc WHERE firstname = @FirstName AND lastname = @LastName AND fathername = @FatherName";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", pocSelectedRecord.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", pocSelectedRecord.LastName);
                        cmd.Parameters.AddWithValue("@FatherName", pocSelectedRecord.FatherName);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            POC_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be deleted.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (NICOP_Record.SelectedItem is Record1 nicopSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM dbo.nicop WHERE firstname = @FirstName AND lastname = @LastName AND fathername = @FatherName";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", nicopSelectedRecord.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", nicopSelectedRecord.LastName);
                        cmd.Parameters.AddWithValue("@FatherName", nicopSelectedRecord.FatherName);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            NICOP_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be deleted.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (Complaint_Record.SelectedItem is ComplaintsRecord complaintSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM dbo.complaints WHERE fullname = @FullName AND nicnumber = @NICNumber AND officeid = @OfficeID";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FullName", complaintSelectedRecord.FullName);
                        cmd.Parameters.AddWithValue("@NICNumber", complaintSelectedRecord.NICNumber);
                        cmd.Parameters.AddWithValue("@OfficeID", complaintSelectedRecord.OfficeID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            COMP_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be deleted.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (NIC_Record.SelectedItem is Record1 nicSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE dbo.nic SET firstname = @FirstName, lastname = @LastName, fathername = @FatherName, dateofbirth = @DOB, gender = @Gender, religion = @Religion, address = @Address WHERE firstname = @OldFirstName AND lastname = @OldLastName AND fathername = @OldFatherName";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", nicSelectedRecord.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", nicSelectedRecord.LastName);
                        cmd.Parameters.AddWithValue("@FatherName", nicSelectedRecord.FatherName);
                        cmd.Parameters.AddWithValue("@DOB", nicSelectedRecord.DOB);
                        cmd.Parameters.AddWithValue("@Gender", nicSelectedRecord.Gender);
                        cmd.Parameters.AddWithValue("@Religion", nicSelectedRecord.Religion);
                        cmd.Parameters.AddWithValue("@Address", nicSelectedRecord.Address);

                        cmd.Parameters.AddWithValue("@OldFirstName", nicSelectedRecord.FirstName);  
                        cmd.Parameters.AddWithValue("@OldLastName", nicSelectedRecord.LastName);    
                        cmd.Parameters.AddWithValue("@OldFatherName", nicSelectedRecord.FatherName); 
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            NIC_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be updated.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (JVC_Record.SelectedItem is Record2 jvcSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE dbo.jvc SET firstname = @FirstName, lastname = @LastName, fathername = @FatherName, fathernic = @FatherNic, dateofbirth = @DOB, gender = @Gender, religion = @Religion, address = @Address WHERE firstname = @OldFirstName AND lastname = @OldLastName AND fathername = @OldFatherName";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", jvcSelectedRecord.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", jvcSelectedRecord.LastName);
                        cmd.Parameters.AddWithValue("@FatherName", jvcSelectedRecord.FatherName);
                        cmd.Parameters.AddWithValue("@FatherNic", jvcSelectedRecord.FatherNic);
                        cmd.Parameters.AddWithValue("@DOB", jvcSelectedRecord.DOB);
                        cmd.Parameters.AddWithValue("@Gender", jvcSelectedRecord.Gender);
                        cmd.Parameters.AddWithValue("@Religion", jvcSelectedRecord.Religion);
                        cmd.Parameters.AddWithValue("@Address", jvcSelectedRecord.Address);

                        // Old values for identifying the record to update
                        cmd.Parameters.AddWithValue("@OldFirstName", jvcSelectedRecord.FirstName);  
                        cmd.Parameters.AddWithValue("@OldLastName", jvcSelectedRecord.LastName);    
                        cmd.Parameters.AddWithValue("@OldFatherName", jvcSelectedRecord.FatherName); 

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            JVC_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be updated.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (CRC_Record.SelectedItem is Record2 crcSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE dbo.crc SET firstname = @FirstName, lastname = @LastName, fathername = @FatherName, fathernic = @FatherNic, dateofbirth = @DOB, gender = @Gender, religion = @Religion, address = @Address WHERE firstname = @OldFirstName AND lastname = @OldLastName AND fathername = @OldFatherName";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", crcSelectedRecord.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", crcSelectedRecord.LastName);
                        cmd.Parameters.AddWithValue("@FatherName", crcSelectedRecord.FatherName);
                        cmd.Parameters.AddWithValue("@FatherNic", crcSelectedRecord.FatherNic);
                        cmd.Parameters.AddWithValue("@DOB", crcSelectedRecord.DOB);
                        cmd.Parameters.AddWithValue("@Gender", crcSelectedRecord.Gender);
                        cmd.Parameters.AddWithValue("@Religion", crcSelectedRecord.Religion);
                        cmd.Parameters.AddWithValue("@Address", crcSelectedRecord.Address);

                        // Old values for identifying the record to update
                        cmd.Parameters.AddWithValue("@OldFirstName", crcSelectedRecord.FirstName);  
                        cmd.Parameters.AddWithValue("@OldLastName", crcSelectedRecord.LastName);    
                        cmd.Parameters.AddWithValue("@OldFatherName", crcSelectedRecord.FatherName); 

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            CRC_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be updated.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (FRC_Record.SelectedItem is FRCRecord frcSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE dbo.frc SET mothername = @MotherName, applicantname = @ApplicantName, relationship = @Relationship, frn = @FRN, numberofmembers = @FamilyMembers, religion = @Religion, permanentaddress = @PermanentAddress, currentaddress = @CurrentAddress WHERE fathername = @FatherName AND fathernic = @FatherNic AND mothernic = @MotherNic";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FatherName", frcSelectedRecord.FatherName);
                        cmd.Parameters.AddWithValue("@FatherNic", frcSelectedRecord.FatherNIC);
                        cmd.Parameters.AddWithValue("@MotherNic", frcSelectedRecord.MotherNIC);
                        cmd.Parameters.AddWithValue("@MotherName", frcSelectedRecord.MotherName);
                        cmd.Parameters.AddWithValue("@ApplicantName", frcSelectedRecord.ApplicantName);
                        cmd.Parameters.AddWithValue("@Relationship", frcSelectedRecord.Relationship);
                        cmd.Parameters.AddWithValue("@FRN", frcSelectedRecord.FRN);
                        cmd.Parameters.AddWithValue("@FamilyMembers", frcSelectedRecord.FamilyMembers);
                        cmd.Parameters.AddWithValue("@Religion", frcSelectedRecord.Religion);
                        cmd.Parameters.AddWithValue("@PermanentAddress", frcSelectedRecord.PermanentAddress);
                        cmd.Parameters.AddWithValue("@CurrentAddress", frcSelectedRecord.CurrentAddress);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            FRC_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be updated.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (POC_Record.SelectedItem is POCRecord pocSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE dbo.poc SET dateofbirth = @DOB, gender = @Gender, religion = @Religion, nationality = @Nationality, maritalstatus = @MaritalStatus, passportnumber = @PassportNumber WHERE firstname = @FirstName AND lastname = @LastName AND fathername = @FatherName";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", pocSelectedRecord.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", pocSelectedRecord.LastName);
                        cmd.Parameters.AddWithValue("@FatherName", pocSelectedRecord.FatherName);
                        cmd.Parameters.AddWithValue("@DOB", pocSelectedRecord.DOB);
                        cmd.Parameters.AddWithValue("@Gender", pocSelectedRecord.Gender);
                        cmd.Parameters.AddWithValue("@Religion", pocSelectedRecord.Religion);
                        cmd.Parameters.AddWithValue("@Nationality", pocSelectedRecord.Nationality);
                        cmd.Parameters.AddWithValue("@MaritalStatus", pocSelectedRecord.MaritalStatus);
                        cmd.Parameters.AddWithValue("@PassportNumber", pocSelectedRecord.PassportNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            POC_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be updated.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (NICOP_Record.SelectedItem is Record1 nicopSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE dbo.nicop SET dateofbirth = @DOB, gender = @Gender, religion = @Religion, address = @Address WHERE firstname = @FirstName AND lastname = @LastName AND fathername = @FatherName";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", nicopSelectedRecord.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", nicopSelectedRecord.LastName);
                        cmd.Parameters.AddWithValue("@FatherName", nicopSelectedRecord.FatherName);
                        cmd.Parameters.AddWithValue("@DOB", nicopSelectedRecord.DOB);
                        cmd.Parameters.AddWithValue("@Gender", nicopSelectedRecord.Gender);
                        cmd.Parameters.AddWithValue("@Religion", nicopSelectedRecord.Religion);
                        cmd.Parameters.AddWithValue("@Address", nicopSelectedRecord.Address);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            NICOP_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be updated.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else if (Complaint_Record.SelectedItem is ComplaintsRecord complaintSelectedRecord)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE complaints SET country = @Country, province = @Province, district = @District, tehsil = @Tehsil, email = @Email, dailingcode = @DailingCode, contactnumber = @ContactNumber, complaint = @Complaint WHERE fullname = @FullName AND nicnumber = @NICNumber AND officeid = @OfficeID";

                        SqlCommand cmd = new SqlCommand(query, connection);

                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FullName", complaintSelectedRecord.FullName);
                        cmd.Parameters.AddWithValue("@NICNumber", complaintSelectedRecord.NICNumber);
                        cmd.Parameters.AddWithValue("@OfficeID", complaintSelectedRecord.OfficeID);
                        cmd.Parameters.AddWithValue("@Country", complaintSelectedRecord.Country);
                        cmd.Parameters.AddWithValue("@Province", complaintSelectedRecord.Province);
                        cmd.Parameters.AddWithValue("@District", complaintSelectedRecord.District);
                        cmd.Parameters.AddWithValue("@Tehsil", complaintSelectedRecord.Tehsil);
                        cmd.Parameters.AddWithValue("@Email", complaintSelectedRecord.Email);
                        cmd.Parameters.AddWithValue("@DailingCode", complaintSelectedRecord.DailingCode);
                        cmd.Parameters.AddWithValue("@ContactNumber", complaintSelectedRecord.ContactNumber);
                        cmd.Parameters.AddWithValue("@Complaint", complaintSelectedRecord.Complaint);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                            COMP_ViewMI_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or couldn't be updated.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchBox.Text.Trim();
            SearchBox.Clear();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (NIC_Record.Visibility == Visibility.Visible)
                    {
                        string query = @"
                    SELECT firstname, lastname, fathername, dateofbirth, gender, religion, address 
                    FROM dbo.nic 
                    WHERE firstname LIKE @SearchTerm";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchText + "%");

                        SqlDataReader reader = cmd.ExecuteReader();
                        var records = new List<Record1>();

                        while (reader.Read())
                        {
                            records.Add(new Record1
                            {
                                FirstName = reader["firstname"].ToString(),
                                LastName = reader["lastname"].ToString(),
                                FatherName = reader["fathername"].ToString(),
                                DOB = reader["dateofbirth"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Religion = reader["religion"].ToString(),
                                Address = reader["address"].ToString()
                            });
                        }

                        reader.Close();
                        NIC_Record.ItemsSource = records;
                    }
                    else if (NICOP_Record.Visibility == Visibility.Visible)
                    {
                        string query = @"
                    SELECT firstname, lastname, fathername, dateofbirth, gender, religion, address 
                    FROM dbo.nicop 
                    WHERE firstname LIKE @SearchTerm";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchText + "%");

                        SqlDataReader reader = cmd.ExecuteReader();
                        var records = new List<Record1>();

                        while (reader.Read())
                        {
                            records.Add(new Record1
                            {
                                FirstName = reader["firstname"].ToString(),
                                LastName = reader["lastname"].ToString(),
                                FatherName = reader["fathername"].ToString(),
                                DOB = reader["dateofbirth"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Religion = reader["religion"].ToString(),
                                Address = reader["address"].ToString()
                            });
                        }

                        reader.Close();
                        NICOP_Record.ItemsSource = records;
                    }
                    else if (JVC_Record.Visibility == Visibility.Visible)
                    {
                        string query = @"
                    SELECT firstname, lastname, fathername, dateofbirth, gender, religion, address, fathernic 
                    FROM dbo.jvc 
                    WHERE firstname LIKE @SearchTerm";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchText + "%");

                        SqlDataReader reader = cmd.ExecuteReader();
                        var records = new List<Record2>();

                        while (reader.Read())
                        {
                            records.Add(new Record2
                            {
                                FirstName = reader["firstname"].ToString(),
                                LastName = reader["lastname"].ToString(),
                                FatherName = reader["fathername"].ToString(),
                                FatherNic = reader["fathernic"].ToString(),
                                DOB = reader["dateofbirth"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Religion = reader["religion"].ToString(),
                                Address = reader["address"].ToString()
                            });
                        }

                        reader.Close();
                        JVC_Record.ItemsSource = records;
                    }
                    else if (CRC_Record.Visibility == Visibility.Visible)
                    {
                        string query = @"
                    SELECT firstname, lastname, fathername, dateofbirth, gender, religion, address 
                    FROM dbo.crc 
                    WHERE firstname LIKE @SearchTerm";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchText + "%");

                        SqlDataReader reader = cmd.ExecuteReader();
                        var records = new List<Record2>();

                        while (reader.Read())
                        {
                            records.Add(new Record2
                            {
                                FirstName = reader["firstname"].ToString(),
                                LastName = reader["lastname"].ToString(),
                                FatherName = reader["fathername"].ToString(),
                                DOB = reader["dateofbirth"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Religion = reader["religion"].ToString(),
                                Address = reader["address"].ToString()
                            });
                        }

                        reader.Close();
                        CRC_Record.ItemsSource = records;
                    }
                    else if (POC_Record.Visibility == Visibility.Visible)
                    {
                        string query = @"
                        SELECT firstname, lastname, fathername, dateofbirth, gender, religion, nationality, maritalstatus, passportnumber 
                        FROM dbo.poc
                        WHERE firstname LIKE @SearchTerm";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchText + "%");

                        SqlDataReader reader = cmd.ExecuteReader();
                        var records = new List<POCRecord>();

                        while (reader.Read())
                        {
                            records.Add(new POCRecord
                            {
                                FirstName = reader["firstname"].ToString(),
                                LastName = reader["lastname"].ToString(),
                                FatherName = reader["fathername"].ToString(),
                                DOB = reader["dateofbirth"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Religion = reader["religion"].ToString(),
                                Nationality = reader["nationality"].ToString(),
                                MaritalStatus = reader["maritalstatus"].ToString(),
                                PassportNumber = reader["passportnumber"].ToString()
                            });
                        }

                        reader.Close();
                        POC_Record.ItemsSource = records;
                    }
                    else if (FRC_Record.Visibility == Visibility.Visible)
                    {
                        string query = @"
                    SELECT fathername, fathernic, mothername, mothernic, applicantname, applicantnic, relationship, frn, numberofmembers, religion, permanentaddress, currentaddress 
                    FROM dbo.frc
                    WHERE applicantname LIKE @SearchTerm";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchText + "%");

                        SqlDataReader reader = cmd.ExecuteReader();
                        var records = new List<FRCRecord>();

                        while (reader.Read())
                        {
                            records.Add(new FRCRecord
                            {
                                FatherName = reader["fathername"].ToString(),
                                FatherNIC = reader["fathernic"].ToString(),
                                MotherName = reader["mothername"].ToString(),
                                MotherNIC = reader["mothernic"].ToString(),
                                ApplicantName = reader["applicantname"].ToString(),
                                ApplicantNIC = reader["applicantnic"].ToString(),
                                Relationship = reader["relationship"].ToString(),
                                FRN = reader["frn"].ToString(),
                                FamilyMembers = reader["numberofmembers"].ToString(),
                                Religion = reader["religion"].ToString(),
                                PermanentAddress = reader["permanentaddress"].ToString(),
                                CurrentAddress = reader["currentaddress"].ToString()
                            });
                        }

                        reader.Close();
                        FRC_Record.ItemsSource = records;
                    }
                    else if (Complaint_Record.Visibility == Visibility.Visible)
                    {
                        string query = @"
                    SELECT country, province, district, tehsil, officeid, fullname, nicnumber, email, dailingcode, contactnumber, complaint 
                    FROM dbo.complaints 
                    WHERE fullname LIKE @SearchTerm";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchText + "%");

                        SqlDataReader reader = cmd.ExecuteReader();
                        var records = new List<ComplaintsRecord>();

                        while (reader.Read())
                        {
                            records.Add(new ComplaintsRecord
                            {
                                Country = reader["country"].ToString(),
                                Province = reader["province"].ToString(),
                                District = reader["district"].ToString(),
                                Tehsil = reader["tehsil"].ToString(),
                                OfficeID = reader["officeid"].ToString(),
                                FullName = reader["fullname"].ToString(),
                                NICNumber = reader["nicnumber"].ToString(),
                                Email = reader["email"].ToString(),
                                DailingCode = reader["dailingcode"].ToString(),
                                ContactNumber = reader["contactnumber"].ToString(),
                                Complaint = reader["complaint"].ToString(),
                            });
                        }

                        reader.Close();
                        Complaint_Record.ItemsSource = records;
                    }
                    else
                    {
                        MessageBox.Show("No grid is visible.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
        }



    }
}
