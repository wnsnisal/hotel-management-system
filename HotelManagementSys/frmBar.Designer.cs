namespace HotelManagementSys
{
    partial class frmBar
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBar = new System.Windows.Forms.Label();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.btnReportOfBarItems = new System.Windows.Forms.Button();
            this.lblViweItem = new System.Windows.Forms.Label();
            this.pnlViweItem = new System.Windows.Forms.Panel();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.btnDisableItem = new System.Windows.Forms.Button();
            this.dgvItemViwe = new System.Windows.Forms.DataGridView();
            this.dgvBarItemIdViwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemNameViwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPriceViwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatusViwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEnembleItem = new System.Windows.Forms.Button();
            this.lstViweItem = new System.Windows.Forms.ListBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblAddItem = new System.Windows.Forms.Label();
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.txtPriceAdd = new System.Windows.Forms.TextBox();
            this.lblRs = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.txtItemNameAdd = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemIdAdd = new System.Windows.Forms.TextBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlInvoice.SuspendLayout();
            this.pnlViweItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemViwe)).BeginInit();
            this.pnlAddItem.SuspendLayout();
            this.SuspendLayout();
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
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBar.Location = new System.Drawing.Point(442, 10);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(34, 20);
            this.lblBar.TabIndex = 0;
            this.lblBar.Text = "Bar";
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlInvoice.Controls.Add(this.btnClose);
            this.pnlInvoice.Controls.Add(this.lblBar);
            this.pnlInvoice.Location = new System.Drawing.Point(-2, -1);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(921, 39);
            this.pnlInvoice.TabIndex = 3;
            // 
            // btnReportOfBarItems
            // 
            this.btnReportOfBarItems.BackgroundImage = global::HotelManagementSys.Properties.Resources.Reports;
            this.btnReportOfBarItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReportOfBarItems.FlatAppearance.BorderSize = 0;
            this.btnReportOfBarItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportOfBarItems.Location = new System.Drawing.Point(66, 530);
            this.btnReportOfBarItems.Name = "btnReportOfBarItems";
            this.btnReportOfBarItems.Size = new System.Drawing.Size(89, 133);
            this.btnReportOfBarItems.TabIndex = 16;
            this.btnReportOfBarItems.Text = "Report Of Bar Items";
            this.btnReportOfBarItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportOfBarItems.UseVisualStyleBackColor = true;
            // 
            // lblViweItem
            // 
            this.lblViweItem.AutoSize = true;
            this.lblViweItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.lblViweItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViweItem.ForeColor = System.Drawing.Color.Crimson;
            this.lblViweItem.Location = new System.Drawing.Point(419, 50);
            this.lblViweItem.Name = "lblViweItem";
            this.lblViweItem.Size = new System.Drawing.Size(79, 20);
            this.lblViweItem.TabIndex = 14;
            this.lblViweItem.Text = "View Item";
            // 
            // pnlViweItem
            // 
            this.pnlViweItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlViweItem.Controls.Add(this.txtItemSearch);
            this.pnlViweItem.Controls.Add(this.lblSearchItem);
            this.pnlViweItem.Controls.Add(this.btnDisableItem);
            this.pnlViweItem.Controls.Add(this.dgvItemViwe);
            this.pnlViweItem.Controls.Add(this.btnAll);
            this.pnlViweItem.Controls.Add(this.btnUpdate);
            this.pnlViweItem.Controls.Add(this.btnEnembleItem);
            this.pnlViweItem.Controls.Add(this.lstViweItem);
            this.pnlViweItem.Location = new System.Drawing.Point(36, 73);
            this.pnlViweItem.Name = "pnlViweItem";
            this.pnlViweItem.Size = new System.Drawing.Size(847, 370);
            this.pnlViweItem.TabIndex = 15;
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Location = new System.Drawing.Point(17, 15);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(170, 20);
            this.txtItemSearch.TabIndex = 28;
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Location = new System.Drawing.Point(193, 18);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(64, 13);
            this.lblSearchItem.TabIndex = 27;
            this.lblSearchItem.Text = "Search Item";
            // 
            // btnDisableItem
            // 
            this.btnDisableItem.BackColor = System.Drawing.Color.Black;
            this.btnDisableItem.FlatAppearance.BorderSize = 0;
            this.btnDisableItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDisableItem.Location = new System.Drawing.Point(475, 327);
            this.btnDisableItem.Name = "btnDisableItem";
            this.btnDisableItem.Size = new System.Drawing.Size(117, 28);
            this.btnDisableItem.TabIndex = 17;
            this.btnDisableItem.Text = "Disable Item";
            this.btnDisableItem.UseVisualStyleBackColor = false;
            this.btnDisableItem.Click += new System.EventHandler(this.btnDisableItem_Click);
            // 
            // dgvItemViwe
            // 
            this.dgvItemViwe.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemViwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemViwe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBarItemIdViwe,
            this.dgvItemNameViwe,
            this.dgvPriceViwe,
            this.dgvStatusViwe});
            this.dgvItemViwe.Location = new System.Drawing.Point(230, 39);
            this.dgvItemViwe.Name = "dgvItemViwe";
            this.dgvItemViwe.RowHeadersVisible = false;
            this.dgvItemViwe.Size = new System.Drawing.Size(605, 282);
            this.dgvItemViwe.TabIndex = 26;
            // 
            // dgvBarItemIdViwe
            // 
            this.dgvBarItemIdViwe.HeaderText = "Item ID";
            this.dgvBarItemIdViwe.Name = "dgvBarItemIdViwe";
            // 
            // dgvItemNameViwe
            // 
            this.dgvItemNameViwe.HeaderText = "Item Name";
            this.dgvItemNameViwe.Name = "dgvItemNameViwe";
            this.dgvItemNameViwe.Width = 300;
            // 
            // dgvPriceViwe
            // 
            this.dgvPriceViwe.HeaderText = "Price";
            this.dgvPriceViwe.Name = "dgvPriceViwe";
            // 
            // dgvStatusViwe
            // 
            this.dgvStatusViwe.HeaderText = "Status";
            this.dgvStatusViwe.Name = "dgvStatusViwe";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Crimson;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAll.Location = new System.Drawing.Point(750, 8);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(85, 24);
            this.btnAll.TabIndex = 18;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(230, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 28);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEnembleItem
            // 
            this.btnEnembleItem.BackColor = System.Drawing.Color.Crimson;
            this.btnEnembleItem.FlatAppearance.BorderSize = 0;
            this.btnEnembleItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnembleItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnembleItem.Location = new System.Drawing.Point(352, 327);
            this.btnEnembleItem.Name = "btnEnembleItem";
            this.btnEnembleItem.Size = new System.Drawing.Size(117, 28);
            this.btnEnembleItem.TabIndex = 19;
            this.btnEnembleItem.Text = "Enemble Item";
            this.btnEnembleItem.UseVisualStyleBackColor = false;
            this.btnEnembleItem.Click += new System.EventHandler(this.btnEnembleItem_Click);
            // 
            // lstViweItem
            // 
            this.lstViweItem.FormattingEnabled = true;
            this.lstViweItem.Location = new System.Drawing.Point(17, 44);
            this.lstViweItem.Name = "lstViweItem";
            this.lstViweItem.Size = new System.Drawing.Size(170, 277);
            this.lstViweItem.TabIndex = 0;
            this.lstViweItem.SelectedIndexChanged += new System.EventHandler(this.lstViweItem_SelectedIndexChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Crimson;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(66, 480);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(135, 40);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItem.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddItem.Location = new System.Drawing.Point(507, 457);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(74, 20);
            this.lblAddItem.TabIndex = 11;
            this.lblAddItem.Text = "Add Item";
            // 
            // pnlAddItem
            // 
            this.pnlAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAddItem.Controls.Add(this.txtPriceAdd);
            this.pnlAddItem.Controls.Add(this.lblRs);
            this.pnlAddItem.Controls.Add(this.lblItemPrice);
            this.pnlAddItem.Controls.Add(this.txtItemNameAdd);
            this.pnlAddItem.Controls.Add(this.lblItemName);
            this.pnlAddItem.Controls.Add(this.txtItemIdAdd);
            this.pnlAddItem.Controls.Add(this.lblItemId);
            this.pnlAddItem.Controls.Add(this.btnCansel);
            this.pnlAddItem.Controls.Add(this.btnAdd);
            this.pnlAddItem.Enabled = false;
            this.pnlAddItem.Location = new System.Drawing.Point(207, 480);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(676, 171);
            this.pnlAddItem.TabIndex = 12;
            // 
            // txtPriceAdd
            // 
            this.txtPriceAdd.Location = new System.Drawing.Point(140, 99);
            this.txtPriceAdd.Name = "txtPriceAdd";
            this.txtPriceAdd.Size = new System.Drawing.Size(170, 20);
            this.txtPriceAdd.TabIndex = 13;
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Location = new System.Drawing.Point(111, 102);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(23, 13);
            this.lblRs.TabIndex = 12;
            this.lblRs.Text = "Rs:";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Location = new System.Drawing.Point(69, 102);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(31, 13);
            this.lblItemPrice.TabIndex = 12;
            this.lblItemPrice.Text = "Price";
            // 
            // txtItemNameAdd
            // 
            this.txtItemNameAdd.Location = new System.Drawing.Point(109, 73);
            this.txtItemNameAdd.Name = "txtItemNameAdd";
            this.txtItemNameAdd.Size = new System.Drawing.Size(369, 20);
            this.txtItemNameAdd.TabIndex = 13;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(42, 76);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 12;
            this.lblItemName.Text = "Item Name";
            // 
            // txtItemIdAdd
            // 
            this.txtItemIdAdd.Location = new System.Drawing.Point(109, 47);
            this.txtItemIdAdd.Name = "txtItemIdAdd";
            this.txtItemIdAdd.Size = new System.Drawing.Size(201, 20);
            this.txtItemIdAdd.TabIndex = 13;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(59, 50);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(41, 13);
            this.lblItemId.TabIndex = 12;
            this.lblItemId.Text = "Item ID";
            // 
            // btnCansel
            // 
            this.btnCansel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnCansel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCansel.FlatAppearance.BorderSize = 0;
            this.btnCansel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnCansel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnCansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCansel.ForeColor = System.Drawing.Color.White;
            this.btnCansel.Location = new System.Drawing.Point(510, 124);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(126, 32);
            this.btnCansel.TabIndex = 11;
            this.btnCansel.Text = "Cansel\r\n";
            this.btnCansel.UseVisualStyleBackColor = false;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::HotelManagementSys.Properties.Resources.AddNormal;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(528, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 106);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 675);
            this.Controls.Add(this.btnReportOfBarItems);
            this.Controls.Add(this.lblViweItem);
            this.Controls.Add(this.pnlViweItem);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblAddItem);
            this.Controls.Add(this.pnlAddItem);
            this.Controls.Add(this.pnlInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(435, 81);
            this.Name = "frmBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bar";
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            this.pnlViweItem.ResumeLayout(false);
            this.pnlViweItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemViwe)).EndInit();
            this.pnlAddItem.ResumeLayout(false);
            this.pnlAddItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Button btnReportOfBarItems;
        private System.Windows.Forms.Label lblViweItem;
        private System.Windows.Forms.Panel pnlViweItem;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.Panel pnlAddItem;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstViweItem;
        private System.Windows.Forms.DataGridView dgvItemViwe;
        private System.Windows.Forms.Button btnDisableItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBarItemIdViwe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemNameViwe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPriceViwe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatusViwe;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEnembleItem;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtPriceAdd;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.TextBox txtItemNameAdd;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemIdAdd;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.TextBox txtItemSearch;
    }
}