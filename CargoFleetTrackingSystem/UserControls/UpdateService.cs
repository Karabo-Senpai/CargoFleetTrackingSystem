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
        string Date;
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

            conn.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand command = databaseConnection.UpdateService(tb_VMak.Text, tb_VModel.Text, tb_NP.Text, tb_Milage.Text, dateTimePicker1.ToString(), tb_Problem.Text, tb_Status.Text, ServiceID.ToString());




        }
        private void Btn_Remove_Click(object sender, EventArgs e)
        {

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
                Date = dateTimePicker1.ToString();
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

     
    }
}
