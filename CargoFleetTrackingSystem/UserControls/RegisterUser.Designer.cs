namespace CargoFleetTrackingSystem.UserControls
{
    partial class RegisterUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_UserRole = new System.Windows.Forms.ComboBox();
            this.DTP_Age = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reg_Btn = new System.Windows.Forms.Button();
            this.lbl_userrole = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 141);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(521, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Log Users LogIn Infromation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(24, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(405, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Please enter the users\' personal information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 16F);
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(280, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 32);
            this.label8.TabIndex = 54;
            this.label8.Text = "REGISTER NEW USER ACCOUNT";
            // 
            // cb_UserRole
            // 
            this.cb_UserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_UserRole.FormattingEnabled = true;
            this.cb_UserRole.Items.AddRange(new object[] {
            "Select User Role",
            "Office Manager",
            "Vehicle Information Administrator",
            "Trip Manager",
            "Service Manager",
            "Timesheet Manager",
            "Driver",
            "Mechanic",
            "Customer"});
            this.cb_UserRole.Location = new System.Drawing.Point(659, 395);
            this.cb_UserRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_UserRole.Name = "cb_UserRole";
            this.cb_UserRole.Size = new System.Drawing.Size(268, 28);
            this.cb_UserRole.TabIndex = 53;
            // 
            // DTP_Age
            // 
            this.DTP_Age.Location = new System.Drawing.Point(162, 397);
            this.DTP_Age.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTP_Age.Name = "DTP_Age";
            this.DTP_Age.Size = new System.Drawing.Size(267, 27);
            this.DTP_Age.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8F);
            this.label1.Location = new System.Drawing.Point(24, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "First Name:";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(659, 345);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(268, 27);
            this.tb_Password.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8F);
            this.label2.Location = new System.Drawing.Point(22, 350);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Last Name:";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(659, 295);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(268, 27);
            this.tb_Username.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8F);
            this.label3.Location = new System.Drawing.Point(24, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Date Of Birth:";
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(162, 447);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(267, 27);
            this.tb_Address.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8F);
            this.label4.Location = new System.Drawing.Point(22, 457);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Address:";
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(162, 345);
            this.tb_LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(267, 27);
            this.tb_LastName.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8F);
            this.label5.Location = new System.Drawing.Point(520, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Username:";
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(162, 295);
            this.tb_FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(267, 27);
            this.tb_FirstName.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8F);
            this.label6.Location = new System.Drawing.Point(524, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Password:";
            // 
            // reg_Btn
            // 
            this.reg_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.reg_Btn.FlatAppearance.BorderSize = 0;
            this.reg_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_Btn.Font = new System.Drawing.Font("Consolas", 10F);
            this.reg_Btn.ForeColor = System.Drawing.Color.Transparent;
            this.reg_Btn.Location = new System.Drawing.Point(250, 536);
            this.reg_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reg_Btn.Name = "reg_Btn";
            this.reg_Btn.Size = new System.Drawing.Size(500, 48);
            this.reg_Btn.TabIndex = 45;
            this.reg_Btn.Text = "Register Employee";
            this.reg_Btn.UseVisualStyleBackColor = false;
            this.reg_Btn.Click += new System.EventHandler(this.reg_Btn_Click);
            // 
            // lbl_userrole
            // 
            this.lbl_userrole.AutoSize = true;
            this.lbl_userrole.Font = new System.Drawing.Font("Consolas", 8F);
            this.lbl_userrole.Location = new System.Drawing.Point(524, 407);
            this.lbl_userrole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userrole.Name = "lbl_userrole";
            this.lbl_userrole.Size = new System.Drawing.Size(96, 17);
            this.lbl_userrole.TabIndex = 46;
            this.lbl_userrole.Text = "User Role :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CargoFleetTrackingSystem.Properties.Resources.cargo_fleet_logo_round;
            this.pictureBox2.Location = new System.Drawing.Point(525, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_UserRole);
            this.Controls.Add(this.DTP_Age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reg_Btn);
            this.Controls.Add(this.lbl_userrole);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterUser";
            this.Size = new System.Drawing.Size(1142, 697);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_UserRole;
        private System.Windows.Forms.DateTimePicker DTP_Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button reg_Btn;
        private System.Windows.Forms.Label lbl_userrole;
    }
}
