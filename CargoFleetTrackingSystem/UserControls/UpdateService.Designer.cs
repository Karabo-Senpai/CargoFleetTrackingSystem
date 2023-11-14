namespace CargoFleetTrackingSystem.UserControls
{
    partial class UpdateService
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMilageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargo_FleetDBDataSet6 = new CargoFleetTrackingSystem.Cargo_FleetDBDataSet6();
            this.label7 = new System.Windows.Forms.Label();
            this.serviceTableAdapter = new CargoFleetTrackingSystem.Cargo_FleetDBDataSet6TableAdapters.ServiceTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_VModel = new System.Windows.Forms.TextBox();
            this.tb_NP = new System.Windows.Forms.TextBox();
            this.tb_Milage = new System.Windows.Forms.TextBox();
            this.tb_Problem = new System.Windows.Forms.TextBox();
            this.tb_Status = new System.Windows.Forms.TextBox();
            this.tb_VMak = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_FleetDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1718, 200);
            this.panel1.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(573, 220);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(559, 36);
            this.label10.TabIndex = 98;
            this.label10.Text = "UPDATE VEHICLE SERVICE INFORMATION";
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            this.serviceIDDataGridViewTextBoxColumn,
            this.vehicleMakeDataGridViewTextBoxColumn,
            this.vehicleModelDataGridViewTextBoxColumn,
            this.numberPlateDataGridViewTextBoxColumn,
            this.totalMilageDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.problemDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(269, 331);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 404);
            this.dataGridView1.TabIndex = 101;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleMakeDataGridViewTextBoxColumn
            // 
            this.vehicleMakeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Make";
            this.vehicleMakeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Make";
            this.vehicleMakeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleMakeDataGridViewTextBoxColumn.Name = "vehicleMakeDataGridViewTextBoxColumn";
            this.vehicleMakeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleModelDataGridViewTextBoxColumn
            // 
            this.vehicleModelDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Model";
            this.vehicleModelDataGridViewTextBoxColumn.HeaderText = "Vehicle_Model";
            this.vehicleModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleModelDataGridViewTextBoxColumn.Name = "vehicleModelDataGridViewTextBoxColumn";
            this.vehicleModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberPlateDataGridViewTextBoxColumn
            // 
            this.numberPlateDataGridViewTextBoxColumn.DataPropertyName = "Number_Plate";
            this.numberPlateDataGridViewTextBoxColumn.HeaderText = "Number_Plate";
            this.numberPlateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberPlateDataGridViewTextBoxColumn.Name = "numberPlateDataGridViewTextBoxColumn";
            this.numberPlateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalMilageDataGridViewTextBoxColumn
            // 
            this.totalMilageDataGridViewTextBoxColumn.DataPropertyName = "Total_Milage";
            this.totalMilageDataGridViewTextBoxColumn.HeaderText = "Total_Milage";
            this.totalMilageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalMilageDataGridViewTextBoxColumn.Name = "totalMilageDataGridViewTextBoxColumn";
            this.totalMilageDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // problemDataGridViewTextBoxColumn
            // 
            this.problemDataGridViewTextBoxColumn.DataPropertyName = "Problem";
            this.problemDataGridViewTextBoxColumn.HeaderText = "Problem";
            this.problemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.problemDataGridViewTextBoxColumn.Name = "problemDataGridViewTextBoxColumn";
            this.problemDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.cargo_FleetDBDataSet6;
            // 
            // cargo_FleetDBDataSet6
            // 
            this.cargo_FleetDBDataSet6.DataSetName = "Cargo_FleetDBDataSet6";
            this.cargo_FleetDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(265, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 20);
            this.label7.TabIndex = 100;
            this.label7.Text = "Select Row To Be Edited";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(484, 765);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(610, 28);
            this.label8.TabIndex = 102;
            this.label8.Text = "Enter The Information You Would Like To Change";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(848, 942);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 118;
            this.label5.Text = "Service Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 890);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 20);
            this.label6.TabIndex = 117;
            this.label6.Text = "Problem Description :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(866, 841);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 116;
            this.label9.Text = "Service Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 990);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Vehicle Mileage : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 935);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 114;
            this.label3.Text = "Number Plate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 873);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 113;
            this.label2.Text = "Vehicle Model :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 827);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 112;
            this.label1.Text = "Vehicle Make :";
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.BackColor = System.Drawing.Color.DarkRed;
            this.Btn_Remove.FlatAppearance.BorderSize = 0;
            this.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Remove.Font = new System.Drawing.Font("Consolas", 10F);
            this.Btn_Remove.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Remove.Location = new System.Drawing.Point(852, 1077);
            this.Btn_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(423, 33);
            this.Btn_Remove.TabIndex = 111;
            this.Btn_Remove.Text = "REMOVE";
            this.Btn_Remove.UseVisualStyleBackColor = false;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Font = new System.Drawing.Font("Consolas", 10F);
            this.btn_Update.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Update.Location = new System.Drawing.Point(224, 1077);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(441, 33);
            this.btn_Update.TabIndex = 110;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_VModel
            // 
            this.tb_VModel.Location = new System.Drawing.Point(410, 870);
            this.tb_VModel.Margin = new System.Windows.Forms.Padding(4);
            this.tb_VModel.Name = "tb_VModel";
            this.tb_VModel.Size = new System.Drawing.Size(255, 27);
            this.tb_VModel.TabIndex = 109;
            // 
            // tb_NP
            // 
            this.tb_NP.Location = new System.Drawing.Point(410, 928);
            this.tb_NP.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NP.Name = "tb_NP";
            this.tb_NP.Size = new System.Drawing.Size(255, 27);
            this.tb_NP.TabIndex = 108;
            // 
            // tb_Milage
            // 
            this.tb_Milage.Location = new System.Drawing.Point(410, 983);
            this.tb_Milage.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Milage.Name = "tb_Milage";
            this.tb_Milage.Size = new System.Drawing.Size(255, 27);
            this.tb_Milage.TabIndex = 107;
            // 
            // tb_Problem
            // 
            this.tb_Problem.Location = new System.Drawing.Point(1015, 887);
            this.tb_Problem.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Problem.Name = "tb_Problem";
            this.tb_Problem.Size = new System.Drawing.Size(260, 27);
            this.tb_Problem.TabIndex = 105;
            // 
            // tb_Status
            // 
            this.tb_Status.Location = new System.Drawing.Point(1015, 935);
            this.tb_Status.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.Size = new System.Drawing.Size(260, 27);
            this.tb_Status.TabIndex = 104;
            // 
            // tb_VMak
            // 
            this.tb_VMak.Location = new System.Drawing.Point(410, 824);
            this.tb_VMak.Margin = new System.Windows.Forms.Padding(4);
            this.tb_VMak.Name = "tb_VMak";
            this.tb_VMak.Size = new System.Drawing.Size(255, 27);
            this.tb_VMak.TabIndex = 103;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1015, 841);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 27);
            this.dateTimePicker1.TabIndex = 119;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CargoFleetTrackingSystem.Properties.Resources.cargo_fleet_logo_round;
            this.pictureBox2.Location = new System.Drawing.Point(723, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // UpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tb_VModel);
            this.Controls.Add(this.tb_NP);
            this.Controls.Add(this.tb_Milage);
            this.Controls.Add(this.tb_Problem);
            this.Controls.Add(this.tb_Status);
            this.Controls.Add(this.tb_VMak);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateService";
            this.Size = new System.Drawing.Size(1718, 1161);
            this.Load += new System.EventHandler(this.UpdateService_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_FleetDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMilageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private Cargo_FleetDBDataSet6 cargo_FleetDBDataSet6;
        private System.Windows.Forms.Label label7;
        private Cargo_FleetDBDataSet6TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_VModel;
        private System.Windows.Forms.TextBox tb_NP;
        private System.Windows.Forms.TextBox tb_Milage;
        private System.Windows.Forms.TextBox tb_Problem;
        private System.Windows.Forms.TextBox tb_Status;
        private System.Windows.Forms.TextBox tb_VMak;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
