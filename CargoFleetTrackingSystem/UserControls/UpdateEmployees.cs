using CargoFleetTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoFleetTrackingSystem.UserControls
{
    public partial class UpdateEmployees : UserControl
    {
        //Declaring And Assigning Variables
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");
        DatabaseConnection databaseConnection = new DatabaseConnection();

        string UserID;
        string FirstName;
        string LastName;
        string DOB;
        string Address;
        string Username;
        string Password;
        string Role;

        public UpdateEmployees()
        {
            InitializeComponent();

            //Displaying All Infomation
            DisplayEmployeeInfo();
        }

        public void DisplayEmployeeInfo()
        {
            //Opening Database Connecion
            conn.Open();

            DataTable dataTable = new DataTable();  

            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.LoadEmployees());

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            //Closing SQL Connection
            conn.Close();
        }

        private void tb_Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            databaseConnection.DeleteLogin(tb_Firstname.Text, UserID.ToString());
           
            tb_Firstname.ResetText();
            tb_Surename.ResetText();
            tb_DOB.ResetText();
            tb_Address.ResetText();
            tb_Username.ResetText();
            tb_Password.ResetText();
            tb_Role.ResetText();

            MessageBox.Show("User Data Has Been Successfully Deleted", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            //Sql Command To Execute And Write Sql Query Statement
            SqlCommand command = databaseConnection.UpdateEmployees(tb_Firstname.Text, tb_Surename.Text, tb_DOB.Text, tb_Address.Text, tb_Username.Text, tb_Password.Text, tb_Role.Text, UserID.ToString());

            command.Parameters.AddWithValue("@FirstName", tb_Firstname.Text);
            command.Parameters.AddWithValue("@LastName", tb_Surename.Text);
            command.Parameters.AddWithValue("@DOB", tb_DOB.Text);
            command.Parameters.AddWithValue("@Address", tb_Address.Text);
            command.Parameters.AddWithValue("@Username", tb_Username.Text);
            command.Parameters.AddWithValue("@Password", tb_Password.Text);
            command.Parameters.AddWithValue("@UserRole", tb_Role.Text);
          
            //Openning SQL Connection
            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();

            tb_Firstname.ResetText();
            tb_Surename.ResetText();
            tb_DOB.ResetText();
            tb_Address.ResetText();
            tb_Username.ResetText();
            tb_Password.ResetText();
            tb_Role.ResetText();

            MessageBox.Show("User Data Has Been Successfully Updated", "User Info Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                UserID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb_Firstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb_Surename.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_DOB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tb_Address.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tb_Username.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                tb_Password.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tb_Role.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();


                FirstName = tb_Firstname.Text;
                LastName = tb_Surename.Text;
                DOB = tb_DOB.Text;
                Address = tb_Address.Text;
                Username = tb_Username.Text;
                Password = tb_Password.Text;
                Role = tb_Role.Text;
            }
            catch (Exception)
            {

                tb_Firstname.Text = "";
                tb_Surename.Text = "";
                tb_DOB.Text = "";
                tb_Address.Text = "";
                tb_Username.Text = "";
                tb_Password.Text = "";
                tb_Role.Text = "";
            }
        }
    }
}
