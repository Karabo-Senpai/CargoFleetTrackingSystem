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
using System.Xml;

namespace CargoFleetTrackingSystem.UserControls
{
    public partial class ViewPendingTrips : UserControl
    {
        //Declaring Database Connection String
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");

        //Creating Database Connection Class Object
        DatabaseConnection databaseConnection = new DatabaseConnection();

        string UserID,TripID;
       
        public ViewPendingTrips()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_Trip.Text) || string.IsNullOrWhiteSpace(cb_Trip.Text))
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else
            {


                conn.Close(); 
                databaseConnection.ChangeRequest(TripID);

                cb_Trip.ResetText();
                tb_SenderName.ResetText();
                tb_SenderSA.ResetText();
                tb_SenderCity.ResetText();
                tb_senderPC.ResetText();
                tb_SendersProv.ResetText();
                tb_SenderPhone.ResetText();

                tb_RName.ResetText();
                R_SAddress.ResetText();
                tb_RTown.ResetText();
                tb_RPostcode.ResetText();
                tb_RProv.ResetText();
                tb_RPhone.ResetText();
                tb_RDesc.ResetText();

                MessageBox.Show("Trip Request Successfully Approved", "Trip Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void panel_PendingTrips_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_RTown_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Decline_Click(object sender, EventArgs e)
        {

            //checks if textbox id null/blank
            if (string.IsNullOrEmpty(cb_Trip.Text) || string.IsNullOrWhiteSpace(cb_Trip.Text))
            {
                MessageBox.Show("Please Ensure Combo Box Item Is Chosen");
            }
            else
            {
                databaseConnection.DeclineTripRequest(TripID);

                cb_Trip.ResetText();

                tb_SenderName.ResetText();
                tb_SenderSA.ResetText();
                tb_SenderCity.ResetText();
                tb_senderPC.ResetText();
                tb_SendersProv.ResetText();
                tb_SenderPhone.ResetText();

                tb_RName.ResetText();
                R_SAddress.ResetText();
                tb_RTown.ResetText();
                tb_RPostcode.ResetText();
                tb_RProv.ResetText();
                tb_RPhone.ResetText();
                tb_RDesc.ResetText();

                MessageBox.Show("Please Inform Customer That Their Trip Was Declined","Trip Declined",MessageBoxButtons.OK,MessageBoxIcon.Warning);


            }

        }

        private void cb_Trip_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();

            SqlDataReader dataReader;

            try
            {
                conn.Close();
                dataReader = databaseConnection.RequestTrip();


                while (dataReader.Read())
                {
                    string rollNum = dataReader.GetInt32(0).ToString();
                    string S_Name = dataReader.GetString(1);
                    string S_StreetAddress = dataReader.GetString(2);
                    string S_City = dataReader.GetString(3);
                    string S_Postcode = dataReader.GetString(4);
                    string S_Province = dataReader.GetString(5);
                    string S_Phone = dataReader.GetString(6);

                    string R_Name = dataReader.GetString(7);
                    string R_StreetAddress = dataReader.GetString(8);
                    string R_City = dataReader.GetString(9);
                    string R_Postcode = dataReader.GetString(10);
                    string R_Province = dataReader.GetString(11);
                    string R_Phone = dataReader.GetString(12);
                    string R_Description = dataReader.GetString(13);
                    string Status = dataReader.GetString(14);


                    tb_SenderName.Text = S_Name;
                    tb_SenderSA.Text = S_StreetAddress;
                    tb_SenderCity.Text = S_City;
                    tb_senderPC.Text = S_Postcode;
                    tb_SendersProv.Text = S_Province;
                    tb_SenderPhone.Text = S_Phone;

                    tb_RName.Text = R_Name;
                    R_SAddress.Text = R_StreetAddress;
                    tb_RTown.Text = R_City;
                    tb_RPostcode.Text = R_Postcode;
                    tb_RProv.Text = R_Province;
                    tb_RPhone.Text = R_Phone;
                    tb_RDesc.Text = R_Description;


                    TripID = rollNum;

                }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        public void FillComboBox()
        {
            cb_Trip.Items.Clear();

            SqlDataReader dataReader;

            try
            {

                conn.Close();
                dataReader = databaseConnection.RequestTrip();

                while (dataReader.Read())
                {
                    String tripName = dataReader.GetString(7); // index number

                    cb_Trip.Items.Add(tripName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void ChangeStatus()
        {


            conn.Close();
            databaseConnection.ChangeStatus(TripID);

            FillComboBox(); //reloads
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
