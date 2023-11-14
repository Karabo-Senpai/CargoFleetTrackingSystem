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
using System.Xml.Linq;

namespace CargoFleetTrackingSystem.UserControls
{
    public partial class UpdateEmployeeRates : UserControl
    {
        //Declaring and and Initialising Database Connection Object 
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");
        DatabaseConnection databaseConnection = new DatabaseConnection();

        //Declaring Global Variables To Be Used For Data The User Has Inputted In The Textbox
        int rate_ID;
        string emp_Role;
        string emp_Name;
        DateTime start_Time;
        DateTime end_Time;
        DateTime Date;
        double rate_PerHour;
        

        public UpdateEmployeeRates()
        {
            InitializeComponent();

            //Method To Display Employee Rates Information
            EmployeeRatesInfomation();
        }

        private void EmployeeRatesInfomation()
        {
            // Open Sql Connection 
            conn.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.LoadEmp_Rate());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            //Close Sql Connection
            conn.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                rate_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Tb_Role.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Tb_Name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Tb_RPH.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dateTimePicker3.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();



                emp_Role = Tb_Role.Text;
                emp_Name = Tb_Name.Text;
                start_Time = Convert.ToDateTime(dateTimePicker1.ToString());
                end_Time = Convert.ToDateTime(dateTimePicker2.ToString());
                rate_PerHour = Convert.ToDouble(Tb_RPH.Text);
                Date = Convert.ToDateTime(dateTimePicker3.ToString());

            }
            catch (Exception)
            {
                Tb_Role.Text = "";
                Tb_Name.Text = "";
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                Tb_RPH.Text = "";
                dateTimePicker3.Text = "";
            }

        }



        private void UpdateEmployeeRates_Load(object sender, EventArgs e)
        {

        }

        // Method to update employees rates
        private void Bt_Update_Click(object sender, EventArgs e)
        {
            //Opening Sql Connection
            conn.Open();

            //Sql Command To Write Update Query for Employee Rates 
            SqlCommand command = databaseConnection.UpdateEmp_rate(Tb_Role.Text, Tb_Name.Text, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString(), Convert.ToDouble(Tb_RPH.Text), dateTimePicker3.Value.ToString(), rate_ID.ToString());

            command.Parameters.AddWithValue("@Role", emp_Role);
            command.Parameters.AddWithValue("@Name", emp_Name);
            command.Parameters.AddWithValue("@StartTime", start_Time);
            command.Parameters.AddWithValue("@EndTime", end_Time);
            command.Parameters.AddWithValue("@RPH", rate_PerHour);
            command.Parameters.AddWithValue("@Date", Date);

            command.ExecuteNonQuery();

            Tb_Role.ResetText();
            Tb_Name.ResetText();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            Tb_RPH.ResetText();
            dateTimePicker3.ResetText();

            //Close Sql Connection
            conn.Close();

        }
        //Method To Remove An Employees Rate
        private void Bt_Remove_Click(object sender, EventArgs e)
        {
            //Opening Sql Connection
            conn.Open();

            databaseConnection.DeleteEmp_Rate(Tb_Name.Text, rate_ID.ToString());

            Tb_Role.ResetText();
            Tb_Name.ResetText();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            Tb_RPH.ResetText();
            dateTimePicker3.ResetText();

            //Closing Sql Connection
            conn.Close();

        }
    }
}
