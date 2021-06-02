namespace HotelManagementSys
{
    partial class frmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnCustomerDetails = new System.Windows.Forms.Button();
            this.btnStockDetails = new System.Windows.Forms.Button();
            this.btnEmployeeDetails = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnPackageDEtails = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.btnMinimize = new System.Windows.Forms.Panel();
            this.dtmTime = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnCustomerDetails);
            this.panel1.Controls.Add(this.btnStockDetails);
            this.panel1.Controls.Add(this.btnEmployeeDetails);
            this.panel1.Controls.Add(this.btnInvoice);
            this.panel1.Controls.Add(this.btnPackageDEtails);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 773);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::HotelManagementSys.Properties.Resources.Logo_copy1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(122, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 127);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBooking.BackgroundImage = global::HotelManagementSys.Properties.Resources.Booking;
            this.btnBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBooking.Enabled = false;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Location = new System.Drawing.Point(0, 270);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(420, 60);
            this.btnBooking.TabIndex = 0;
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            this.btnBooking.MouseLeave += new System.EventHandler(this.btnRooms_MouseLeave);
            this.btnBooking.MouseHover += new System.EventHandler(this.btnRooms_MouseHover);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::HotelManagementSys.Properties.Resources.LogoutNew;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 209);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(420, 60);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.BackgroundImage = global::HotelManagementSys.Properties.Resources.BackupNew;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackup.Enabled = false;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Location = new System.Drawing.Point(0, 639);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(420, 60);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.MouseLeave += new System.EventHandler(this.btnBar_MouseLeave);
            this.btnBackup.MouseHover += new System.EventHandler(this.btnBar_MouseHover);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerDetails.BackgroundImage = global::HotelManagementSys.Properties.Resources.CustomerNew;
            this.btnCustomerDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomerDetails.Enabled = false;
            this.btnCustomerDetails.FlatAppearance.BorderSize = 0;
            this.btnCustomerDetails.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCustomerDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCustomerDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDetails.Location = new System.Drawing.Point(0, 453);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(420, 60);
            this.btnCustomerDetails.TabIndex = 0;
            this.btnCustomerDetails.UseVisualStyleBackColor = false;
            this.btnCustomerDetails.MouseLeave += new System.EventHandler(this.btnCustomerDetails_MouseLeave);
            this.btnCustomerDetails.MouseHover += new System.EventHandler(this.btnCustomerDetails_MouseHover);
            // 
            // btnStockDetails
            // 
            this.btnStockDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnStockDetails.BackgroundImage = global::HotelManagementSys.Properties.Resources.StockNew;
            this.btnStockDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStockDetails.Enabled = false;
            this.btnStockDetails.FlatAppearance.BorderSize = 0;
            this.btnStockDetails.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnStockDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStockDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStockDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockDetails.Location = new System.Drawing.Point(0, 392);
            this.btnStockDetails.Name = "btnStockDetails";
            this.btnStockDetails.Size = new System.Drawing.Size(420, 60);
            this.btnStockDetails.TabIndex = 0;
            this.btnStockDetails.UseVisualStyleBackColor = false;
            this.btnStockDetails.Click += new System.EventHandler(this.btnStockDetails_Click);
            this.btnStockDetails.MouseLeave += new System.EventHandler(this.btnStockDetails_MouseLeave);
            this.btnStockDetails.MouseHover += new System.EventHandler(this.btnStockDetails_MouseHover);
            // 
            // btnEmployeeDetails
            // 
            this.btnEmployeeDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeDetails.BackgroundImage = global::HotelManagementSys.Properties.Resources.EmployeeNew;
            this.btnEmployeeDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployeeDetails.Enabled = false;
            this.btnEmployeeDetails.FlatAppearance.BorderSize = 0;
            this.btnEmployeeDetails.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEmployeeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeDetails.Location = new System.Drawing.Point(0, 575);
            this.btnEmployeeDetails.Name = "btnEmployeeDetails";
            this.btnEmployeeDetails.Size = new System.Drawing.Size(420, 60);
            this.btnEmployeeDetails.TabIndex = 0;
            this.btnEmployeeDetails.UseVisualStyleBackColor = false;
            this.btnEmployeeDetails.Click += new System.EventHandler(this.btnEmployeeDetails_Click);
            this.btnEmployeeDetails.MouseLeave += new System.EventHandler(this.btnEmployeeDetails_MouseLeave);
            this.btnEmployeeDetails.MouseHover += new System.EventHandler(this.btnEmployeeDetails_MouseHover);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.BackgroundImage = global::HotelManagementSys.Properties.Resources.InvoiceNew;
            this.btnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInvoice.Enabled = false;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Location = new System.Drawing.Point(0, 331);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(420, 60);
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            this.btnInvoice.MouseLeave += new System.EventHandler(this.btnInvoice_MouseLeave);
            this.btnInvoice.MouseHover += new System.EventHandler(this.btnInvoice_MouseHover);
            // 
            // btnPackageDEtails
            // 
            this.btnPackageDEtails.BackColor = System.Drawing.Color.Transparent;
            this.btnPackageDEtails.BackgroundImage = global::HotelManagementSys.Properties.Resources.PackageNew;
            this.btnPackageDEtails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPackageDEtails.Enabled = false;
            this.btnPackageDEtails.FlatAppearance.BorderSize = 0;
            this.btnPackageDEtails.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPackageDEtails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPackageDEtails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPackageDEtails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackageDEtails.Location = new System.Drawing.Point(0, 514);
            this.btnPackageDEtails.Name = "btnPackageDEtails";
            this.btnPackageDEtails.Size = new System.Drawing.Size(420, 60);
            this.btnPackageDEtails.TabIndex = 0;
            this.btnPackageDEtails.UseVisualStyleBackColor = false;
            this.btnPackageDEtails.Click += new System.EventHandler(this.btnPackageDEtails_Click);
            this.btnPackageDEtails.MouseLeave += new System.EventHandler(this.btnPackageDEtails_MouseLeave);
            this.btnPackageDEtails.MouseHover += new System.EventHandler(this.btnPackageDEtails_MouseHover);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::HotelManagementSys.Properties.Resources.LoginNew;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(0, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(420, 60);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::HotelManagementSys.Properties.Resources.power;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1302, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // dtmDate
            // 
            this.dtmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDate.Location = new System.Drawing.Point(989, 27);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(140, 23);
            this.dtmDate.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Location = new System.Drawing.Point(435, 81);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(919, 675);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Paint += new System.Windows.Forms.PaintEventHandler(this.btnMinimize_Paint);
            // 
            // dtmTime
            // 
            this.dtmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmTime.Location = new System.Drawing.Point(1132, 27);
            this.dtmTime.Name = "dtmTime";
            this.dtmTime.Size = new System.Drawing.Size(150, 23);
            this.dtmTime.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagementSys.Properties.Resources.HotelBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.dtmTime);
            this.Controls.Add(this.dtmDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCustomerDetails;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnStockDetails;
        private System.Windows.Forms.Button btnEmployeeDetails;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnPackageDEtails;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.Panel btnMinimize;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DateTimePicker dtmTime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

