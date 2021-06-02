namespace HotelManagementSys
{
    partial class frmMealItemReport
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
            this.dgvMeals = new System.Windows.Forms.DataGridView();
            this.DgMealItemIdReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgItemNameReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCategoryReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRateReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCategoryReport = new System.Windows.Forms.ComboBox();
            this.lblMealCategory = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeals
            // 
            this.dgvMeals.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgMealItemIdReport,
            this.dgItemNameReport,
            this.dgCategoryReport,
            this.dgRateReport});
            this.dgvMeals.Location = new System.Drawing.Point(12, 46);
            this.dgvMeals.Name = "dgvMeals";
            this.dgvMeals.Size = new System.Drawing.Size(599, 227);
            this.dgvMeals.TabIndex = 0;
            // 
            // DgMealItemIdReport
            // 
            this.DgMealItemIdReport.HeaderText = "Meal ItemId";
            this.DgMealItemIdReport.Name = "DgMealItemIdReport";
            // 
            // dgItemNameReport
            // 
            this.dgItemNameReport.HeaderText = "Item Name";
            this.dgItemNameReport.Name = "dgItemNameReport";
            this.dgItemNameReport.Width = 200;
            // 
            // dgCategoryReport
            // 
            this.dgCategoryReport.HeaderText = "Category";
            this.dgCategoryReport.Name = "dgCategoryReport";
            this.dgCategoryReport.Width = 150;
            // 
            // dgRateReport
            // 
            this.dgRateReport.HeaderText = "Rate";
            this.dgRateReport.Name = "dgRateReport";
            // 
            // cmbCategoryReport
            // 
            this.cmbCategoryReport.FormattingEnabled = true;
            this.cmbCategoryReport.Items.AddRange(new object[] {
            "All"});
            this.cmbCategoryReport.Location = new System.Drawing.Point(94, 19);
            this.cmbCategoryReport.Name = "cmbCategoryReport";
            this.cmbCategoryReport.Size = new System.Drawing.Size(206, 21);
            this.cmbCategoryReport.TabIndex = 1;
            this.cmbCategoryReport.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryReport_SelectedIndexChanged);
            // 
            // lblMealCategory
            // 
            this.lblMealCategory.AutoSize = true;
            this.lblMealCategory.Location = new System.Drawing.Point(13, 22);
            this.lblMealCategory.Name = "lblMealCategory";
            this.lblMealCategory.Size = new System.Drawing.Size(75, 13);
            this.lblMealCategory.TabIndex = 2;
            this.lblMealCategory.Text = "Meal Category";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = global::HotelManagementSys.Properties.Resources.Print_icon;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(290, 279);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(61, 95);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // frmMealItemReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 380);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblMealCategory);
            this.Controls.Add(this.cmbCategoryReport);
            this.Controls.Add(this.dgvMeals);
            this.Name = "frmMealItemReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meal Item Report";
            this.Load += new System.EventHandler(this.frmMealItemReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeals;
        private System.Windows.Forms.ComboBox cmbCategoryReport;
        private System.Windows.Forms.Label lblMealCategory;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgMealItemIdReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgItemNameReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCategoryReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRateReport;
    }
}