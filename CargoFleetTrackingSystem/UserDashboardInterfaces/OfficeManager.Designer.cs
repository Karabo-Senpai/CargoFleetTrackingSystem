namespace CargoFleetTrackingSystem.UserDashboardInterfaces
{
    partial class OfficeManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.mPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.officeManagerPanel = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_emp_report = new System.Windows.Forms.Button();
            this.btn_vehicle_report = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Select_Update = new System.Windows.Forms.ComboBox();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_PendingTrip = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mPanel.SuspendLayout();
            this.officeManagerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Exit.Location = new System.Drawing.Point(1721, 2);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(41, 37);
            this.btn_Exit.TabIndex = 25;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Minimize.Location = new System.Drawing.Point(1673, -4);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(40, 44);
            this.btn_Minimize.TabIndex = 24;
            this.btn_Minimize.Text = "—";
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // mPanel
            // 
            this.mPanel.BackColor = System.Drawing.Color.DimGray;
            this.mPanel.Controls.Add(this.label1);
            this.mPanel.Controls.Add(this.btn_Exit);
            this.mPanel.Controls.Add(this.btn_Minimize);
            this.mPanel.Font = new System.Drawing.Font("Consolas", 10F);
            this.mPanel.Location = new System.Drawing.Point(0, 0);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(1762, 35);
            this.mPanel.TabIndex = 1;
            this.mPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(853, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Office Manager Dashboard";
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.homePanel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePanel.Location = new System.Drawing.Point(342, 35);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1420, 768);
            this.homePanel.TabIndex = 2;
            this.homePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePanel_Paint);
            // 
            // officeManagerPanel
            // 
            this.officeManagerPanel.BackColor = System.Drawing.Color.Gray;
            this.officeManagerPanel.Controls.Add(this.btn_Logout);
            this.officeManagerPanel.Controls.Add(this.btnExit);
            this.officeManagerPanel.Controls.Add(this.btn_emp_report);
            this.officeManagerPanel.Controls.Add(this.btn_vehicle_report);
            this.officeManagerPanel.Controls.Add(this.label2);
            this.officeManagerPanel.Controls.Add(this.cb_Select_Update);
            this.officeManagerPanel.Controls.Add(this.viewAllBtn);
            this.officeManagerPanel.Controls.Add(this.btn_Create);
            this.officeManagerPanel.Controls.Add(this.panel2);
            this.officeManagerPanel.Controls.Add(this.btn_PendingTrip);
            this.officeManagerPanel.Controls.Add(this.pictureBox2);
            this.officeManagerPanel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeManagerPanel.Location = new System.Drawing.Point(0, 35);
            this.officeManagerPanel.Name = "officeManagerPanel";
            this.officeManagerPanel.Size = new System.Drawing.Size(343, 768);
            this.officeManagerPanel.TabIndex = 3;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Consolas", 8F);
            this.btn_Logout.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Logout.Location = new System.Drawing.Point(31, 625);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(280, 36);
            this.btn_Logout.TabIndex = 36;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 8F);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(31, 674);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(283, 36);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_emp_report
            // 
            this.btn_emp_report.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_emp_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp_report.Font = new System.Drawing.Font("Consolas", 8F);
            this.btn_emp_report.ForeColor = System.Drawing.Color.Transparent;
            this.btn_emp_report.Location = new System.Drawing.Point(31, 525);
            this.btn_emp_report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_emp_report.Name = "btn_emp_report";
            this.btn_emp_report.Size = new System.Drawing.Size(280, 43);
            this.btn_emp_report.TabIndex = 34;
            this.btn_emp_report.Text = "Employee Report";
            this.btn_emp_report.UseVisualStyleBackColor = false;
            // 
            // btn_vehicle_report
            // 
            this.btn_vehicle_report.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_vehicle_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicle_report.Font = new System.Drawing.Font("Consolas", 8F);
            this.btn_vehicle_report.ForeColor = System.Drawing.Color.Transparent;
            this.btn_vehicle_report.Location = new System.Drawing.Point(31, 478);
            this.btn_vehicle_report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_vehicle_report.Name = "btn_vehicle_report";
            this.btn_vehicle_report.Size = new System.Drawing.Size(280, 43);
            this.btn_vehicle_report.TabIndex = 33;
            this.btn_vehicle_report.Text = "Vehicle Report";
            this.btn_vehicle_report.UseVisualStyleBackColor = false;
            this.btn_vehicle_report.Click += new System.EventHandler(this.btn_vehicle_report_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(68, 407);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Choose An Option To Update";
            // 
            // cb_Select_Update
            // 
            this.cb_Select_Update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Select_Update.Font = new System.Drawing.Font("Consolas", 8F);
            this.cb_Select_Update.FormattingEnabled = true;
            this.cb_Select_Update.Items.AddRange(new object[] {
            "Employees",
            "Vehicals",
            "Trip",
            "Service",
            "Fuel Consumption",
            "Employee Rate"});
            this.cb_Select_Update.Location = new System.Drawing.Point(55, 436);
            this.cb_Select_Update.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Select_Update.Name = "cb_Select_Update";
            this.cb_Select_Update.Size = new System.Drawing.Size(228, 23);
            this.cb_Select_Update.TabIndex = 30;
            this.cb_Select_Update.SelectedIndexChanged += new System.EventHandler(this.cb_Select_Update_SelectedIndexChanged);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.viewAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllBtn.Font = new System.Drawing.Font("Consolas", 8F);
            this.viewAllBtn.ForeColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.Location = new System.Drawing.Point(31, 344);
            this.viewAllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(280, 43);
            this.viewAllBtn.TabIndex = 28;
            this.viewAllBtn.Text = "Vew All Trips";
            this.viewAllBtn.UseVisualStyleBackColor = false;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Font = new System.Drawing.Font("Consolas", 8F);
            this.btn_Create.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Create.Location = new System.Drawing.Point(31, 251);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(280, 43);
            this.btn_Create.TabIndex = 27;
            this.btn_Create.Text = "Create New Account";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(31, 391);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 79);
            this.panel2.TabIndex = 32;
            // 
            // btn_PendingTrip
            // 
            this.btn_PendingTrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_PendingTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PendingTrip.Font = new System.Drawing.Font("Consolas", 8F);
            this.btn_PendingTrip.ForeColor = System.Drawing.Color.Transparent;
            this.btn_PendingTrip.Location = new System.Drawing.Point(31, 298);
            this.btn_PendingTrip.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PendingTrip.Name = "btn_PendingTrip";
            this.btn_PendingTrip.Size = new System.Drawing.Size(280, 43);
            this.btn_PendingTrip.TabIndex = 29;
            this.btn_PendingTrip.Text = "View Pending Trips";
            this.btn_PendingTrip.UseVisualStyleBackColor = false;
            this.btn_PendingTrip.Click += new System.EventHandler(this.btn_PendingTrip_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CargoFleetTrackingSystem.Properties.Resources.cargo_fleet_logo_1;
            this.pictureBox2.Location = new System.Drawing.Point(76, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // OfficeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1763, 802);
            this.Controls.Add(this.officeManagerPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.mPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OfficeManager";
            this.Text = "OfficeManager";
            this.Load += new System.EventHandler(this.OfficeManager_Load);
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.officeManagerPanel.ResumeLayout(false);
            this.officeManagerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Panel mPanel;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel officeManagerPanel;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_emp_report;
        private System.Windows.Forms.Button btn_vehicle_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Select_Update;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_PendingTrip;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}