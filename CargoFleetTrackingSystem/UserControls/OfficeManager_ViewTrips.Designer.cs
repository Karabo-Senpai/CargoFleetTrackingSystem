namespace CargoFleetTrackingSystem.UserControls
{
    partial class OfficeManager_ViewTrips
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
            this.panelOfficeManagerViewTrips = new System.Windows.Forms.Panel();
            this.btn_Complete = new System.Windows.Forms.Button();
            this.btn_PendingTrips = new System.Windows.Forms.Button();
            this.btn_ActiveTrips = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelOfficeManagerViewTrips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOfficeManagerViewTrips
            // 
            this.panelOfficeManagerViewTrips.Controls.Add(this.btn_Complete);
            this.panelOfficeManagerViewTrips.Controls.Add(this.btn_PendingTrips);
            this.panelOfficeManagerViewTrips.Controls.Add(this.btn_ActiveTrips);
            this.panelOfficeManagerViewTrips.Controls.Add(this.dataGridView1);
            this.panelOfficeManagerViewTrips.Controls.Add(this.label8);
            this.panelOfficeManagerViewTrips.Controls.Add(this.panel1);
            this.panelOfficeManagerViewTrips.Location = new System.Drawing.Point(0, -1);
            this.panelOfficeManagerViewTrips.Name = "panelOfficeManagerViewTrips";
            this.panelOfficeManagerViewTrips.Size = new System.Drawing.Size(1565, 949);
            this.panelOfficeManagerViewTrips.TabIndex = 0;
            this.panelOfficeManagerViewTrips.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOfficeManagerViewTrips_Paint);
            // 
            // btn_Complete
            // 
            this.btn_Complete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Complete.FlatAppearance.BorderSize = 0;
            this.btn_Complete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Complete.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Complete.Location = new System.Drawing.Point(23, 842);
            this.btn_Complete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Complete.Name = "btn_Complete";
            this.btn_Complete.Size = new System.Drawing.Size(265, 36);
            this.btn_Complete.TabIndex = 45;
            this.btn_Complete.Text = "Complete Trip";
            this.btn_Complete.UseVisualStyleBackColor = false;
            this.btn_Complete.Click += new System.EventHandler(this.btn_Complete_Click);
            // 
            // btn_PendingTrips
            // 
            this.btn_PendingTrips.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_PendingTrips.FlatAppearance.BorderSize = 0;
            this.btn_PendingTrips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PendingTrips.ForeColor = System.Drawing.Color.Transparent;
            this.btn_PendingTrips.Location = new System.Drawing.Point(668, 842);
            this.btn_PendingTrips.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PendingTrips.Name = "btn_PendingTrips";
            this.btn_PendingTrips.Size = new System.Drawing.Size(265, 36);
            this.btn_PendingTrips.TabIndex = 44;
            this.btn_PendingTrips.Text = "Pending Trip";
            this.btn_PendingTrips.UseVisualStyleBackColor = false;
            this.btn_PendingTrips.Click += new System.EventHandler(this.btn_PendingTrips_Click);
            // 
            // btn_ActiveTrips
            // 
            this.btn_ActiveTrips.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_ActiveTrips.FlatAppearance.BorderSize = 0;
            this.btn_ActiveTrips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActiveTrips.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ActiveTrips.Location = new System.Drawing.Point(1273, 842);
            this.btn_ActiveTrips.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ActiveTrips.Name = "btn_ActiveTrips";
            this.btn_ActiveTrips.Size = new System.Drawing.Size(265, 36);
            this.btn_ActiveTrips.TabIndex = 43;
            this.btn_ActiveTrips.Text = "Active Trips";
            this.btn_ActiveTrips.UseVisualStyleBackColor = false;
            this.btn_ActiveTrips.Click += new System.EventHandler(this.btn_ActiveTrips_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 284);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1515, 501);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(662, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 32);
            this.label8.TabIndex = 41;
            this.label8.Text = "VIEW ALL TRIP STATUSES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1565, 176);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CargoFleetTrackingSystem.Properties.Resources.cargo_fleet_logo_round;
            this.pictureBox2.Location = new System.Drawing.Point(743, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // OfficeManager_ViewTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOfficeManagerViewTrips);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OfficeManager_ViewTrips";
            this.Size = new System.Drawing.Size(1565, 949);
            this.panelOfficeManagerViewTrips.ResumeLayout(false);
            this.panelOfficeManagerViewTrips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOfficeManagerViewTrips;
        private System.Windows.Forms.Button btn_Complete;
        private System.Windows.Forms.Button btn_PendingTrips;
        private System.Windows.Forms.Button btn_ActiveTrips;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
