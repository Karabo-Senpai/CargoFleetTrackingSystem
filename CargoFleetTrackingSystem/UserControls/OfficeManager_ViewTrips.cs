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
    public partial class OfficeManager_ViewTrips : UserControl
    {

        //Declaring Database Connection String
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");

        //Creating Database Connection Class Object
        DatabaseConnection databaseConnection = new DatabaseConnection();

     

        public OfficeManager_ViewTrips()
        {
            InitializeComponent();
        }

        private void panelOfficeManagerViewTrips_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            // Creating Datatable
            DataTable dataTable = new DataTable();

            //Sql Data Adapter
            SqlDataAdapter dataAdapter;

            // Initialising Data Adapter To Read And Retrieve All Trip Data 
            dataAdapter = new SqlDataAdapter(databaseConnection.Complete());

            //Filling Trip Data Into Datatable
            dataAdapter.Fill(dataTable);

            //Passing Datatable Data Into Data Grid View
            dataGridView1.DataSource = dataTable;
        }

        private void btn_PendingTrips_Click(object sender, EventArgs e)
        {
            // Creating Datatable
            DataTable dataTable = new DataTable();

            //Sql Data Adapter
            SqlDataAdapter dataAdapter;

            // Initialising Data Adapter To Read And Retrieve All Trip Data 
            dataAdapter = new SqlDataAdapter(databaseConnection.PendingStatus());

            //Filling Trip Data Into Datatable
            dataAdapter.Fill(dataTable);

            //Passing Datatable Data Into Data Grid View
            dataGridView1.DataSource = dataTable;
        }

        // Displaying All Active Trips
        private void btn_ActiveTrips_Click(object sender, EventArgs e)
        {

            // Creating Datatable
            DataTable dataTable = new DataTable();

            //Sql Data Adapter
            SqlDataAdapter dataAdapter;

            // Initialising Data Adapter To Read And Retrieve All Trip Data 
            dataAdapter = new SqlDataAdapter(databaseConnection.Active());

            //Filling Trip Data Into Datatable
            dataAdapter.Fill(dataTable);

            //Passing Datatable Data Into Data Grid View
            dataGridView1.DataSource = dataTable;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
