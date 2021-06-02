namespace HotelManagementSys
{
    partial class frmBooking
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
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBooking = new System.Windows.Forms.Label();
            this.grpAddBookings = new System.Windows.Forms.GroupBox();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.cmdBookingPackageName = new System.Windows.Forms.ComboBox();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.dtmBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblBookingPackageName = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlBookingDetails = new System.Windows.Forms.Panel();
            this.btnCanselBooking = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnComplteBooking = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.dgvBookingViwe = new System.Windows.Forms.DataGridView();
            this.dgBookingIdBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBookingPackageNameBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBookingDateBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRoomNumberBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUserNameBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStatusBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcBookingDate = new System.Windows.Forms.MonthCalendar();
            this.btnBookingReport = new System.Windows.Forms.Button();
            this.pnlInvoice.SuspendLayout();
            this.grpAddBookings.SuspendLayout();
            this.pnlBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingViwe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlInvoice.Controls.Add(this.btnClose);
            this.pnlInvoice.Controls.Add(this.lblBooking);
            this.pnlInvoice.Location = new System.Drawing.Point(0, 0);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(921, 39);
            this.pnlInvoice.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(881, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBooking.Location = new System.Drawing.Point(429, 9);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(67, 20);
            this.lblBooking.TabIndex = 0;
            this.lblBooking.Text = "Booking";
            // 
            // grpAddBookings
            // 
            this.grpAddBookings.Controls.Add(this.cmbRoomNumber);
            this.grpAddBookings.Controls.Add(this.cmbRoomType);
            this.grpAddBookings.Controls.Add(this.cmdBookingPackageName);
            this.grpAddBookings.Controls.Add(this.btnCansel);
            this.grpAddBookings.Controls.Add(this.btnBookNow);
            this.grpAddBookings.Controls.Add(this.dtmBookingDate);
            this.grpAddBookings.Controls.Add(this.txtUserName);
            this.grpAddBookings.Controls.Add(this.lblUserName);
            this.grpAddBookings.Controls.Add(this.txtCustomerName);
            this.grpAddBookings.Controls.Add(this.lblCustomerName);
            this.grpAddBookings.Controls.Add(this.lblRoomType);
            this.grpAddBookings.Controls.Add(this.lblRoomNumber);
            this.grpAddBookings.Controls.Add(this.lblBookingDate);
            this.grpAddBookings.Controls.Add(this.lblBookingPackageName);
            this.grpAddBookings.Controls.Add(this.txtBookingId);
            this.grpAddBookings.Controls.Add(this.lblBookingId);
            this.grpAddBookings.Enabled = false;
            this.grpAddBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpAddBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.grpAddBookings.Location = new System.Drawing.Point(184, 379);
            this.grpAddBookings.Name = "grpAddBookings";
            this.grpAddBookings.Size = new System.Drawing.Size(684, 265);
            this.grpAddBookings.TabIndex = 4;
            this.grpAddBookings.TabStop = false;
            this.grpAddBookings.Text = "Add Booking";
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Location = new System.Drawing.Point(366, 132);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(121, 24);
            this.cmbRoomNumber.TabIndex = 6;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "AC",
            "NON AC"});
            this.cmbRoomType.Location = new System.Drawing.Point(143, 131);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(92, 24);
            this.cmbRoomType.TabIndex = 6;
            this.cmbRoomType.Text = "AC";
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // cmdBookingPackageName
            // 
            this.cmdBookingPackageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdBookingPackageName.FormattingEnabled = true;
            this.cmdBookingPackageName.Location = new System.Drawing.Point(143, 74);
            this.cmdBookingPackageName.Name = "cmdBookingPackageName";
            this.cmdBookingPackageName.Size = new System.Drawing.Size(344, 24);
            this.cmdBookingPackageName.TabIndex = 5;
            this.cmdBookingPackageName.Text = "Select";
            // 
            // btnCansel
            // 
            this.btnCansel.BackColor = System.Drawing.Color.Transparent;
            this.btnCansel.BackgroundImage = global::HotelManagementSys.Properties.Resources.button;
            this.btnCansel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCansel.FlatAppearance.BorderSize = 0;
            this.btnCansel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCansel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCansel.ForeColor = System.Drawing.Color.Black;
            this.btnCansel.Location = new System.Drawing.Point(531, 203);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(114, 47);
            this.btnCansel.TabIndex = 4;
            this.btnCansel.Text = "Cansel";
            this.btnCansel.UseVisualStyleBackColor = false;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackColor = System.Drawing.Color.Transparent;
            this.btnBookNow.BackgroundImage = global::HotelManagementSys.Properties.Resources.bookingButton;
            this.btnBookNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBookNow.FlatAppearance.BorderSize = 0;
            this.btnBookNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBookNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookNow.Location = new System.Drawing.Point(514, 77);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(131, 95);
            this.btnBookNow.TabIndex = 3;
            this.btnBookNow.UseVisualStyleBackColor = false;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // dtmBookingDate
            // 
            this.dtmBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmBookingDate.Location = new System.Drawing.Point(143, 103);
            this.dtmBookingDate.Name = "dtmBookingDate";
            this.dtmBookingDate.Size = new System.Drawing.Size(124, 23);
            this.dtmBookingDate.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUserName.Location = new System.Drawing.Point(143, 190);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(344, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(58, 193);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCustomerName.Location = new System.Drawing.Point(143, 161);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(344, 23);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(28, 164);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 17);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(56, 135);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(81, 17);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(261, 135);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(99, 17);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(44, 108);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(93, 17);
            this.lblBookingDate.TabIndex = 0;
            this.lblBookingDate.Text = "Booking Date";
            // 
            // lblBookingPackageName
            // 
            this.lblBookingPackageName.AutoSize = true;
            this.lblBookingPackageName.Location = new System.Drawing.Point(74, 77);
            this.lblBookingPackageName.Name = "lblBookingPackageName";
            this.lblBookingPackageName.Size = new System.Drawing.Size(63, 17);
            this.lblBookingPackageName.TabIndex = 0;
            this.lblBookingPackageName.Text = "Package";
            // 
            // txtBookingId
            // 
            this.txtBookingId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBookingId.Location = new System.Drawing.Point(143, 45);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.Size = new System.Drawing.Size(193, 23);
            this.txtBookingId.TabIndex = 1;
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Location = new System.Drawing.Point(63, 48);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(74, 17);
            this.lblBookingId.TabIndex = 0;
            this.lblBookingId.Text = "Booking Id";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Crimson;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(34, 389);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(132, 40);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnlBookingDetails
            // 
            this.pnlBookingDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBookingDetails.Controls.Add(this.btnCanselBooking);
            this.pnlBookingDetails.Controls.Add(this.btnUpdate);
            this.pnlBookingDetails.Controls.Add(this.btnComplteBooking);
            this.pnlBookingDetails.Controls.Add(this.btnRefresh);
            this.pnlBookingDetails.Controls.Add(this.lblRefresh);
            this.pnlBookingDetails.Controls.Add(this.dgvBookingViwe);
            this.pnlBookingDetails.Location = new System.Drawing.Point(245, 51);
            this.pnlBookingDetails.Name = "pnlBookingDetails";
            this.pnlBookingDetails.Size = new System.Drawing.Size(661, 322);
            this.pnlBookingDetails.TabIndex = 6;
            // 
            // btnCanselBooking
            // 
            this.btnCanselBooking.BackColor = System.Drawing.Color.Black;
            this.btnCanselBooking.FlatAppearance.BorderSize = 0;
            this.btnCanselBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanselBooking.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCanselBooking.Location = new System.Drawing.Point(257, 284);
            this.btnCanselBooking.Name = "btnCanselBooking";
            this.btnCanselBooking.Size = new System.Drawing.Size(117, 28);
            this.btnCanselBooking.TabIndex = 3;
            this.btnCanselBooking.Text = "Cansel Booking";
            this.btnCanselBooking.UseVisualStyleBackColor = false;
            this.btnCanselBooking.Click += new System.EventHandler(this.btnCanselBooking_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(134, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnComplteBooking
            // 
            this.btnComplteBooking.BackColor = System.Drawing.Color.Crimson;
            this.btnComplteBooking.FlatAppearance.BorderSize = 0;
            this.btnComplteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplteBooking.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnComplteBooking.Location = new System.Drawing.Point(12, 284);
            this.btnComplteBooking.Name = "btnComplteBooking";
            this.btnComplteBooking.Size = new System.Drawing.Size(117, 28);
            this.btnComplteBooking.TabIndex = 3;
            this.btnComplteBooking.Text = "Complte Booking";
            this.btnComplteBooking.UseVisualStyleBackColor = false;
            this.btnComplteBooking.Click += new System.EventHandler(this.btnComplteBooking_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::HotelManagementSys.Properties.Resources.Refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(614, 284);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 32);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblRefresh
            // 
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.ForeColor = System.Drawing.Color.Crimson;
            this.lblRefresh.Location = new System.Drawing.Point(571, 294);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(44, 13);
            this.lblRefresh.TabIndex = 1;
            this.lblRefresh.Text = "Refresh";
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // dgvBookingViwe
            // 
            this.dgvBookingViwe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBookingViwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingViwe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgBookingIdBooking,
            this.dgBookingPackageNameBooking,
            this.dgBookingDateBooking,
            this.dgRoomNumberBooking,
            this.dgCustomerName,
            this.dgUserNameBooking,
            this.dgStatusBooking});
            this.dgvBookingViwe.Location = new System.Drawing.Point(12, 12);
            this.dgvBookingViwe.Name = "dgvBookingViwe";
            this.dgvBookingViwe.RowHeadersVisible = false;
            this.dgvBookingViwe.Size = new System.Drawing.Size(638, 266);
            this.dgvBookingViwe.TabIndex = 0;
            // 
            // dgBookingIdBooking
            // 
            this.dgBookingIdBooking.HeaderText = "BookingID";
            this.dgBookingIdBooking.Name = "dgBookingIdBooking";
            this.dgBookingIdBooking.Width = 70;
            // 
            // dgBookingPackageNameBooking
            // 
            this.dgBookingPackageNameBooking.HeaderText = "Package";
            this.dgBookingPackageNameBooking.Name = "dgBookingPackageNameBooking";
            this.dgBookingPackageNameBooking.Width = 120;
            // 
            // dgBookingDateBooking
            // 
            this.dgBookingDateBooking.HeaderText = "Booking Date";
            this.dgBookingDateBooking.Name = "dgBookingDateBooking";
            this.dgBookingDateBooking.Width = 80;
            // 
            // dgRoomNumberBooking
            // 
            this.dgRoomNumberBooking.HeaderText = "Room Number";
            this.dgRoomNumberBooking.Name = "dgRoomNumberBooking";
            this.dgRoomNumberBooking.Width = 50;
            // 
            // dgCustomerName
            // 
            this.dgCustomerName.HeaderText = "Customer Name";
            this.dgCustomerName.Name = "dgCustomerName";
            this.dgCustomerName.Width = 120;
            // 
            // dgUserNameBooking
            // 
            this.dgUserNameBooking.HeaderText = "User Name";
            this.dgUserNameBooking.Name = "dgUserNameBooking";
            // 
            // dgStatusBooking
            // 
            this.dgStatusBooking.HeaderText = "Status";
            this.dgStatusBooking.Name = "dgStatusBooking";
            this.dgStatusBooking.Width = 90;
            // 
            // mcBookingDate
            // 
            this.mcBookingDate.Location = new System.Drawing.Point(11, 51);
            this.mcBookingDate.Name = "mcBookingDate";
            this.mcBookingDate.TabIndex = 7;
            this.mcBookingDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcBookingDate_DateChanged);
            // 
            // btnBookingReport
            // 
            this.btnBookingReport.BackColor = System.Drawing.Color.Transparent;
            this.btnBookingReport.BackgroundImage = global::HotelManagementSys.Properties.Resources.Reports;
            this.btnBookingReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBookingReport.FlatAppearance.BorderSize = 0;
            this.btnBookingReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingReport.Location = new System.Drawing.Point(60, 510);
            this.btnBookingReport.Name = "btnBookingReport";
            this.btnBookingReport.Size = new System.Drawing.Size(75, 89);
            this.btnBookingReport.TabIndex = 8;
            this.btnBookingReport.Text = "Report";
            this.btnBookingReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBookingReport.UseVisualStyleBackColor = false;
            this.btnBookingReport.Click += new System.EventHandler(this.btnBookingReport_Click);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 675);
            this.Controls.Add(this.btnBookingReport);
            this.Controls.Add(this.mcBookingDate);
            this.Controls.Add(this.pnlBookingDetails);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grpAddBookings);
            this.Controls.Add(this.pnlInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(435, 81);
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmBooking";
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            this.grpAddBookings.ResumeLayout(false);
            this.grpAddBookings.PerformLayout();
            this.pnlBookingDetails.ResumeLayout(false);
            this.pnlBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingViwe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.GroupBox grpAddBookings;
        private System.Windows.Forms.DateTimePicker dtmBookingDate;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblBookingPackageName;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Panel pnlBookingDetails;
        private System.Windows.Forms.DataGridView dgvBookingViwe;
        private System.Windows.Forms.MonthCalendar mcBookingDate;
        private System.Windows.Forms.ComboBox cmdBookingPackageName;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Button btnCanselBooking;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnComplteBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookingIdBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookingPackageNameBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBookingDateBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRoomNumberBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUserNameBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStatusBooking;
        private System.Windows.Forms.Button btnBookingReport;
    }
}