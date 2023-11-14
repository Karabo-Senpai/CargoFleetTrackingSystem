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
    public partial class UpdateService : UserControl
    {
        //Declaring And Assigning Variables
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");
        DatabaseConnection databaseConnection = new DatabaseConnection();

        string ServiceID;
        string VMake;
        string VModel;
        string NP;
        string Milage;
        DateTime Date;
        string Prob;
        string Status;

        public UpdateService()
        {
            InitializeComponent();

            //Displaying All Infomation
            DisplayServiceInfo();
        }

        private void DisplayServiceInfo()
        {
            //Opening Database Connecion
            conn.Open();

            DataTable dataTable = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.LoadEmployees());

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            
            //Close SQL Connection
            conn.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Opening Sql Connection
            conn.Open();

            SqlCommand command = databaseConnection.UpdateService(tb_VMak.Text, tb_VModel.Text, tb_NP.Text, tb_Milage.Text, dateTimePicker1.Value.ToString(), tb_Problem.Text, tb_Status.Text, ServiceID.ToString());

            command.Parameters.AddWithValue("@Vehicle_Make", tb_VMak.Text);
            command.Parameters.AddWithValue("@Vehicle_Model", tb_VModel.Text);
            command.Parameters.AddWithValue("@Number_Plate", tb_NP.Text);
            command.Parameters.AddWithValue("@Total_Milage", tb_Milage.Text);
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("@Problem", tb_Problem.Text);
            command.Parameters.AddWithValue("@Status", tb_Status.Text);

            command.ExecuteNonQuery();

            //Resetting Text After Data Is Updated
            tb_VMak.ResetText();
            tb_VModel.ResetText();
            tb_NP.ResetText();
            tb_Milage.ResetText();
            dateTimePicker1.ResetText();
            tb_Problem.ResetText();
            tb_Status.ResetText();

            //Closing Sql Connection 
            conn.Close();

        }
        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            //Opening Sql Connection 
            conn.Open();
            databaseConnection.DeleteService(tb_VMak.Text, ServiceID.ToString());

            tb_VMak.ResetText();
            tb_VModel.ResetText();
            tb_NP.ResetText();
            tb_Milage.ResetText();
            dateTimePicker1.ResetText();
            tb_Problem.ResetText();
            tb_Status.ResetText();

            //Closing Sql Connection 
            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ServiceID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb_VMak.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb_VModel.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_NP.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tb_Milage.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                tb_Problem.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tb_Status.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();


                VMake = tb_VMak.Text;
                VModel = tb_VModel.Text;
                NP = tb_NP.Text;
                Milage = tb_Milage.Text;
                Date = Convert.ToDateTime(dateTimePicker1.ToString());
                Prob = tb_Problem.Text;
                Status = tb_Status.Text;
            }
            catch (Exception)
            {

                tb_VMak.Text = "";
                tb_VModel.Text = "";
                tb_NP.Text = "";
                tb_Milage.Text = "";
                dateTimePicker1.Text = "";
                tb_Problem.Text = "";
                tb_Status.Text = "";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UpdateService_Load(object sender, EventArgs e)
        {

        }
    }
}
