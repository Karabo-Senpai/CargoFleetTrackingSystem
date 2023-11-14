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
    public partial class UpdateVehicle : UserControl
    {

        //Declaring And Assigning Variables
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");
        DatabaseConnection databaseConnection = new DatabaseConnection();

        string VehicleID;
        string Vehicle_Make;
        string Vehicle_Model;
        string Vehicle_Year;
        string VIN;
        string Engine_Size;
        string NP;
        string Capacity;
        string Status;
        string V_status;

        public UpdateVehicle()
        {
            InitializeComponent();

            //Displaying All Infomation
            DisplayVehicleInfo();
        }

        public void DisplayVehicleInfo()
        {
            //Opening Database Connecion
            conn.Open();

            DataTable dataTable = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.LoadVehicles());

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                VehicleID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb_Make.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb_Model.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_Year.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tb_VIN.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tb_EngineSize.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                tb_NP.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tb_Capacity.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                tb_Status.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();


                Vehicle_Make = tb_Make.Text;
                Vehicle_Model = tb_Model.Text;
                Vehicle_Year = tb_Year.Text;
                VIN = tb_VIN.Text;
                Engine_Size = tb_EngineSize.Text;
                NP = tb_NP.Text;
                Capacity = tb_Capacity.Text;
                V_status = tb_Status.Text;
            }
            catch (Exception)
            {

                tb_Make.Text = "";
                tb_Model.Text = "";
                tb_Year.Text = "";
                tb_VIN.Text = "";
                tb_EngineSize.Text = "";
                tb_NP.Text = "";
                tb_Capacity.Text = "";
                tb_Status.Text = "";
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand command = databaseConnection.UpdateVehicles(tb_Make.Text, tb_Model.Text, tb_Year.Text, tb_VIN.Text, tb_EngineSize.Text, tb_NP.Text, tb_Capacity.Text, tb_Status.Text, VehicleID.ToString());

            command.Parameters.AddWithValue("@Vehical_Make", tb_Make.Text);
            command.Parameters.AddWithValue("@Vehical_Model", tb_Model.Text);
            command.Parameters.AddWithValue("@Vehical_Year", tb_Year.Text);
            command.Parameters.AddWithValue("@VIN_Number", tb_VIN.Text);
            command.Parameters.AddWithValue("@Engine_Size", tb_EngineSize.Text);
            command.Parameters.AddWithValue("@Number_Plate", tb_NP.Text);
            command.Parameters.AddWithValue("@Capacity", tb_Capacity.Text);
            command.Parameters.AddWithValue("@Status", tb_Status.Text);


            //Openning SQL Connection
            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();

            tb_Make.ResetText();
            tb_Model.ResetText();
            tb_Year.ResetText();
            tb_VIN.ResetText();
            tb_EngineSize.ResetText();
            tb_NP.ResetText();
            tb_Capacity.ResetText();
            tb_Status.ResetText();

        }
    }
}
