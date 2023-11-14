namespace CargoFleetTrackingSystem.UserControls
{
    partial class UpdateFuelConsumption
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fuelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelConsumptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargo_FleetDBDataSet4 = new CargoFleetTrackingSystem.Cargo_FleetDBDataSet4();
            this.fuel_ConsumptionTableAdapter = new CargoFleetTrackingSystem.Cargo_FleetDBDataSet4TableAdapters.Fuel_ConsumptionTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.tb_BeforeTrip = new System.Windows.Forms.TextBox();
            this.tb_AfterTrip = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tb_NP = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelConsumptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_FleetDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1933, 201);
            this.panel1.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(699, 289);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(575, 36);
            this.label10.TabIndex = 71;
            this.label10.Text = "UPDATE FUEL CONSUMPTION INFORMATION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(402, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Select Row To Be Edited";
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
            this.fuelIDDataGridViewTextBoxColumn,
            this.numberPlateDataGridViewTextBoxColumn,
            this.lBTDataGridViewTextBoxColumn,
            this.lATDataGridViewTextBoxColumn,
            this.pPLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fuelConsumptionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(406, 414);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 505);
            this.dataGridView1.TabIndex = 102;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // fuelIDDataGridViewTextBoxColumn
            // 
            this.fuelIDDataGridViewTextBoxColumn.DataPropertyName = "FuelID";
            this.fuelIDDataGridViewTextBoxColumn.HeaderText = "FuelID";
            this.fuelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuelIDDataGridViewTextBoxColumn.Name = "fuelIDDataGridViewTextBoxColumn";
            this.fuelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fuelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberPlateDataGridViewTextBoxColumn
            // 
            this.numberPlateDataGridViewTextBoxColumn.DataPropertyName = "Number_Plate";
            this.numberPlateDataGridViewTextBoxColumn.HeaderText = "Number_Plate";
            this.numberPlateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberPlateDataGridViewTextBoxColumn.Name = "numberPlateDataGridViewTextBoxColumn";
            this.numberPlateDataGridViewTextBoxColumn.Width = 125;
            // 
            // lBTDataGridViewTextBoxColumn
            // 
            this.lBTDataGridViewTextBoxColumn.DataPropertyName = "L_B_T";
            this.lBTDataGridViewTextBoxColumn.HeaderText = "L_B_T";
            this.lBTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lBTDataGridViewTextBoxColumn.Name = "lBTDataGridViewTextBoxColumn";
            this.lBTDataGridViewTextBoxColumn.Width = 125;
            // 
            // lATDataGridViewTextBoxColumn
            // 
            this.lATDataGridViewTextBoxColumn.DataPropertyName = "L_A_T";
            this.lATDataGridViewTextBoxColumn.HeaderText = "L_A_T";
            this.lATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lATDataGridViewTextBoxColumn.Name = "lATDataGridViewTextBoxColumn";
            this.lATDataGridViewTextBoxColumn.Width = 125;
            // 
            // pPLDataGridViewTextBoxColumn
            // 
            this.pPLDataGridViewTextBoxColumn.DataPropertyName = "PPL";
            this.pPLDataGridViewTextBoxColumn.HeaderText = "PPL";
            this.pPLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pPLDataGridViewTextBoxColumn.Name = "pPLDataGridViewTextBoxColumn";
            this.pPLDataGridViewTextBoxColumn.Width = 125;
            // 
            // fuelConsumptionBindingSource
            // 
            this.fuelConsumptionBindingSource.DataMember = "Fuel_Consumption";
            this.fuelConsumptionBindingSource.DataSource = this.cargo_FleetDBDataSet4;
            // 
            // cargo_FleetDBDataSet4
            // 
            this.cargo_FleetDBDataSet4.DataSetName = "Cargo_FleetDBDataSet4";
            this.cargo_FleetDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fuel_ConsumptionTableAdapter
            // 
            this.fuel_ConsumptionTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(700, 961);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(610, 28);
            this.label8.TabIndex = 103;
            this.label8.Text = "Enter The Information You Would Like To Change";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Font = new System.Drawing.Font("Consolas", 10F);
            this.btn_Update.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Update.Location = new System.Drawing.Point(1091, 1157);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(310, 41);
            this.btn_Update.TabIndex = 104;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 1264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 123;
            this.label4.Text = "Fuel Price : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 1195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 122;
            this.label3.Text = "Mileage After Trip :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 1126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 121;
            this.label2.Text = "Mileage Before Trip :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 1061);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "Number Plate :";
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.BackColor = System.Drawing.Color.DarkRed;
            this.Btn_Remove.FlatAppearance.BorderSize = 0;
            this.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Remove.Font = new System.Drawing.Font("Consolas", 10F);
            this.Btn_Remove.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Remove.Location = new System.Drawing.Point(1091, 1241);
            this.Btn_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(310, 41);
            this.Btn_Remove.TabIndex = 124;
            this.Btn_Remove.Text = "REMOVE";
            this.Btn_Remove.UseVisualStyleBackColor = false;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // tb_BeforeTrip
            // 
            this.tb_BeforeTrip.Location = new System.Drawing.Point(610, 1119);
            this.tb_BeforeTrip.Margin = new System.Windows.Forms.Padding(4);
            this.tb_BeforeTrip.Name = "tb_BeforeTrip";
            this.tb_BeforeTrip.Size = new System.Drawing.Size(335, 27);
            this.tb_BeforeTrip.TabIndex = 128;
            // 
            // tb_AfterTrip
            // 
            this.tb_AfterTrip.Location = new System.Drawing.Point(610, 1188);
            this.tb_AfterTrip.Margin = new System.Windows.Forms.Padding(4);
            this.tb_AfterTrip.Name = "tb_AfterTrip";
            this.tb_AfterTrip.Size = new System.Drawing.Size(335, 27);
            this.tb_AfterTrip.TabIndex = 127;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(610, 1261);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(335, 27);
            this.tbPrice.TabIndex = 126;
            // 
            // tb_NP
            // 
            this.tb_NP.Location = new System.Drawing.Point(610, 1062);
            this.tb_NP.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NP.Name = "tb_NP";
            this.tb_NP.Size = new System.Drawing.Size(335, 27);
            this.tb_NP.TabIndex = 125;
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
            // UpdateFuelConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_BeforeTrip);
            this.Controls.Add(this.tb_AfterTrip);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tb_NP);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateFuelConsumption";
            this.Size = new System.Drawing.Size(1933, 1451);
            this.Load += new System.EventHandler(this.UpdateFuelConsumption_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelConsumptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargo_FleetDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Cargo_FleetDBDataSet4 cargo_FleetDBDataSet4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fuelConsumptionBindingSource;
        private Cargo_FleetDBDataSet4TableAdapters.Fuel_ConsumptionTableAdapter fuel_ConsumptionTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.TextBox tb_BeforeTrip;
        private System.Windows.Forms.TextBox tb_AfterTrip;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tb_NP;
    }
}
