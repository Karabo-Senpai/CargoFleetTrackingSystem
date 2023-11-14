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

namespace CargoFleetTrackingSystem
{
    public partial class Register : Form
    {
        //Creating Sql Connection String To Access The Database
        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {

        }

        //Switching To login Form When Link Is Clicked
        private void logLinkBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecting User To Login Form If They Already Have An Account
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //Minimizing Application
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            //Minimizing Window That Is Currently Opened
            this.WindowState = FormWindowState.Minimized;


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


        //Closing Application When Close Icon Is Clicked
        private void button1_Click(object sender, EventArgs e)
        {
            //Closing Application When Exit Button Is Press
            if (MessageBox.Show("Are You Sure You Want To Close The Application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        // Signing In User When A New User Creates An Account
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            //Using Sql Command To Write SQL Queries
            SqlCommand command = sqlConnection.CreateCommand();

            //Inserting Newly Created User Into The Users Table
            command.CommandText = "Insert Into [Users] (FirstName,LastName,DOB,Address,Username,Password) Values (@FirstName,@LastName,@DOB,@Address,@Username,@Password) ";
            command.Parameters.AddWithValue("@FirstName", tb_FirstName.Text);       
            command.Parameters.AddWithValue("@LastName", tb_LastName.Text);
            command.Parameters.AddWithValue("@DOB", DTP_Age.Value.ToString());
            command.Parameters.AddWithValue("@Address", tb_Address.Text);
            command.Parameters.AddWithValue("@Username", tb_Username.Text);
            command.Parameters.AddWithValue("@Password", hashUserPassword(tb_Password.Text));
         
            //Opening Sql Connection 

            sqlConnection.Open();

            //Exception Handling

            try
            {
                //Running Execute None Query Script
                command.ExecuteNonQuery();

                //Alerting That User Data Has Been Inserted Into The Database
                MessageBox.Show("User Successfully Created", "New User Created",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                Login login = new Login();
                login.Show();
                this.Close();
            }
            catch (Exception)
            {

              
            }
            //Closing Sql Connection
            sqlConnection.Close();  

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
