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
    public partial class UpdateFuelConsumption : UserControl
    {

        //Declaring and and Initialising Database Connection Object 
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");
        DatabaseConnection databaseConnection = new DatabaseConnection();

        //Declaring Global Variables To Be Used For Data The User Has Inputted In The Textbox
        string fuel_ID;
        string number_Plate;
        double mbefore_Trip;
        double mafter_Trip;
        double fuel_Price;
        public UpdateFuelConsumption()
        {
            InitializeComponent();

            //Calling Display Fuel Consumption Information Method
            FuelConsumptionInfoDisplay();
        }

        //Method To Display Fuel Consumption Information
        public void FuelConsumptionInfoDisplay()
        {
            //Opening Database Connecion
            conn.Open();

            DataTable dataTable = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.LoadFuelCon());

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            //Closing SQL Connection
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Error Handling For When Data Is To Be Retrieved and Dispalyed On The Datatable and any other error 
            try
            {
                fuel_ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb_NP.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb_BeforeTrip.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb_AfterTrip.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                //Getting Data That Was Selected and Assigning them to declared variables
                number_Plate = tb_NP.Text;
                mbefore_Trip = Convert.ToDouble(tb_BeforeTrip.Text);
                mafter_Trip = Convert.ToDouble(tb_AfterTrip.Text);
                fuel_Price = Convert.ToDouble(tbPrice.Text);
            }

            catch (Exception)
            {
                //Catching Any errors that may arise if data retrieval fails
                tb_NP.Text = "";
                tb_BeforeTrip.Text = "";
                tb_AfterTrip.Text = "";
                tbPrice.Text = "";
            }
        }

        //Method For When Update Button Is Clicked 
         private void btn_Update_Click(object sender, EventArgs e)
        {
            //Opening Sql Connection 
            conn.Open();

            //Sql Command To Write Update Query
            SqlCommand sqlCommand = databaseConnection.UpdateFuelCon(tb_NP.Text, Convert.ToDouble(tb_BeforeTrip.Text), Convert.ToDouble(tb_AfterTrip.Text), Convert.ToDouble(tbPrice.Text), fuel_ID.ToString());
            sqlCommand.Parameters.AddWithValue("@Number_Plate", tb_NP.Text);
            sqlCommand.Parameters.AddWithValue("@L_B_T", tb_BeforeTrip.Text);
            sqlCommand.Parameters.AddWithValue("@L_A_T", tb_AfterTrip.Text);
            sqlCommand.Parameters.AddWithValue("@PPL", tbPrice.Text);

            sqlCommand.ExecuteNonQuery();

            tb_NP.ResetText();
            tb_BeforeTrip.ResetText();
            tb_AfterTrip.ResetText();
            tbPrice.ResetText();

            //Closing Sql Connection
            conn.Close();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            //Opening Sql Connection 
            conn.Open();

            databaseConnection.DeleteFuelCon(tb_NP.Text, fuel_ID.ToString());

            tb_NP.ResetText();
            tb_BeforeTrip.ResetText();
            tb_AfterTrip.ResetText();
            tbPrice.ResetText();
        }
    }
}
