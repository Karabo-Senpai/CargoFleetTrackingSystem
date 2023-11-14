namespace CargoFleetTrackingSystem.UserControls
{
    partial class UpdateEmployeeRates
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargo_FleetDBDataSet3 = new CargoFleetTrackingSystem.Cargo_FleetDBDataSet3();
            this.emp_RateTableAdapter = new CargoFleetTrackingSystem.Cargo_FleetDBDataSet3TableAdapters.Emp_RateTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Remove = new System.Windows.Forms.Button();
            this.Tb_RPH = new System.Windows.Forms.TextBox();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.Tb_Role = new System.Windows.Forms.TextBox();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_FleetDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(395, 520);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 20);
            this.label7.TabIndex = 100;
            this.label7.Text = "Select Row To Be Edited";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(697, 441);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(351, 36);
            this.label10.TabIndex = 99;
            this.label10.Text = "UPDATE EMPLOYEE RATES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1854, 201);
            this.panel1.TabIndex = 98;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CargoFleetTrackingSystem.Properties.Resources.cargo_fleet_logo_round;
            this.pictureBox2.Location = new System.Drawing.Point(811, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rateIDDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.rPHDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.wageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empRateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(399, 562);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 462);
            this.dataGridView1.TabIndex = 101;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // rateIDDataGridViewTextBoxColumn
            // 
            this.rateIDDataGridViewTextBoxColumn.DataPropertyName = "RateID";
            this.rateIDDataGridViewTextBoxColumn.HeaderText = "RateID";
            this.rateIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateIDDataGridViewTextBoxColumn.Name = "rateIDDataGridViewTextBoxColumn";
            this.rateIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rateIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // rPHDataGridViewTextBoxColumn
            // 
            this.rPHDataGridViewTextBoxColumn.DataPropertyName = "RPH";
            this.rPHDataGridViewTextBoxColumn.HeaderText = "RPH";
            this.rPHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rPHDataGridViewTextBoxColumn.Name = "rPHDataGridViewTextBoxColumn";
            this.rPHDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // wageDataGridViewTextBoxColumn
            // 
            this.wageDataGridViewTextBoxColumn.DataPropertyName = "Wage";
            this.wageDataGridViewTextBoxColumn.HeaderText = "Wage";
            this.wageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wageDataGridViewTextBoxColumn.Name = "wageDataGridViewTextBoxColumn";
            this.wageDataGridViewTextBoxColumn.Width = 125;
            // 
            // empRateBindingSource
            // 
            this.empRateBindingSource.DataMember = "Emp_Rate";
            this.empRateBindingSource.DataSource = this.cargo_FleetDBDataSet3;
            // 
            // cargo_FleetDBDataSet3
            // 
            this.cargo_FleetDBDataSet3.DataSetName = "Cargo_FleetDBDataSet3";
            this.cargo_FleetDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emp_RateTableAdapter
            // 
            this.emp_RateTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(624, 1064);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(610, 28);
            this.label8.TabIndex = 104;
            this.label8.Text = "Enter The Information You Would Like To Change";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1005, 1267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 118;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1005, 1223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 117;
            this.label5.Text = "Rate Per Hour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1005, 1181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 116;
            this.label6.Text = "End Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 1267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 115;
            this.label3.Text = "Start Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 1223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "Employee Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 1181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "Employee Role:";
            // 
            // Bt_Remove
            // 
            this.Bt_Remove.BackColor = System.Drawing.Color.DarkRed;
            this.Bt_Remove.FlatAppearance.BorderSize = 0;
            this.Bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Remove.Font = new System.Drawing.Font("Consolas", 10F);
            this.Bt_Remove.ForeColor = System.Drawing.SystemColors.Control;
            this.Bt_Remove.Location = new System.Drawing.Point(1148, 1392);
            this.Bt_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Remove.Name = "Bt_Remove";
            this.Bt_Remove.Size = new System.Drawing.Size(295, 49);
            this.Bt_Remove.TabIndex = 112;
            this.Bt_Remove.Text = "Remove";
            this.Bt_Remove.UseVisualStyleBackColor = false;
            this.Bt_Remove.Click += new System.EventHandler(this.Bt_Remove_Click);
            // 
            // Tb_RPH
            // 
            this.Tb_RPH.Location = new System.Drawing.Point(1148, 1219);
            this.Tb_RPH.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_RPH.Name = "Tb_RPH";
            this.Tb_RPH.Size = new System.Drawing.Size(295, 27);
            this.Tb_RPH.TabIndex = 109;
            // 
            // Tb_Name
            // 
            this.Tb_Name.Location = new System.Drawing.Point(555, 1219);
            this.Tb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(295, 27);
            this.Tb_Name.TabIndex = 106;
            // 
            // Tb_Role
            // 
            this.Tb_Role.Location = new System.Drawing.Point(555, 1177);
            this.Tb_Role.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Role.Name = "Tb_Role";
            this.Tb_Role.Size = new System.Drawing.Size(295, 27);
            this.Tb_Role.TabIndex = 105;
            // 
            // Bt_Update
            // 
            this.Bt_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.Bt_Update.FlatAppearance.BorderSize = 0;
            this.Bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Update.Font = new System.Drawing.Font("Consolas", 10F);
            this.Bt_Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bt_Update.Location = new System.Drawing.Point(555, 1392);
            this.Bt_Update.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(295, 49);
            this.Bt_Update.TabIndex = 111;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = false;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(555, 1267);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 27);
            this.dateTimePicker1.TabIndex = 119;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1148, 1175);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(295, 27);
            this.dateTimePicker2.TabIndex = 120;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(1148, 1267);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(295, 27);
            this.dateTimePicker3.TabIndex = 121;
            // 
            // UpdateEmployeeRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_Remove);
            this.Controls.Add(this.Tb_RPH);
            this.Controls.Add(this.Tb_Name);
            this.Controls.Add(this.Tb_Role);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateEmployeeRates";
            this.Size = new System.Drawing.Size(1854, 1814);
            this.Load += new System.EventHandler(this.UpdateEmployeeRates_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_FleetDBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rPHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empRateBindingSource;
        private Cargo_FleetDBDataSet3 cargo_FleetDBDataSet3;
        private Cargo_FleetDBDataSet3TableAdapters.Emp_RateTableAdapter emp_RateTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Remove;
        private System.Windows.Forms.TextBox Tb_RPH;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.TextBox Tb_Role;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}
