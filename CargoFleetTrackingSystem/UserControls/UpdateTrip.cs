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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace CargoFleetTrackingSystem.UserControls
{
    public partial class UpdateTrip : UserControl
    {

        //Declaring and and Initialising Database Connection Object 
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");
        DatabaseConnection databaseConnection = new DatabaseConnection();

        //Declaring Global Variables To Be Used For Data The User Has Inputted In The Textbox
        int trip_ID;

        string name;
        string streetaddress;
        string city;
        string postcode;
        string province;
        string phone;
        string name2;
        string streetaddress2;
        string city2;
        string postcode2;
        string province2;
        string phone2;
        string description2;
        string status;

        public UpdateTrip()
        {
            InitializeComponent();
            DisplayTripInformation();
        }

        private void DisplayTripInformation()
        {
           //Opening Sql Connection 
           conn.Open();

            //Fetching Information To Be Displayed In The Datatable
            DataTable dataTable= new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseConnection.LoadTrip());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            //Closing Sql Connection 
            conn.Close();   
        }

        private void UpdateTrip_Load(object sender, EventArgs e)
        {

        }

        private void Tb_Province2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }




        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                trip_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Tb_Name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Tb_Streetname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Tb_City.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                Tb_PostCode.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Tb_Province.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                Tb_Phone.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                Tb_Name2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                Tb_StreetAddress2.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                Tb_City2.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                Tb_Postcode2.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                Tb_Province2.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                Tb_Phone2.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                Tb_Description.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                Tb_Statue.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();

                //Assigning user input to declared global variables
                name = Tb_Name.Text;
                streetaddress = Tb_Streetname.Text;
                city = Tb_City.Text;
                postcode = Tb_PostCode.Text;
                province = Tb_Province.Text;
                phone = Tb_Phone.Text;
                name2 = Tb_Name2.Text;
                streetaddress2 = Tb_StreetAddress2.Text;
                city2 = Tb_City2.Text;
                postcode2 = Tb_Postcode2.Text;
                province2 = Tb_Province2.Text;
                phone2 = Tb_Phone2.Text;
                description2 = Tb_Description.Text;
                status = Tb_Statue.Text;
            }
            //Catching Any Errors That May Arise Like The Data Table returning Nothing
            catch (Exception)
            {

                Tb_Name.Text = " ";
                Tb_Streetname.Text = "";
                Tb_City.Text = "";
                Tb_PostCode.Text = "";
                Tb_Province.Text = "";
                Tb_Phone.Text = "";
                Tb_Name2.Text = "";
                Tb_StreetAddress2.Text = "";
                Tb_City2.Text = "";
                Tb_Postcode2.Text = "";
                Tb_Province2.Text = "";
                Tb_Phone2.Text = "";
                Tb_Description.Text = "";
                Tb_Statue.Text = "";
            }

        }




        //Method To Update Trip Information 
        private void Bt_Update_Click(object sender, EventArgs e)
        {
            //Opening Sql Connection
            conn.Open();

            SqlCommand command = databaseConnection.UpdateTrip(Tb_Name.Text, Tb_Streetname.Text, Tb_City.Text, Tb_PostCode.Text, Tb_Province.Text, Tb_Phone.Text, Tb_Name2.Text, Tb_StreetAddress2.Text, Tb_City2.Text, Tb_Postcode2.Text, Tb_Province2.Text, Tb_Phone2.Text, Tb_Description.Text, Tb_Statue.Text, trip_ID.ToString());

            command.Parameters.AddWithValue("@S_Name", Tb_Name.Text);
            command.Parameters.AddWithValue("@S_StreetAddress", Tb_Streetname.Text);
            command.Parameters.AddWithValue("@S_City", Tb_City.Text);
            command.Parameters.AddWithValue("@S_Postcode", Tb_PostCode.Text);
            command.Parameters.AddWithValue("@S_Province", Tb_Province.Text);
            command.Parameters.AddWithValue("@S_Phone", Tb_Phone.Text);
            command.Parameters.AddWithValue("@R_Name", Tb_Name2.Text);
            command.Parameters.AddWithValue("@R_StreetAddress", Tb_StreetAddress2.Text);
            command.Parameters.AddWithValue("@R_City", Tb_City2.Text);
            command.Parameters.AddWithValue("@R_Postcode", Tb_Postcode2.Text);
            command.Parameters.AddWithValue("@R_Province", Tb_Province2.Text);
            command.Parameters.AddWithValue("@R_Phone", Tb_Phone2.Text);
            command.Parameters.AddWithValue("@R_Description", Tb_Description.Text);
            command.Parameters.AddWithValue("@Status", Tb_Statue.Text);

            //Sql Command To Write Update Query
            command.ExecuteNonQuery();

            //Clearing Field After Successful Update
            Tb_Name.ResetText();
            Tb_Streetname.ResetText();
            Tb_City.ResetText();
            Tb_PostCode.ResetText();
            Tb_Province.ResetText();
            Tb_Phone.ResetText();
            Tb_Name2.ResetText();
            Tb_StreetAddress2.ResetText();
            Tb_City2.ResetText();
            Tb_Postcode2.ResetText();
            Tb_Province2.ResetText();
            Tb_Phone2.ResetText();
            Tb_Description.ResetText();
            Tb_Statue.ResetText();
        }
    }
}
