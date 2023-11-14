using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoFleetTrackingSystem.Models
{
    public class DatabaseConnection
    {


        public static SqlConnection conn = null;
        public DatabaseConnection()
        {
            //Adding Database Connection String
            conn = new SqlConnection("Data Source=LAPTOP-MBEFN67A\\SQLEXPRESS;Initial Catalog=Cargo_FleetDB;Integrated Security=True");
        }

        ///Reading The Database For A Trip That Was Selected
        public SqlDataReader SelectTrip() // may need to delete
        {
            //Added a comment
            String sqlSelect = "SELECT * FROM Trip WHERE Status = 'Stationary'";
            SqlCommand command = new SqlCommand(sqlSelect, conn);
            
            //Creating SQL Data Reader To Reader Into The Database
            SqlDataReader dataReader;
           
            //Opening SQL Connection
            conn.Open();

            //Reading The Database
            dataReader = command.ExecuteReader();

            //Closing SQL Connection
            conn.Close();

            //Returning Data
            return dataReader;          
        }

        public SqlDataReader SelectAssinedTrip(String Driver) 
        {

            //Select Statement
            String sqlSelect = "SELECT T.R_City FROM Trip T, History H, Users Us WHERE T.Status = 'Waiting' AND T.TripID = H.TripID AND Us.EmpID = H.DriverID AND Us.EmpID = '" + Driver + "'";
            
            //Sql Command To Write Select Query 
            SqlCommand command = new SqlCommand(sqlSelect, conn);
            
            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Sql Connection
            conn.Open();
            
            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closing Sql Connection
            conn.Close();

            //Returning Data
            return dataReader;

        }

        public SqlDataReader RequestTrip()
        {
            //SELECT STATEMENT
            String sqlSelect = "SELECT * FORM Trip WHERE Status = 'Request'";
            
            //Creating Sql Command To Write Sql Select Query 
            SqlCommand command = new SqlCommand(sqlSelect, conn);
            
            //Creating Data Reader
            SqlDataReader dataReader;
            
            //Opening Sql Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closing Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public void ChangeRequest(String TripID)
        {
            //Sql Update Statement
            String sqlUpdate = "UPDATE Trip SET Status = 'Stationary' WHERE Status='Request' AND TripID = '" + TripID + "'";

            //Sql Command To Write Update Query
            SqlCommand command = new SqlCommand(sqlUpdate, conn);
            
            //Opening Sql Connection
            conn.Open();

            //Executing Non Query To Execute SQL Command
            command.ExecuteNonQuery();

            //Closing Sql Database Connection
            conn.Close();
        }
        public void DeclineTripRequest(String TripID)
        {
            //Sql Update Statement
            String sqlUpdate = "UPDATE Trip SET Status = 'Declined' WHERE Status='Request' AND TripID = '" + TripID + "'";

            //Sql Command To Write Update Query
            SqlCommand command = new SqlCommand(sqlUpdate, conn);

            //Opening Sql Connection
            conn.Open();

            //Executing Non Query To Execute SQL Command
            command.ExecuteNonQuery();

            //Closing Sql Database Connection
            conn.Close();
        }


        public SqlDataReader DisplayVType()
        {
            //Select Statement
            String sqlSelect = "SELECT * FROM Vehical WHERE Status = 'Stationary'";
            
            //Creating Sql Command To Write Query
            SqlCommand command = new SqlCommand(sqlSelect, conn);
            
            //Creating Sql Data Reader
            SqlDataReader dataReader;
            
            //Opening Sql Database Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closing Sql Database Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlDataReader ChooseDriver()
        {
            String sqlSelect = "SELECT * FORM Users WHERE UserRole = 'Driver'";
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Sql Database Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();
            
            //Closing Sql Database Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public void fillDB(string UserID, string VehicalID, string TripID, DateTime date)
        {
            //Insert Statement 
            string sqlInsert = "INSERT INTO History ([DriverID], [VehicalID], [TripID],[Start_Date], [Status]) VALUES('" + UserID + "', ' " + VehicalID + "', '" + TripID + "', '" + date + "', '" + " Active " + "'); ";
           
            //Sql Command To Write Insert Query
            SqlCommand command = new SqlCommand(sqlInsert, conn);
            
            //Opening Sql Databse Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            //Closing Sql Database Connection
            conn.Close();
        }

        public SqlDataReader DisplayDriverInfo(String DriverID)
        {
            //Select Statement
            String sqlSelect = "SELECT * FROM History WHERE DriverID = '" + DriverID + "'";
          
            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);
           
            //Creating Sql Data Reader
            SqlDataReader dataReader;
            
            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closing Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlDataReader StandardService() 
        {

            //Select statement
            String sqlSelect = "SELECT * FROM Service WHERE Problem = 'N/A' AND Status = 'Pending'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;
            
            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;

        }

        public SqlDataReader IncedintService() 
        {

            //Select Statement
            String sqlSelect = "SELECT * FROM Service WHERE Status = 'Pending'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;

        }

        public void ChangeStatus(String TripID)
        {
            //Update Statement
            String sqlUpdate = "UPDATE Trip SET Status = 'Waiting' WHERE Status='Stationary' AND TripID = '" + TripID + "'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlUpdate, conn);
            
            //Opening Connection
            conn.Open();

            //Executing Query Command
            command.ExecuteNonQuery();

            //Closing Connection
            conn.Close();
        }

        public SqlCommand UpdateTripEndDate(DateTime EndTrip, string TripID)
        {
            String sqlUpdate = "UPDATE History SET End_Date = '" + EndTrip + "' WHERE TripID = '" + TripID + "'";
            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlUpdate, conn);

            //Opening Connection
            conn.Open();

            //Executing Query Command
            command.ExecuteNonQuery();

            //Closing Connection
            conn.Close();


            return command;
        }

        public void ChangeTStatus(String TripID)
        {

            String sqlUpdate = "UPDATE Trip SET Status = 'Active' WHERE Status='Waiting' AND TripID = '" + TripID + "'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlUpdate, conn);

            //Opening Connection
            conn.Open();

            //Executing Query Command
            command.ExecuteNonQuery();

            //Closing Connection
            conn.Close();
        }

        public SqlDataReader SelectTripIndex(String Trip)
        {
          
            String sqlSelect = "SELECT * FROM Trip WHERE R_Name = '" + Trip + "' ";


            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;

        }

        public SqlDataReader SelectedService(String Trip)
        {
            //Select Statemment
            String sqlSelect = "SELECT * FROM Service WHERE Vehicle_Make = '" + Trip + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;

        }

        public SqlDataReader SelectedIncService(String Trip)
        {

            //Select Statement
            String sqlSelect = "SELECT ServiceID, Vehicle_Make, Vehicle_Model, Number_Plate, Date, Problem, Vehicle_ID FROM Service WHERE Number_Plate = '" + Trip + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;

        }

        public SqlDataReader SelectedStaService(String Trip)
        {

            String sqlSelect = "SELECT ServiceID, Vehicle_Make, Vehicle_Model, Number_Plate, Date, Total_Milage, Vehicle_ID FROM Service WHERE Vehicle_Make = '" + Trip + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;

        }

        public SqlDataReader Fillcombo(String UserID)
        {
           
            String sqlSelect = "SELECT Tr.[R_Name] FROM [Vehical] AS ve, [Users] AS Us, [Trip] as Tr, [History] AS His where Ve.[VehicalID] = His.[VehicalID] AND Us.[EmpID] = His.[DriverID] AND Tr.[TripID] = His.[TripID] AND Tr.Status = 'Active' AND DriverID = '" + UserID + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public void ChangeTripStatus(String tripID)
        {
            
            String sqlUpdate = "UPDATE Trip SET Status = 'Complete' WHERE Status = 'Active' AND TripID = '" + tripID + "'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlUpdate, conn);

            //Opening Connection
            conn.Open();

            //Executing Query Command
            command.ExecuteNonQuery();

            //Closing Connection
            conn.Close();
        }

    
        public SqlCommand Active()
        {
            //Select Statement
            String sqlSelect = "SELECT Tr.[R_Name] AS 'Customer Name', Tr.[R_StreetAddress] AS 'Customer Street', Tr.[R_City] AS 'Customer City', Us.[FirstName] AS 'Driver Name', Us.[LastName] AS 'Driver Surname', Ve.[Vehical_Make] AS 'Vehical Make', Ve.[Vehical_Model] AS 'Vehical Model', Ve.[VIN_Number] AS 'VIN Number', Tr.[Status] FROM [Vehical] AS ve, [Users] AS Us, [Trip] AS Tr, [History] AS His where Ve.[VehicalID] = His.[VehicalID] AND Lo.[EmpID] = His.[DriverID] AND Tr.[TripID] = His.[TripID] AND Tr.Status = 'Active'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;
           
        }

        public SqlCommand Complete()
        {
            //Select Statement
            String sqlSelect = "SELECT Tr.[R_Name] AS 'Customer Name', Tr.[R_StreetAddress] AS 'Customer Street', Tr.[R_City] AS 'Customer City', Us.[FirstName] as 'Driver Name', Us.[LastName] AS 'Driver Surname', Ve.[Vehical_Make] AS 'Vehical Make', Ve.[Vehical_Model] AS 'Vehical Model', Ve.[VIN_Number] AS 'VIN Number', Tr.[Status] FROM [Vehical] AS ve, [Users] AS Us, [Trip] AS Tr, [History] AS His WHERE Ve.[VehicalID] = His.[VehicalID] AND Us.[EmpID] = His.[DriverID] AND Tr.[TripID] = His.[TripID] AND Tr.Status = 'Complete'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);
            
            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlCommand test()
          
        {
            //Select Statement
            String sqlSelect = "SELECT * FROM Users";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);
            
            //Opening Connection
            conn.Open();
            return command;
        }

        public SqlCommand PendingStatus()
        {
            //Select Statement
            String sqlSelect = "SELECT [R_Name] AS 'Customer Name', [R_StreetAddress] AS 'Customer Street', [R_City] AS 'Customer City', [R_Postcode] AS 'Customer Postcode', [Status] FROM Trip WHERE Status='Waiting'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;
        }
        
        public SqlCommand create()
        {
            //Insert Statement
            String sqlInsert = "INSERT INTO Users (FirstName, LastName, DOB, Address, Username, Password, UserRole) VALUES (@FirstName, @LastName, @DOB, @Address, @Username, @Password, @UserRole) ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlInsert, conn);
            
            //Opening Connection
            conn.Open();

            return command;
        }
  

        public SqlCommand createNewTrip()
        {
            //Insert Statement
            String sqlInsert = "INSERT INTO Trip (S_Name, S_StreetAddress, S_City, S_Postcode, S_Province, S_Phone, R_Name, R_StreetAddress, R_City, R_Postcode, R_Province, R_Phone, R_Description)" +
            " VALUES (@S_Name, @S_StreetAddress, @S_City, @S_Postcode, @S_Province, @S_Phone, @R_Name, @R_StreetAddress, @R_City, @R_Postcode, @R_Province, @R_Phone, @R_Description)";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlInsert, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlCommand createVehicle()
        {

         
            //Insert Statement
            String sqlInsert = "INSERT INTO Vehical (Vehical_Make, Vehical_Model, Vehical_Year, VIN_Number, Engine_Size, Number_Plate, Capacity)" +
            " VALUES (@Vehical_Make, @Vehical_Model, @Vehical_Year, @VIN_Number, @Engine_Size, @Number_Plate, @Capacity)";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlInsert, conn);

            //Opening Connection
            conn.Open();

            return command;
        }
        public DataTable Users(String Username, String Password)
        {
          
            //Creating Sql Data Adapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UserRole, EmpID FROM Users WHERE UserName='" + Username + "' and Password='" + Password + "'   ", conn);
           
            //Creating DataTable
            DataTable dataTable = new System.Data.DataTable();
            //Filling Datatable with data from the database
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public SqlDataReader FillEmpRole()
        {
            //Select Statement
            String sqlSelect = "SELECT DISTINCT US.UserRole FROM Users Us";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlDataReader FillEmpName(String Role)
        {

            String sqlSelect = "SELECT Us.FirstName from Users Us WHERE Us.UserRole = '" + Role + "'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlCommand empRate()
        {
            String insertQuery = "INSERT INTO Emp_Rate (Role, Name, StartTime, EndTime, RPH, Date, Wage) VALUES (@Role, @Name, @StartTime, @EndTime, @RPH, @Date, @Wage) ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(insertQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlCommand FuelCon()
        {
            //Insert Statement
            String insertQuery = "INSERT INTO Fuel_Consumption (Number_Plate, L_B_T, L_A_T, PPL) VALUES (@Number_Plate, @L_B_T, @L_A_T, @PPL) ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(insertQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }
        public SqlDataReader FillNP()
        {
          
            //Select Statement
            String sqlSelect = "SELECT Number_Plate FROM Vehical";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }
        public SqlCommand IncidentRec()
        {
            //Insert Statement
            String insertQuery = "INSERT INTO Trip_Incidents (Location, Cause, Driver, VehicleMake, VehicleModel, NumberPlate, OtherParties, Vehicle_ID) VALUES (@Location, @Cause, @Driver, @VehicleMake, @VehicleModel, @NumberPlate, @OtherParties, @Vehicle_ID) ";


            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(insertQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }
        public SqlCommand StatVehicleSta()
        {
            String sqlSelect = "SELECT V.Vehical_Make, V.Vehical_Model, V.Vehical_Year, V.VIN_Number, V.Engine_Size, V.Number_Plate, V.Capacity, V.Status FROM Vehical V WHERE V.Status LIKE '%Stationary%'";
           
            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;
        }


        public SqlCommand StatVehicleAct()
        {
            //Select Statement
            String sqlSelect = "SELECT V.Vehical_Make, V.Vehical_Model, V.Vehical_Year, V.VIN_Number, V.Engine_Size, V.Number_Plate, V.Capacity FROM Vehical V WHERE V.Status LIKE '%Active%';";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;

        }
        public SqlCommand StatVehicleSer()
        {
            //Select Statement
            String sqlSelect = "SELECT V.Vehical_Make, V.Vehical_Model, V.Vehical_Year, V.VIN_Number, V.Engine_Size, V.Number_Plate, V.Capacity FROM Vehical V WHERE V.Status LIKE 'In_Service';";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlDataReader Select_NP()
        {
            String sqlSelect = "SELECT v.Number_Plate, h.VehicalID, h.TripID FROM Vehical v, History h, Trip t FROM h.VehicalID = v.VehicalID AND h.TripID = t.TripID AND t.Status = 'Active'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlDataReader VID(String NP)
        {
            String sqlSelect = "SELECT VehicalID FROM Vehical WHERE  Number_Plate = '" + NP + "'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlDataReader TripInc(String NP)
        {
            //Select Statement

            String sqlSelect = "SELECT Us.FirstName, v.Vehical_Make, Vehical_Model FROM Users Us, Vehical v, History h WHERE Us.EmpID = h.DriverID AND v.VehicalID = h.VehicalID AND v.Number_Plate = '" + NP + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlCommand createService()
        {
   
            //Insert Statement
            String insertQuery = "INSERT INTO Service (Vehicle_Make, Vehicle_Model, Number_Plate, Total_Milage, Date, Vehicle_ID) VALUES (@Vehicle_Make, @Vehicle_Model, @Number_Plate, @Total_Milage, @Date, @Vehicle_ID) ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(insertQuery, conn);

            //Opening Connection
            conn.Open();

            return command;


        }

        public SqlCommand createIncService()
        {
            //Vehicle_Make Vehicle_Model Number_Plate Total_Milage Date Problem
            String insertQuery = "INSERT INTO Service (Vehicle_Make, Vehicle_Model, Number_Plate, Date, Problem, Vehicle_ID) VALUES (@Vehicle_Make, @Vehicle_Model, @Number_Plate, @Date, @Problem, @Vehicle_ID) ";


            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(insertQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }
        public SqlDataReader incedentDD()
        {
            //Select Statement
            String sqlSelect = "SELECT * FROM Trip_Incidents WHERE Status = 'Repairs Needed'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public void ChangeIncStatus(String Vehicle_ID)
        {
            //Update Statement
            String updateQuery = "UPDATE Trip_Incidents SET Status = 'In-Service' WHERE Status = 'Repairs Needed' AND Vehicle_ID = '" + Vehicle_ID + "'";

            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();   
        }
        public SqlDataReader SelectIncident(String NP)
        {
            //Select Statement
            String sqlSelect = "SELECT * FROM Trip_Incidents WHERE NumberPlate = '" + NP + "'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlDataReader DisplayDriverTrip(String name)
        {
            //Select Statement

            String sqlSelect = "SELECT T.TripID, T.R_Name, T.R_StreetAddress, T.R_City, T.R_Postcode, T.R_Province, T.R_Phone, T.R_Description, V.Vehical_Make, H.Start_Date, T.TripID, V.VehicalID from Trip T, History H, Vehical V, Users Us WHERE H.TripID = T.TripID and H.DriverID = Us.EmpID and T.R_City = '" + name + "'";


            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlCommand CompleteService()
        {
            //Insert Statement
            String insertQuery = "INSERT INTO Completed_Service (ServiceID, Description, Price) VALUES (@ServiceID, @Description, @Price) ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(insertQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }



        public void ChangeService(String TripID)
        {

            //Update Statement
            String updateQuery = "UPDATE Service SET Status = 'Complete' WHERE Status='Pending' and ServiceID = '" + TripID + "'";

            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();   
        }

        public void ChangeV_Status(String V_ID)
        {
            //Update Statement
            String updateQuery = "UPDATE Vehical SET Status = 'Active' WHERE Status='Stationary' AND VehicalID = '" + V_ID + "' ";

            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();   
        }

        public void ChangeV_AfterTrip(String V_ID)
        {
            //Update Query Statement

            String updateQuery = "UPDATE Vehical SET Status = 'Stationary' WHERE VehicalID = '" + V_ID + "' ";

            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();
        }
        public void ChangeV_Incident(String V_ID)
        {
            //Update Query Statement

            String updateQuery = "UPDATE Vehical SET Status = 'In_Service' WHERE VehicalID = '" + V_ID + "' ";

            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();
        }
        public void ChangeV_Fixed(String V_ID)
        {
            String updateQuery = "UPDATE Vehical SET Status = 'Stationary' WHERE VehicalID = '" + V_ID + "' ";

            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();
        }

        public SqlDataReader DisplayStandard()
        {
            //Select Statement Query
            String sqlSelect = "SELECT DISTINCT Vehical_Make FROM Vehical";


            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlDataReader DisplayStandardNP(String V_Make)
        {

            //Select Statement QUery
            String sqlSelect = "SELECT Number_Plate FROM Vehical WHERE Vehical_Make = '" + V_Make + "'";


            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }

        public SqlDataReader StandardServiceInfo(String Make, String NP)
        {

            //Select Statement Query
            String sqlSelect = "SELECT Vehical_Model FROM Vehical WHERE Vehical_Make = '" + Make + "' AND Number_Plate = '" + NP + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }
        public SqlCommand updateUsers(string FirstName, string LastName, string DOB, string Address, string Username, string Password, string Role, string UserID)
        {
            //Update Statement Query
            string updateQuery = "UPDATE Users SET FirstName = '" + FirstName + "', LastName = '" + LastName + "', DOB = '" + DOB + "', Address = '" + Address + "', Username = '" + Username + "', Password = '" + Password + "', UserRole = '" + Role + "' WHERE EmpID = '" + UserID + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }




        public SqlCommand LoadEmployees()
        {
            //Select Statement Query
            String sqlSelect = "SELECT * FROM Users";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlCommand UpdateEmployees(string FirstName, string LastName, string DOB, string Address, string Username, string Password, string Role, string UserID)
        {
            //Update Statement Query
            string updateQuery = "UPDATE Users SET FirstName = '" + FirstName + "', LastName = '" + LastName + "', DOB = '" + DOB + "', Address = '" + Address + "', Username = '" + Username + "', Password = '" + Password + "', UserRole = '" + Role + "' WHERE EmpID = '" + UserID + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            return command;
        }

        public SqlCommand LoadVehicles()
        {
            //Select Statement Query
            String sqlSelect = "SELECT * FROM Vehical";
            
                //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlCommand UpdateVehicles(string V_Make, string V_Model, string V_Year, string V_VIN, string V_Size, string NP, string Cap, string status, string V_ID)
        {
            //Update Query Statement
            string updateQuery = "UPDATE Vehical SET Vehical_Make = '" + V_Make + "', Vehical_Model = '" + V_Model + "', Vehical_Year = '" + V_Year + "', VIN_Number = '" + V_VIN + "', Engine_Size = '" + V_Size + "', Number_Plate = '" + NP + "', Capacity = '" + Cap + "', Status = '" + status + "' WHERE VehicalID = '" + V_ID + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlCommand LoadService()
        {
            //Select Query Statement
            String sqlSelect = "SELECT * FROM Service";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlCommand UpdateService(string make, string model, string NP, string Milage, string Date, string Problem, string status, string ServiceID)
        {
            //Update Query Statement
            string updateQuery = "UPDATE Service SET Vehicle_Make = '" + make + "', Vehicle_Model = '" + model + "', Number_Plate = '" + NP + "', Total_Milage = '" + Milage + "', Date = '" + Date + "', Problem = '" + Problem + "', Status = '" + status + "' WHERE ServiceID = '" + ServiceID + "' ";
          
            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlCommand LoadFuelCon()
        {
            //Select Query Statement
            String sqlSelect = "SELECT * FROM Fuel_Consumption";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;
        }
        public SqlCommand UpdateFuelCon(string NP, double LBT, double LAT, double Price, string FuelID)
        {
            //Update Query Statement
            string updateQuery = "UPDATE Fuel_Consumption SET Number_Plate = '" + NP + "', L_B_T = '" + LBT + "', L_A_T = '" + LAT + "', PPL = '" + Price + "' WHERE FuelID = '" + FuelID + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlCommand LoadEmp_Rate()
        {
            //Select Query Statement
            String sqlSelect = "SELECT * from Emp_Rate";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;
        }
        public SqlCommand UpdateEmp_rate(string role, string name, string starttime, string endtime, double RPH, string Date, string RateID)
        {
            //Update Query Statement
            string updateQuery = "UPDATE Emp_rate SET Role= '" + role + "', Name = '" + name + "', StartTime = '" + starttime + "', EndTime = '" + endtime + "' , RPH = '" + RPH + "', Date = '" + Date + "' WHERE RateID = '" + RateID + "' ";
            
            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public void DeleteEmp_Rate(string name, string RateID)
        {
            //Delete Query Statement
            string deleteQuery = "DELETE FROM Emp_Rate WHERE Name = '" + name + "' AND RateID = '" + RateID + "'";
         
            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(deleteQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();
        }
        public void DeleteLogin(string FirstName, string UserID)
        {
            string deleteQuery = "DELETE FROM Users WHERE FirstName = '" + FirstName + "' AND EmpID = '" + UserID + "'";

            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(deleteQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();
        }
        public void DeleteFuelCon(string Number_Plate, string FuelID)
        {
            //Delete Query Statement
            string deleteQuery = "DELETE FROM Fuel_Consumption WHERE Number_Plate = '" + Number_Plate + "' AND FuelID = '" + FuelID + "'";

            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(deleteQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();

        }
        public void DeleteService(string po, string la)
        {
            //Delete Query Statement
            string deleteQuery = "DELETE FROM Service WHERE Vehicle_Make = '" + po + "' AND ServiceID = '" + la + "'";

            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(deleteQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();
        }
        public SqlCommand LoadTrip()
        {
            //Select Query Statement
            String sqlSelect = "SELECT * FROM Trip";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlCommand UpdateTrip(string Name1, string Address1, string City1, string PC1, string Prov1, string Phone1, string Name2, string Address2, string City2, string PC2, string Prov2, string Phone2, string Desc2, string Status, string TID)
        {
            // 
            string updateQuery = "UPDATE Trip SET S_Name ='" + Name1 + "', S_StreetAddress= '" + Address1 + "', S_City = '" + City1 + "', S_Postcode = '" + PC1 + "', S_Province = '" + Prov1 + "', S_Phone = '" + Phone1 + "', R_Name ='" + Name2 + "', R_StreetAddress= '" + Address2 + "', R_City = '" + City2 + "', R_Postcode = '" + PC2 + "', R_Province = '" + Prov2 + "', R_Phone = '" + Phone2 + "', R_Description = '" + Desc2 + "', Status = '" + Status + "' WHERE TripID = '" + TID + "' ";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            return command;
        }

        public SqlDataReader DisplayStaffName(String UserID)
        {
            String sqlSelect = "SELECT FirstName, LastName FROM Users WHERE EmpID = '" + UserID + "'";

            //Creating Command To Write and Execute Sql Queries
            SqlCommand command = new SqlCommand(sqlSelect, conn);

            //Creating Sql Data Reader
            SqlDataReader dataReader;

            //Opening Connection
            conn.Open();

            //Reading Into The Database
            dataReader = command.ExecuteReader();

            //Closning Connection
            conn.Close();

            //Returning Read Data
            return dataReader;
        }
        public DataTable LogUserIn(String username)
        {
            //Select Query Statement 
            String sqlSelect = "SELECT Username FROM Users WHERE Username = '" + username + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, conn);
            DataTable userInput = new DataTable("Username");
            dataAdapter.Fill(userInput);

            return userInput;
        }

        public void ChangeIncTrip(String TripID)
        {
            //Update Query Statement
            String updateQuery = "UPDATE Trip SET Status = 'Stationary' WHERE Status='Active' AND TripID = '" + TripID + "'";
          
            //Command To Write Sql Queries
            SqlCommand command = new SqlCommand(updateQuery, conn);

            //Opening Connection
            conn.Open();

            //Executing Command
            command.ExecuteNonQuery();

            conn.Close();
        }
        public DataTable EmployeeReport()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Role, Name, RPH, StartTime, EndTime, Date, Wage FROM Emp_Rate", conn);
            DataTable dataTable = new System.Data.DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;

        }

        public DataTable ViewAllVehicles()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Vehical", conn);
            DataTable dataTable = new System.Data.DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;

        }
        public DataTable ViewServiceAppointment()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Service WHERE status = 'Pending'", conn);
            DataTable dataTable = new System.Data.DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;

        }
        public DataTable ViewCompleteService()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT s.Vehicle_Make, s.Vehicle_Model, s.Number_Plate, cs.Description, cs.Price FROM Service s, Completed_Service cs WHERE cs.ServiceID = s.ServiceID and Status = 'Complete'", conn);
            DataTable dataTable = new System.Data.DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;

        }
    }
}
