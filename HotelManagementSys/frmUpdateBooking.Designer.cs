namespace HotelManagementSys
{
    partial class frmUpdateBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUpdateAndSave = new System.Windows.Forms.Label();
            this.btnUpdateAndSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.lblBookingPackageName = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbBookingPackageName = new System.Windows.Forms.ComboBox();
            this.dtmBookingDate = new System.Windows.Forms.DateTimePicker();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dtmBookingDate);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.cmbRoomNumber);
            this.panel1.Controls.Add(this.cmbBookingPackageName);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.lblRoomNumber);
            this.panel1.Controls.Add(this.lblBookingDate);
            this.panel1.Controls.Add(this.lblBookingPackageName);
            this.panel1.Controls.Add(this.txtBookingId);
            this.panel1.Controls.Add(this.lblBookingId);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 246);
            this.panel1.TabIndex = 26;
            // 
            // lblUpdateAndSave
            // 
            this.lblUpdateAndSave.AutoSize = true;
            this.lblUpdateAndSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAndSave.Location = new System.Drawing.Point(63, 278);
            this.lblUpdateAndSave.Name = "lblUpdateAndSave";
            this.lblUpdateAndSave.Size = new System.Drawing.Size(119, 17);
            this.lblUpdateAndSave.TabIndex = 27;
            this.lblUpdateAndSave.Text = "Update And Save";
            // 
            // btnUpdateAndSave
            // 
            this.btnUpdateAndSave.BackgroundImage = global::HotelManagementSys.Properties.Resources.SaveAndUpdate;
            this.btnUpdateAndSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateAndSave.FlatAppearance.BorderSize = 0;
            this.btnUpdateAndSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateAndSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateAndSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAndSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAndSave.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateAndSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAndSave.Location = new System.Drawing.Point(13, 266);
            this.btnUpdateAndSave.Name = "btnUpdateAndSave";
            this.btnUpdateAndSave.Size = new System.Drawing.Size(45, 41);
            this.btnUpdateAndSave.TabIndex = 25;
            this.btnUpdateAndSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateAndSave.UseVisualStyleBackColor = true;
            this.btnUpdateAndSave.Click += new System.EventHandler(this.btnUpdateAndSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(422, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 32);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Location = new System.Drawing.Point(101, 19);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(60, 13);
            this.lblBookingId.TabIndex = 28;
            this.lblBookingId.Text = "Booking ID";
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(167, 16);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.Size = new System.Drawing.Size(198, 20);
            this.txtBookingId.TabIndex = 29;
            // 
            // lblBookingPackageName
            // 
            this.lblBookingPackageName.AutoSize = true;
            this.lblBookingPackageName.Location = new System.Drawing.Point(38, 45);
            this.lblBookingPackageName.Name = "lblBookingPackageName";
            this.lblBookingPackageName.Size = new System.Drawing.Size(123, 13);
            this.lblBookingPackageName.TabIndex = 28;
            this.lblBookingPackageName.Text = "Booking Package Name";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(89, 71);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(72, 13);
            this.lblBookingDate.TabIndex = 28;
            this.lblBookingDate.Text = "Booking Date";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(86, 97);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(75, 13);
            this.lblRoomNumber.TabIndex = 28;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(79, 123);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 28;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(167, 120);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(344, 20);
            this.txtCustomerName.TabIndex = 29;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(101, 149);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 28;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(167, 146);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(344, 20);
            this.txtUserName.TabIndex = 29;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(124, 175);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // cmbBookingPackageName
            // 
            this.cmbBookingPackageName.FormattingEnabled = true;
            this.cmbBookingPackageName.Items.AddRange(new object[] {
            "Room Only",
            "Bed and Breakfast",
            "Half Board",
            "Full Board"});
            this.cmbBookingPackageName.Location = new System.Drawing.Point(167, 41);
            this.cmbBookingPackageName.Name = "cmbBookingPackageName";
            this.cmbBookingPackageName.Size = new System.Drawing.Size(344, 21);
            this.cmbBookingPackageName.TabIndex = 30;
            this.cmbBookingPackageName.Text = "Select";
            // 
            // dtmBookingDate
            // 
            this.dtmBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmBookingDate.Location = new System.Drawing.Point(167, 68);
            this.dtmBookingDate.Name = "dtmBookingDate";
            this.dtmBookingDate.Size = new System.Drawing.Size(198, 20);
            this.dtmBookingDate.TabIndex = 31;
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Location = new System.Drawing.Point(167, 93);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(198, 21);
            this.cmbRoomNumber.TabIndex = 30;
            this.cmbRoomNumber.Text = "Select";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Nonavailable"});
            this.cmbStatus.Location = new System.Drawing.Point(167, 172);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(198, 21);
            this.cmbStatus.TabIndex = 30;
            this.cmbStatus.Text = "Select";
            // 
            // frmUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUpdateAndSave);
            this.Controls.Add(this.btnUpdateAndSave);
            this.Name = "frmUpdateBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Booking";
            this.Load += new System.EventHandler(this.frmUpdateBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUpdateAndSave;
        private System.Windows.Forms.Button btnUpdateAndSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtmBookingDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.ComboBox cmbBookingPackageName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblBookingPackageName;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Label lblBookingId;
    }
}