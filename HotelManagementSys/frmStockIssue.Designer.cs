namespace HotelManagementSys
{
    partial class frmStockIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockIssue));
            this.lstItemList = new System.Windows.Forms.ListBox();
            this.pnlIssueItem = new System.Windows.Forms.Panel();
            this.dtpStockIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnCansel = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtQuentity = new System.Windows.Forms.TextBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblQuentity = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtStockIssueId = new System.Windows.Forms.TextBox();
            this.lblStockIssueId = new System.Windows.Forms.Label();
            this.btnNewIssue = new System.Windows.Forms.Button();
            this.lblStockOutDetails = new System.Windows.Forms.Label();
            this.grbStockOutDetails = new System.Windows.Forms.GroupBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.lblMonth = new System.Windows.Forms.Label();
            this.dgvStockIssueDetails = new System.Windows.Forms.DataGridView();
            this.dtStockIssueIdSrockIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtItemNameStockIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtQuentityStockItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtIssueDepartmentStockIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtIssueMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlIssueItem.SuspendLayout();
            this.grbStockOutDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIssueDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lstItemList
            // 
            this.lstItemList.FormattingEnabled = true;
            this.lstItemList.Location = new System.Drawing.Point(9, 10);
            this.lstItemList.Name = "lstItemList";
            this.lstItemList.Size = new System.Drawing.Size(162, 212);
            this.lstItemList.TabIndex = 0;
            this.lstItemList.SelectedIndexChanged += new System.EventHandler(this.lstItemList_SelectedIndexChanged);
            // 
            // pnlIssueItem
            // 
            this.pnlIssueItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.pnlIssueItem.Controls.Add(this.dtpStockIssueDate);
            this.pnlIssueItem.Controls.Add(this.btnIssue);
            this.pnlIssueItem.Controls.Add(this.btnCansel);
            this.pnlIssueItem.Controls.Add(this.cmbDepartment);
            this.pnlIssueItem.Controls.Add(this.txtQuentity);
            this.pnlIssueItem.Controls.Add(this.lblIssueDate);
            this.pnlIssueItem.Controls.Add(this.lblDepartment);
            this.pnlIssueItem.Controls.Add(this.lblQuentity);
            this.pnlIssueItem.Controls.Add(this.txtItemName);
            this.pnlIssueItem.Controls.Add(this.lblItemName);
            this.pnlIssueItem.Controls.Add(this.txtStockIssueId);
            this.pnlIssueItem.Controls.Add(this.lblStockIssueId);
            this.pnlIssueItem.Controls.Add(this.lstItemList);
            this.pnlIssueItem.Enabled = false;
            this.pnlIssueItem.Location = new System.Drawing.Point(118, 12);
            this.pnlIssueItem.Name = "pnlIssueItem";
            this.pnlIssueItem.Size = new System.Drawing.Size(773, 231);
            this.pnlIssueItem.TabIndex = 1;
            // 
            // dtpStockIssueDate
            // 
            this.dtpStockIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStockIssueDate.Location = new System.Drawing.Point(279, 139);
            this.dtpStockIssueDate.Name = "dtpStockIssueDate";
            this.dtpStockIssueDate.Size = new System.Drawing.Size(185, 20);
            this.dtpStockIssueDate.TabIndex = 8;
            // 
            // btnCansel
            // 
            this.btnCansel.BackColor = System.Drawing.Color.Black;
            this.btnCansel.FlatAppearance.BorderSize = 0;
            this.btnCansel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCansel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnCansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCansel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCansel.Location = new System.Drawing.Point(646, 192);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(116, 30);
            this.btnCansel.TabIndex = 6;
            this.btnCansel.Text = "Cansel";
            this.btnCansel.UseVisualStyleBackColor = false;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Bar",
            "Kitchen",
            "Pool",
            "Rooms"});
            this.cmbDepartment.Location = new System.Drawing.Point(278, 112);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(186, 21);
            this.cmbDepartment.TabIndex = 4;
            // 
            // txtQuentity
            // 
            this.txtQuentity.Location = new System.Drawing.Point(278, 86);
            this.txtQuentity.Name = "txtQuentity";
            this.txtQuentity.Size = new System.Drawing.Size(186, 20);
            this.txtQuentity.TabIndex = 3;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(192, 142);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(81, 13);
            this.lblIssueDate.TabIndex = 2;
            this.lblIssueDate.Text = "Stock Out Date";
            this.lblIssueDate.Click += new System.EventHandler(this.lblQuentity_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(211, 115);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            this.lblDepartment.Click += new System.EventHandler(this.lblQuentity_Click);
            // 
            // lblQuentity
            // 
            this.lblQuentity.AutoSize = true;
            this.lblQuentity.Location = new System.Drawing.Point(227, 89);
            this.lblQuentity.Name = "lblQuentity";
            this.lblQuentity.Size = new System.Drawing.Size(46, 13);
            this.lblQuentity.TabIndex = 2;
            this.lblQuentity.Text = "Quentity";
            this.lblQuentity.Click += new System.EventHandler(this.lblQuentity_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(278, 60);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(350, 20);
            this.txtItemName.TabIndex = 3;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(215, 63);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name";
            // 
            // txtStockIssueId
            // 
            this.txtStockIssueId.Location = new System.Drawing.Point(278, 34);
            this.txtStockIssueId.Name = "txtStockIssueId";
            this.txtStockIssueId.ReadOnly = true;
            this.txtStockIssueId.Size = new System.Drawing.Size(186, 20);
            this.txtStockIssueId.TabIndex = 3;
            // 
            // lblStockIssueId
            // 
            this.lblStockIssueId.AutoSize = true;
            this.lblStockIssueId.Location = new System.Drawing.Point(206, 37);
            this.lblStockIssueId.Name = "lblStockIssueId";
            this.lblStockIssueId.Size = new System.Drawing.Size(67, 13);
            this.lblStockIssueId.TabIndex = 2;
            this.lblStockIssueId.Text = "Stock Out Id";
            // 
            // btnNewIssue
            // 
            this.btnNewIssue.BackColor = System.Drawing.Color.Crimson;
            this.btnNewIssue.FlatAppearance.BorderSize = 0;
            this.btnNewIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnNewIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNewIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewIssue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewIssue.Location = new System.Drawing.Point(12, 12);
            this.btnNewIssue.Name = "btnNewIssue";
            this.btnNewIssue.Size = new System.Drawing.Size(100, 54);
            this.btnNewIssue.TabIndex = 2;
            this.btnNewIssue.Text = "New Item Out";
            this.btnNewIssue.UseVisualStyleBackColor = false;
            this.btnNewIssue.Click += new System.EventHandler(this.btnNewIssue_Click);
            // 
            // lblStockOutDetails
            // 
            this.lblStockOutDetails.AutoSize = true;
            this.lblStockOutDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockOutDetails.ForeColor = System.Drawing.Color.Crimson;
            this.lblStockOutDetails.Location = new System.Drawing.Point(405, -3);
            this.lblStockOutDetails.Name = "lblStockOutDetails";
            this.lblStockOutDetails.Size = new System.Drawing.Size(117, 17);
            this.lblStockOutDetails.TabIndex = 3;
            this.lblStockOutDetails.Text = "Stock Out Details";
            // 
            // grbStockOutDetails
            // 
            this.grbStockOutDetails.Controls.Add(this.btnPrint);
            this.grbStockOutDetails.Controls.Add(this.dgvStockIssueDetails);
            this.grbStockOutDetails.Controls.Add(this.lblStockOutDetails);
            this.grbStockOutDetails.Controls.Add(this.lblMonth);
            this.grbStockOutDetails.Controls.Add(this.dtpMonth);
            this.grbStockOutDetails.Controls.Add(this.btnSearch);
            this.grbStockOutDetails.Controls.Add(this.btnAll);
            this.grbStockOutDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbStockOutDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbStockOutDetails.Location = new System.Drawing.Point(12, 263);
            this.grbStockOutDetails.Name = "grbStockOutDetails";
            this.grbStockOutDetails.Size = new System.Drawing.Size(879, 361);
            this.grbStockOutDetails.TabIndex = 4;
            this.grbStockOutDetails.TabStop = false;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Crimson;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAll.Location = new System.Drawing.Point(16, 19);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(84, 26);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dtpMonth
            // 
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(161, 22);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(148, 20);
            this.dtpMonth.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(120, 26);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month";
            // 
            // dgvStockIssueDetails
            // 
            this.dgvStockIssueDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStockIssueDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockIssueDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtStockIssueIdSrockIssue,
            this.dtItemNameStockIssue,
            this.dtQuentityStockItem,
            this.dtIssueDepartmentStockIssue,
            this.dtIssueMonth});
            this.dgvStockIssueDetails.Location = new System.Drawing.Point(16, 51);
            this.dgvStockIssueDetails.Name = "dgvStockIssueDetails";
            this.dgvStockIssueDetails.ReadOnly = true;
            this.dgvStockIssueDetails.Size = new System.Drawing.Size(744, 294);
            this.dgvStockIssueDetails.TabIndex = 4;
            // 
            // dtStockIssueIdSrockIssue
            // 
            this.dtStockIssueIdSrockIssue.HeaderText = "Stock Out Id";
            this.dtStockIssueIdSrockIssue.Name = "dtStockIssueIdSrockIssue";
            this.dtStockIssueIdSrockIssue.ReadOnly = true;
            this.dtStockIssueIdSrockIssue.Width = 200;
            // 
            // dtItemNameStockIssue
            // 
            this.dtItemNameStockIssue.HeaderText = "Item Name";
            this.dtItemNameStockIssue.Name = "dtItemNameStockIssue";
            this.dtItemNameStockIssue.ReadOnly = true;
            this.dtItemNameStockIssue.Width = 200;
            // 
            // dtQuentityStockItem
            // 
            this.dtQuentityStockItem.HeaderText = "Quentity";
            this.dtQuentityStockItem.Name = "dtQuentityStockItem";
            this.dtQuentityStockItem.ReadOnly = true;
            // 
            // dtIssueDepartmentStockIssue
            // 
            this.dtIssueDepartmentStockIssue.HeaderText = "Out Department";
            this.dtIssueDepartmentStockIssue.Name = "dtIssueDepartmentStockIssue";
            this.dtIssueDepartmentStockIssue.ReadOnly = true;
            // 
            // dtIssueMonth
            // 
            this.dtIssueMonth.HeaderText = "Stock Out Month";
            this.dtIssueMonth.Name = "dtIssueMonth";
            this.dtIssueMonth.ReadOnly = true;
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.Transparent;
            this.btnIssue.BackgroundImage = global::HotelManagementSys.Properties.Resources.IssueNormal;
            this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIssue.FlatAppearance.BorderSize = 0;
            this.btnIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Location = new System.Drawing.Point(661, 56);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(87, 107);
            this.btnIssue.TabIndex = 7;
            this.btnIssue.Text = "Stock Out";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            this.btnIssue.MouseLeave += new System.EventHandler(this.btnIssue_MouseLeave);
            this.btnIssue.MouseHover += new System.EventHandler(this.btnIssue_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::HotelManagementSys.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(315, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::HotelManagementSys.Properties.Resources.Print;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(779, 265);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 80);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmStockIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 636);
            this.Controls.Add(this.btnNewIssue);
            this.Controls.Add(this.pnlIssueItem);
            this.Controls.Add(this.grbStockOutDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(435, 81);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stock Out";
            this.Load += new System.EventHandler(this.frmStockIssue_Load);
            this.pnlIssueItem.ResumeLayout(false);
            this.pnlIssueItem.PerformLayout();
            this.grbStockOutDetails.ResumeLayout(false);
            this.grbStockOutDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIssueDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstItemList;
        private System.Windows.Forms.Panel pnlIssueItem;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtStockIssueId;
        private System.Windows.Forms.Label lblStockIssueId;
        private System.Windows.Forms.Button btnNewIssue;
        private System.Windows.Forms.TextBox txtQuentity;
        private System.Windows.Forms.Label lblQuentity;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.DateTimePicker dtpStockIssueDate;
        private System.Windows.Forms.Label lblStockOutDetails;
        private System.Windows.Forms.GroupBox grbStockOutDetails;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStockIssueDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtStockIssueIdSrockIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtItemNameStockIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtQuentityStockItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtIssueDepartmentStockIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtIssueMonth;
        private System.Windows.Forms.Button btnPrint;
    }
}