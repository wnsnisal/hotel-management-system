namespace HotelManagementSys
{
    partial class frmStockDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockDetails));
            this.grbAddToStock = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuentity = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblQuentity = new System.Windows.Forms.Label();
            this.txtItemRate = new System.Windows.Forms.TextBox();
            this.lblRs = new System.Windows.Forms.Label();
            this.lblItemRate = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtStockItemId = new System.Windows.Forms.TextBox();
            this.lblStockItemId = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgvStockDetails = new System.Windows.Forms.DataGridView();
            this.dgStockItemIdStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgItemNameStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgItemCategoryStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgItemRateStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgQuentityStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgIStatusStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btItemSearch = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAllItems = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnStockReport = new System.Windows.Forms.Button();
            this.btnStockIssueDetails = new System.Windows.Forms.Button();
            this.btnInactive = new System.Windows.Forms.Button();
            this.grbAddToStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAddToStock
            // 
            this.grbAddToStock.Controls.Add(this.cmbCategory);
            this.grbAddToStock.Controls.Add(this.btnCansel);
            this.grbAddToStock.Controls.Add(this.btnAdd);
            this.grbAddToStock.Controls.Add(this.txtQuentity);
            this.grbAddToStock.Controls.Add(this.lblCategory);
            this.grbAddToStock.Controls.Add(this.lblQuentity);
            this.grbAddToStock.Controls.Add(this.txtItemRate);
            this.grbAddToStock.Controls.Add(this.lblRs);
            this.grbAddToStock.Controls.Add(this.lblItemRate);
            this.grbAddToStock.Controls.Add(this.txtItemName);
            this.grbAddToStock.Controls.Add(this.lblItemName);
            this.grbAddToStock.Controls.Add(this.txtStockItemId);
            this.grbAddToStock.Controls.Add(this.lblStockItemId);
            this.grbAddToStock.Enabled = false;
            this.grbAddToStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbAddToStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddToStock.ForeColor = System.Drawing.Color.Crimson;
            this.grbAddToStock.Location = new System.Drawing.Point(177, 351);
            this.grbAddToStock.Name = "grbAddToStock";
            this.grbAddToStock.Size = new System.Drawing.Size(627, 276);
            this.grbAddToStock.TabIndex = 0;
            this.grbAddToStock.TabStop = false;
            this.grbAddToStock.Text = "Add to Stock";
            this.grbAddToStock.Enter += new System.EventHandler(this.grbAddToStock_Enter);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Foods",
            "Soft Drinks",
            "Liquor",
            "Others"});
            this.cmbCategory.Location = new System.Drawing.Point(127, 138);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(230, 24);
            this.cmbCategory.TabIndex = 12;
            this.cmbCategory.Text = "Select";
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
            this.btnCansel.Location = new System.Drawing.Point(484, 238);
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
            this.btnAdd.Location = new System.Drawing.Point(288, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 102);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuentity
            // 
            this.txtQuentity.Location = new System.Drawing.Point(127, 109);
            this.txtQuentity.Name = "txtQuentity";
            this.txtQuentity.Size = new System.Drawing.Size(230, 23);
            this.txtQuentity.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblCategory.Location = new System.Drawing.Point(55, 141);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // lblQuentity
            // 
            this.lblQuentity.AutoSize = true;
            this.lblQuentity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblQuentity.Location = new System.Drawing.Point(59, 112);
            this.lblQuentity.Name = "lblQuentity";
            this.lblQuentity.Size = new System.Drawing.Size(61, 17);
            this.lblQuentity.TabIndex = 0;
            this.lblQuentity.Text = "Quentity";
            // 
            // txtItemRate
            // 
            this.txtItemRate.Location = new System.Drawing.Point(168, 80);
            this.txtItemRate.Name = "txtItemRate";
            this.txtItemRate.Size = new System.Drawing.Size(189, 23);
            this.txtItemRate.TabIndex = 1;
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblRs.Location = new System.Drawing.Point(133, 83);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(29, 17);
            this.lblRs.TabIndex = 0;
            this.lblRs.Text = "Rs.";
            // 
            // lblItemRate
            // 
            this.lblItemRate.AutoSize = true;
            this.lblItemRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblItemRate.Location = new System.Drawing.Point(52, 83);
            this.lblItemRate.Name = "lblItemRate";
            this.lblItemRate.Size = new System.Drawing.Size(68, 17);
            this.lblItemRate.TabIndex = 0;
            this.lblItemRate.Text = "Item Rate";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(127, 51);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(419, 23);
            this.txtItemName.TabIndex = 1;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblItemName.Location = new System.Drawing.Point(45, 54);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(75, 17);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name";
            // 
            // txtStockItemId
            // 
            this.txtStockItemId.Location = new System.Drawing.Point(127, 22);
            this.txtStockItemId.Name = "txtStockItemId";
            this.txtStockItemId.ReadOnly = true;
            this.txtStockItemId.Size = new System.Drawing.Size(193, 23);
            this.txtStockItemId.TabIndex = 1;
            // 
            // lblStockItemId
            // 
            this.lblStockItemId.AutoSize = true;
            this.lblStockItemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblStockItemId.Location = new System.Drawing.Point(32, 25);
            this.lblStockItemId.Name = "lblStockItemId";
            this.lblStockItemId.Size = new System.Drawing.Size(88, 17);
            this.lblStockItemId.TabIndex = 0;
            this.lblStockItemId.Text = "Stock Item Id";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Crimson;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(25, 369);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(135, 40);
            this.btnAddNew.TabIndex = 7;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvStockDetails
            // 
            this.dgvStockDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgStockItemIdStock,
            this.dgItemNameStock,
            this.dgItemCategoryStock,
            this.dgItemRateStock,
            this.dgQuentityStock,
            this.dgIStatusStock});
            this.dgvStockDetails.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvStockDetails.Location = new System.Drawing.Point(212, 43);
            this.dgvStockDetails.Name = "dgvStockDetails";
            this.dgvStockDetails.ReadOnly = true;
            this.dgvStockDetails.RowHeadersVisible = false;
            this.dgvStockDetails.Size = new System.Drawing.Size(679, 266);
            this.dgvStockDetails.TabIndex = 8;
            this.dgvStockDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockDetails_CellContentClick);
            this.dgvStockDetails.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockDetails_CellContentDoubleClick);
            this.dgvStockDetails.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStockDetails_CellMouseDoubleClick);
            // 
            // dgStockItemIdStock
            // 
            this.dgStockItemIdStock.HeaderText = "Stock Item Id";
            this.dgStockItemIdStock.Name = "dgStockItemIdStock";
            this.dgStockItemIdStock.ReadOnly = true;
            this.dgStockItemIdStock.Width = 55;
            // 
            // dgItemNameStock
            // 
            this.dgItemNameStock.HeaderText = "Item Name";
            this.dgItemNameStock.Name = "dgItemNameStock";
            this.dgItemNameStock.ReadOnly = true;
            this.dgItemNameStock.Width = 270;
            // 
            // dgItemCategoryStock
            // 
            this.dgItemCategoryStock.HeaderText = "Item Category";
            this.dgItemCategoryStock.Name = "dgItemCategoryStock";
            this.dgItemCategoryStock.ReadOnly = true;
            this.dgItemCategoryStock.Width = 130;
            // 
            // dgItemRateStock
            // 
            this.dgItemRateStock.HeaderText = "Item Rate";
            this.dgItemRateStock.Name = "dgItemRateStock";
            this.dgItemRateStock.ReadOnly = true;
            // 
            // dgQuentityStock
            // 
            this.dgQuentityStock.HeaderText = "Quentity";
            this.dgQuentityStock.Name = "dgQuentityStock";
            this.dgQuentityStock.ReadOnly = true;
            this.dgQuentityStock.Width = 50;
            // 
            // dgIStatusStock
            // 
            this.dgIStatusStock.HeaderText = "Status";
            this.dgIStatusStock.Name = "dgIStatusStock";
            this.dgIStatusStock.ReadOnly = true;
            this.dgIStatusStock.Width = 70;
            // 
            // btItemSearch
            // 
            this.btItemSearch.Location = new System.Drawing.Point(12, 17);
            this.btItemSearch.Name = "btItemSearch";
            this.btItemSearch.Size = new System.Drawing.Size(194, 20);
            this.btItemSearch.TabIndex = 9;
            this.btItemSearch.TextChanged += new System.EventHandler(this.btItemSearch_TextChanged);
            this.btItemSearch.MouseEnter += new System.EventHandler(this.btItemSearch_MouseEnter);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(12, 43);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(194, 264);
            this.lstItems.TabIndex = 10;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // btnAllItems
            // 
            this.btnAllItems.BackColor = System.Drawing.Color.Crimson;
            this.btnAllItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAllItems.FlatAppearance.BorderSize = 0;
            this.btnAllItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnAllItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAllItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllItems.ForeColor = System.Drawing.Color.White;
            this.btnAllItems.Location = new System.Drawing.Point(786, 14);
            this.btnAllItems.Name = "btnAllItems";
            this.btnAllItems.Size = new System.Drawing.Size(97, 25);
            this.btnAllItems.TabIndex = 11;
            this.btnAllItems.Text = "All Items";
            this.btnAllItems.UseVisualStyleBackColor = false;
            this.btnAllItems.Click += new System.EventHandler(this.btnAllItems_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(574, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.Black;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.Location = new System.Drawing.Point(681, 315);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(101, 30);
            this.btnActive.TabIndex = 13;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Location = new System.Drawing.Point(209, 20);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(64, 13);
            this.lblSearchItem.TabIndex = 14;
            this.lblSearchItem.Text = "Search Item";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(461, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 30);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnStockReport
            // 
            this.btnStockReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStockReport.FlatAppearance.BorderSize = 0;
            this.btnStockReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStockReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnStockReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockReport.ForeColor = System.Drawing.Color.Yellow;
            this.btnStockReport.Location = new System.Drawing.Point(345, 315);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(110, 30);
            this.btnStockReport.TabIndex = 16;
            this.btnStockReport.Text = "Stock Report";
            this.btnStockReport.UseVisualStyleBackColor = false;
            // 
            // btnStockIssueDetails
            // 
            this.btnStockIssueDetails.BackgroundImage = global::HotelManagementSys.Properties.Resources.StockIssure;
            this.btnStockIssueDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStockIssueDetails.FlatAppearance.BorderSize = 0;
            this.btnStockIssueDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStockIssueDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStockIssueDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockIssueDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIssueDetails.Location = new System.Drawing.Point(25, 484);
            this.btnStockIssueDetails.Name = "btnStockIssueDetails";
            this.btnStockIssueDetails.Size = new System.Drawing.Size(135, 140);
            this.btnStockIssueDetails.TabIndex = 17;
            this.btnStockIssueDetails.Text = "Stock Issue";
            this.btnStockIssueDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStockIssueDetails.UseVisualStyleBackColor = true;
            this.btnStockIssueDetails.Click += new System.EventHandler(this.btnStockIssueDetails_Click);
            this.btnStockIssueDetails.MouseLeave += new System.EventHandler(this.btnStockIssueDetails_MouseLeave);
            this.btnStockIssueDetails.MouseHover += new System.EventHandler(this.btnStockIssueDetails_MouseHover);
            // 
            // btnInactive
            // 
            this.btnInactive.BackColor = System.Drawing.Color.Black;
            this.btnInactive.FlatAppearance.BorderSize = 0;
            this.btnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactive.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInactive.Location = new System.Drawing.Point(788, 315);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(95, 30);
            this.btnInactive.TabIndex = 18;
            this.btnInactive.Text = "Inactive";
            this.btnInactive.UseVisualStyleBackColor = false;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // frmStockDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 636);
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.btnStockIssueDetails);
            this.Controls.Add(this.btnStockReport);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblSearchItem);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAllItems);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btItemSearch);
            this.Controls.Add(this.dgvStockDetails);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grbAddToStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(435, 81);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stock Details";
            this.Load += new System.EventHandler(this.frmStockDetails_Load);
            this.grbAddToStock.ResumeLayout(false);
            this.grbAddToStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddToStock;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblStockItemId;
        private System.Windows.Forms.TextBox txtQuentity;
        private System.Windows.Forms.Label lblQuentity;
        private System.Windows.Forms.TextBox txtItemRate;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Label lblItemRate;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtStockItemId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.DataGridView dgvStockDetails;
        private System.Windows.Forms.TextBox btItemSearch;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAllItems;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStockReport;
        private System.Windows.Forms.Button btnStockIssueDetails;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStockItemIdStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgItemNameStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgItemCategoryStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgItemRateStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgQuentityStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIStatusStock;
        private System.Windows.Forms.Button btnInactive;
    }
}