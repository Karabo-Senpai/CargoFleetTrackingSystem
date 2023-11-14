namespace CargoFleetTrackingSystem.UserControls
{
    partial class UpdateVehicle
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicalMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicalModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicalYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargo_FleetDBDataSet9 = new CargoFleetTrackingSystem.Cargo_FleetDBDataSet9();
            this.label8 = new System.Windows.Forms.Label();
            this.vehicalTableAdapter = new CargoFleetTrackingSystem.Cargo_FleetDBDataSet9TableAdapters.VehicalTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_Status = new System.Windows.Forms.TextBox();
            this.tb_Model = new System.Windows.Forms.TextBox();
            this.tb_Year = new System.Windows.Forms.TextBox();
            this.tb_VIN = new System.Windows.Forms.TextBox();
            this.tb_EngineSize = new System.Windows.Forms.TextBox();
            this.tb_NP = new System.Windows.Forms.TextBox();
            this.tb_Capacity = new System.Windows.Forms.TextBox();
            this.tb_Make = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_FleetDBDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 160);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CargoFleetTrackingSystem.Properties.Resources.cargo_fleet_logo_round;
            this.pictureBox2.Location = new System.Drawing.Point(693, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(154, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 20);
            this.label7.TabIndex = 98;
            this.label7.Text = "Select Row To Be Edited";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(608, 202);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(431, 36);
            this.label10.TabIndex = 97;
            this.label10.Text = "UPDATE VEHICLE INFORMATION";
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
            this.vehicalIDDataGridViewTextBoxColumn,
            this.vehicalMakeDataGridViewTextBoxColumn,
            this.vehicalModelDataGridViewTextBoxColumn,
            this.vehicalYearDataGridViewTextBoxColumn,
            this.vINNumberDataGridViewTextBoxColumn,
            this.engineSizeDataGridViewTextBoxColumn,
            this.numberPlateDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehicleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(158, 329);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 404);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // vehicalIDDataGridViewTextBoxColumn
            // 
            this.vehicalIDDataGridViewTextBoxColumn.DataPropertyName = "VehicalID";
            this.vehicalIDDataGridViewTextBoxColumn.HeaderText = "VehicalID";
            this.vehicalIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicalIDDataGridViewTextBoxColumn.Name = "vehicalIDDataGridViewTextBoxColumn";
            this.vehicalIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicalIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicalMakeDataGridViewTextBoxColumn
            // 
            this.vehicalMakeDataGridViewTextBoxColumn.DataPropertyName = "Vehical_Make";
            this.vehicalMakeDataGridViewTextBoxColumn.HeaderText = "Vehical_Make";
            this.vehicalMakeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicalMakeDataGridViewTextBoxColumn.Name = "vehicalMakeDataGridViewTextBoxColumn";
            this.vehicalMakeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicalModelDataGridViewTextBoxColumn
            // 
            this.vehicalModelDataGridViewTextBoxColumn.DataPropertyName = "Vehical_Model";
            this.vehicalModelDataGridViewTextBoxColumn.HeaderText = "Vehical_Model";
            this.vehicalModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicalModelDataGridViewTextBoxColumn.Name = "vehicalModelDataGridViewTextBoxColumn";
            this.vehicalModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicalYearDataGridViewTextBoxColumn
            // 
            this.vehicalYearDataGridViewTextBoxColumn.DataPropertyName = "Vehical_Year";
            this.vehicalYearDataGridViewTextBoxColumn.HeaderText = "Vehical_Year";
            this.vehicalYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicalYearDataGridViewTextBoxColumn.Name = "vehicalYearDataGridViewTextBoxColumn";
            this.vehicalYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // vINNumberDataGridViewTextBoxColumn
            // 
            this.vINNumberDataGridViewTextBoxColumn.DataPropertyName = "VIN_Number";
            this.vINNumberDataGridViewTextBoxColumn.HeaderText = "VIN_Number";
            this.vINNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vINNumberDataGridViewTextBoxColumn.Name = "vINNumberDataGridViewTextBoxColumn";
            this.vINNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // engineSizeDataGridViewTextBoxColumn
            // 
            this.engineSizeDataGridViewTextBoxColumn.DataPropertyName = "Engine_Size";
            this.engineSizeDataGridViewTextBoxColumn.HeaderText = "Engine_Size";
            this.engineSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.engineSizeDataGridViewTextBoxColumn.Name = "engineSizeDataGridViewTextBoxColumn";
            this.engineSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberPlateDataGridViewTextBoxColumn
            // 
            this.numberPlateDataGridViewTextBoxColumn.DataPropertyName = "Number_Plate";
            this.numberPlateDataGridViewTextBoxColumn.HeaderText = "Number_Plate";
            this.numberPlateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberPlateDataGridViewTextBoxColumn.Name = "numberPlateDataGridViewTextBoxColumn";
            this.numberPlateDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehical";
            this.vehicleBindingSource.DataSource = this.cargo_FleetDBDataSet9;
            // 
            // cargo_FleetDBDataSet9
            // 
            this.cargo_FleetDBDataSet9.DataSetName = "Cargo_FleetDBDataSet9";
            this.cargo_FleetDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(455, 773);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(610, 28);
            this.label8.TabIndex = 100;
            this.label8.Text = "Enter The Information You Would Like To Change";
            // 
            // vehicalTableAdapter
            // 
            this.vehicalTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 1005);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 117;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(817, 944);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 116;
            this.label6.Text = "Capacity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(812, 898);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 115;
            this.label9.Text = "Number Plate :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(812, 848);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 114;
            this.label11.Text = "Engine Size : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 1005);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "VIN Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 944);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "Vehicle Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 899);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 111;
            this.label2.Text = "Vehicle Model :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 848);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "Vehicle Make:";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Font = new System.Drawing.Font("Consolas", 10F);
            this.btn_Update.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Update.Location = new System.Drawing.Point(534, 1082);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(452, 33);
            this.btn_Update.TabIndex = 109;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_Status
            // 
            this.tb_Status.Location = new System.Drawing.Point(950, 998);
            this.tb_Status.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.Size = new System.Drawing.Size(233, 27);
            this.tb_Status.TabIndex = 108;
            // 
            // tb_Model
            // 
            this.tb_Model.Location = new System.Drawing.Point(514, 892);
            this.tb_Model.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Model.Name = "tb_Model";
            this.tb_Model.Size = new System.Drawing.Size(233, 27);
            this.tb_Model.TabIndex = 107;
            // 
            // tb_Year
            // 
            this.tb_Year.Location = new System.Drawing.Point(514, 941);
            this.tb_Year.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Year.Name = "tb_Year";
            this.tb_Year.Size = new System.Drawing.Size(233, 27);
            this.tb_Year.TabIndex = 106;
            // 
            // tb_VIN
            // 
            this.tb_VIN.Location = new System.Drawing.Point(514, 998);
            this.tb_VIN.Margin = new System.Windows.Forms.Padding(4);
            this.tb_VIN.Name = "tb_VIN";
            this.tb_VIN.Size = new System.Drawing.Size(233, 27);
            this.tb_VIN.TabIndex = 105;
            // 
            // tb_EngineSize
            // 
            this.tb_EngineSize.Location = new System.Drawing.Point(950, 845);
            this.tb_EngineSize.Margin = new System.Windows.Forms.Padding(4);
            this.tb_EngineSize.Name = "tb_EngineSize";
            this.tb_EngineSize.Size = new System.Drawing.Size(233, 27);
            this.tb_EngineSize.TabIndex = 104;
            // 
            // tb_NP
            // 
            this.tb_NP.Location = new System.Drawing.Point(950, 896);
            this.tb_NP.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NP.Name = "tb_NP";
            this.tb_NP.Size = new System.Drawing.Size(233, 27);
            this.tb_NP.TabIndex = 103;
            // 
            // tb_Capacity
            // 
            this.tb_Capacity.Location = new System.Drawing.Point(950, 941);
            this.tb_Capacity.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Capacity.Name = "tb_Capacity";
            this.tb_Capacity.Size = new System.Drawing.Size(233, 27);
            this.tb_Capacity.TabIndex = 102;
            // 
            // tb_Make
            // 
            this.tb_Make.Location = new System.Drawing.Point(514, 841);
            this.tb_Make.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Make.Name = "tb_Make";
            this.tb_Make.Size = new System.Drawing.Size(233, 27);
            this.tb_Make.TabIndex = 101;
            // 
            // UpdateVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tb_Status);
            this.Controls.Add(this.tb_Model);
            this.Controls.Add(this.tb_Year);
            this.Controls.Add(this.tb_VIN);
            this.Controls.Add(this.tb_EngineSize);
            this.Controls.Add(this.tb_NP);
            this.Controls.Add(this.tb_Capacity);
            this.Controls.Add(this.tb_Make);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateVehicle";
            this.Size = new System.Drawing.Size(1537, 1200);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_FleetDBDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicalMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicalModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicalYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private Cargo_FleetDBDataSet9 cargo_FleetDBDataSet9;
        private Cargo_FleetDBDataSet9TableAdapters.VehicalTableAdapter vehicalTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_Status;
        private System.Windows.Forms.TextBox tb_Model;
        private System.Windows.Forms.TextBox tb_Year;
        private System.Windows.Forms.TextBox tb_VIN;
        private System.Windows.Forms.TextBox tb_EngineSize;
        private System.Windows.Forms.TextBox tb_NP;
        private System.Windows.Forms.TextBox tb_Capacity;
        private System.Windows.Forms.TextBox tb_Make;
    }
}
