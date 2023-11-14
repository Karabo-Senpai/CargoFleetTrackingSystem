using CargoFleetTrackingSystem.Models;
using CargoFleetTrackingSystem.UserDashboardInterfaces;
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
    public partial class Login : Form

        
        //Initialising Database Connection String
    {   

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");
    
        DatabaseConnection databaseConnection = new DatabaseConnection();
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             //Redirecting User To Register Form If They Do Not Have An Account
             Register register = new Register();
             register.Show();
             this.Hide();

        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            //Minimizing Window That Is Currently Opened
            this.WindowState = FormWindowState.Minimized;


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Closing Application When Exit Button Is Pressed


            if (MessageBox.Show("Are You Sure You Want To Close The Application?", "Close Application", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Environment.Exit(0);

            }

          

             
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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


        //Logging User In
        private void signInBtn_Click(object sender, EventArgs e)
        {
            //Comparing Username And Password Provided By The User With The One In The Database

            conn.Open();
            DataTable dataTable = databaseConnection.Users(tb_Username.Text, hashUserPassword(tb_Password.Text));

            //Checking If All Fields Have Input
            if (string.IsNullOrEmpty(tb_Username.Text) || string.IsNullOrWhiteSpace(tb_Username.Text))
            {
                MessageBox.Show("Username Cannot Be Empty","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tb_Username.Focus();
            
            }

            else {

                if (string.IsNullOrEmpty(hashUserPassword(tb_Password.Text)) || string.IsNullOrWhiteSpace(hashUserPassword(tb_Password.Text)))
                {
                    MessageBox.Show("Password Cannot Be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Password.Focus();
                }

                else
                {
                    //Nested If Statements To Check If The Such A User Exists Or Not

                    //
                    if (dataTable.Rows.Count == 1)
                    {
                        //Switch Statement That Will Be Triggered If A User Is Of A Certain Role
                        switch (dataTable.Rows[0]["UserRole"] as string)
                        {
                            case "Office Manager":
                                {
                                    this.Hide();
                                    String RoleID = dataTable.Rows[0]["EmpID"].ToString();
                                    OfficeManager officeManager = new OfficeManager(RoleID); 
                                    officeManager.Show();
                                    break;
                                }
                        }


                    }



                }

                conn.Close();
                }

        }
    }
}
