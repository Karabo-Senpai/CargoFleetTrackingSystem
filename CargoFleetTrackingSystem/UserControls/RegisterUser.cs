using CargoFleetTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CargoFleetTrackingSystem.UserControls
{
    public partial class RegisterUser : UserControl
    {

        //Declaring Database Connection String
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");

        //Creating Database Connection Class Object
        DatabaseConnection databaseConnection = new DatabaseConnection();

        DataTable dataTable;



        public RegisterUser()
        {
            InitializeComponent();

            //Setting Default Combobox Value To 0 
            cb_UserRole.SelectedIndex = 0;
        }

        //Method To Hash User Password To Be Stored In The Database
        public static string hashUserPassword(string password)
        {
            //Calling hashing class
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypted_bytes);
        }


        //Siging Up New User When Register Button Is Pressed
        private void reg_Btn_Click(object sender, EventArgs e)
        {
           
            //Checking If No Field Is Left Null
            if (tb_FirstName.Text == "" || tb_LastName.Text == "" || DTP_Age.Text == "" || tb_Address.Text == "" ||
            tb_Username.Text == "" || tb_Password.Text == "" || cb_UserRole.SelectedItem.ToString() == "Select")
            {
                MessageBox.Show("Please Fill In All Fields");
            }

            else
            {
                dataTable = databaseConnection.LogUserIn(tb_Username.Text);

                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Sorry Your Chosen Username Is Already In Use");
                }

                else
                {
                    //Using Sql Command To Write SQL Queries
                    SqlCommand command = databaseConnection.create();

                    //Inserting Newly Created User Into The Users Table
                    command.CommandText = "Insert Into [Users] (FirstName,LastName,DOB,Address,Username,Password,UserRole) Values (@FirstName,@LastName,@DOB,@Address,@Username,@Password,@UserRole) ";
                    command.Parameters.AddWithValue("@FirstName", tb_FirstName.Text);
                    command.Parameters.AddWithValue("@LastName", tb_LastName.Text);
                    command.Parameters.AddWithValue("@DOB", DTP_Age.Value.ToString());
                    command.Parameters.AddWithValue("@Address", tb_Address.Text);
                    command.Parameters.AddWithValue("@Username", tb_Username.Text);
                    command.Parameters.AddWithValue("@Password", hashUserPassword(tb_Password.Text));
                    command.Parameters.AddWithValue("@UserRole", cb_UserRole.SelectedItem.ToString());

                    //Opening Database Connection
                    conn.Open();

                    //Executing Insert Command
                    command.ExecuteNonQuery();

                    //Closing Database Connection
                    conn.Close();

                    //Alerting That User Data Has Been Inserted Into The Database
                    MessageBox.Show("User Successfully Created", "New User Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
