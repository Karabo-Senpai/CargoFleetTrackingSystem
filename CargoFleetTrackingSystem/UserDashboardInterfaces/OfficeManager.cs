using CargoFleetTrackingSystem.Models;
using CargoFleetTrackingSystem.UserControls;
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

namespace CargoFleetTrackingSystem.UserDashboardInterfaces
{
    public partial class OfficeManager : Form
    {
        //Declaring And Assigning Variables
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");

        RegisterUser register = new RegisterUser();

        OfficeManager_ViewTrips officeManager_ViewTrips = new OfficeManager_ViewTrips();

        UpdateEmployees updateEmployees = new UpdateEmployees();

        ViewPendingTrips pendingTrips = new ViewPendingTrips();

        UpdateVehicle updateVehicle = new UpdateVehicle();

        UpdateService updateService = new UpdateService();

        UpdateFuelConsumption updateFuelConsumption = new UpdateFuelConsumption();

        UpdateEmployeeRates updateEmployeeRates = new UpdateEmployeeRates();

        UpdateTrip updateTrip = new UpdateTrip();


        DatabaseConnection databaseConnection = new DatabaseConnection();

        String user_id;

        public OfficeManager(String Id)
        {
            this.user_id = Id;

            InitializeComponent();
        }

       

        private void OfficeManager_Load(object sender, EventArgs e)
        {

        }

        // 
        private void btn_Create_Click(object sender, EventArgs e)
        {
            cb_Select_Update.Text = "";
            homePanel.Controls.Clear();
            homePanel.Controls.Add(register);
        }

        private void btn_PendingTrip_Click(object sender, EventArgs e)
        {
            cb_Select_Update.Text = "";
            homePanel.Controls.Clear();
            homePanel.Controls.Add(pendingTrips);
        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            cb_Select_Update.Text = "";
            homePanel.Controls.Clear();
            homePanel.Controls.Add(officeManager_ViewTrips);
        }

        private void btn_vehicle_report_Click(object sender, EventArgs e)
        {

        }

        private void displayNamesLbl_Click(object sender, EventArgs e)
        {

        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            //Minimizing Window That Is Currently Opened
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Closing Application When Exit Button Is Pressed


            if (MessageBox.Show("Are You Sure You Want To Close The Application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Environment.Exit(0);

            }
        }

        private void cb_Select_Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Choosing Action Depending On Chosen Combo Box Item
            if (cb_Select_Update.SelectedItem.ToString().Equals("Employees"))
            {
                homePanel.Controls.Clear();
                homePanel.Controls.Add(updateEmployees);
            }

            else if (cb_Select_Update.SelectedItem.ToString().Equals("Vehicals"))
            {
               
                homePanel.Controls.Clear();
                homePanel.Controls.Add(updateVehicle);
            }
            else if (cb_Select_Update.SelectedItem.ToString().Equals("Service"))
            {
              
                homePanel.Controls.Clear();
                homePanel.Controls.Add(updateService);
            }
            else if (cb_Select_Update.SelectedItem.ToString().Equals("Fuel Consumption"))
            {
                UpdateFuelConsumption updateFuelConsumption = new UpdateFuelConsumption();
                homePanel.Controls.Clear();
                homePanel.Controls.Add(updateFuelConsumption);
            }
            else if (cb_Select_Update.SelectedItem.ToString().Equals("Employee Rate"))
            {
                UpdateEmployeeRates updateEmployeeRates = new UpdateEmployeeRates();
                homePanel.Controls.Clear();
                homePanel.Controls.Add(updateEmployeeRates);
            }
            else if (cb_Select_Update.SelectedItem.ToString().Equals("Trip"))
            {
                UpdateTrip updateTrip = new UpdateTrip();
                homePanel.Controls.Clear();
                homePanel.Controls.Add(updateTrip);
            }

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Logging User Out
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Close The Application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Environment.Exit(0);

            }
        }

        private void mPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
