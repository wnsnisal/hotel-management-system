namespace HotelManagementSys
{
    partial class frmStockOutReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockOutReport));
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlStockOutReport = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printStockOutReport = new System.Drawing.Printing.PrintDocument();
            this.printStockOutReportPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.White;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(325, 21);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(135, 24);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "HOTEL HILRO";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.White;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(332, 67);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(120, 20);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "stock out report";
            // 
            // txtMonth
            // 
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(342, 45);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 19);
            this.txtMonth.TabIndex = 2;
            this.txtMonth.Text = "Month";
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 551);
            this.dataGridView1.TabIndex = 3;
            // 
            // pnlStockOutReport
            // 
            this.pnlStockOutReport.BackColor = System.Drawing.Color.White;
            this.pnlStockOutReport.Location = new System.Drawing.Point(12, 12);
            this.pnlStockOutReport.Name = "pnlStockOutReport";
            this.pnlStockOutReport.Size = new System.Drawing.Size(760, 639);
            this.pnlStockOutReport.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::HotelManagementSys.Properties.Resources.Print;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(336, 661);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 80);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printStockOutReport
            // 
            this.printStockOutReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printStockOutReport_PrintPage);
            // 
            // printStockOutReportPreviewDialog
            // 
            this.printStockOutReportPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printStockOutReportPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printStockOutReportPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printStockOutReportPreviewDialog.Document = this.printStockOutReport;
            this.printStockOutReportPreviewDialog.Enabled = true;
            this.printStockOutReportPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printStockOutReportPreviewDialog.Icon")));
            this.printStockOutReportPreviewDialog.Name = "printStockOutReportPreviewDialog";
            this.printStockOutReportPreviewDialog.Visible = false;
            // 
            // frmStockOutReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.pnlStockOutReport);
            this.Name = "frmStockOutReport";
            this.Text = "frmStockOutReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlStockOutReport;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printStockOutReport;
        private System.Windows.Forms.PrintPreviewDialog printStockOutReportPreviewDialog;
    }
}