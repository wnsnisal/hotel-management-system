namespace HotelManagementSys
{
    partial class frmPool
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
            this.lblPool = new System.Windows.Forms.Label();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlInvoice.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(878, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPool
            // 
            this.lblPool.AutoSize = true;
            this.lblPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPool.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPool.Location = new System.Drawing.Point(460, 7);
            this.lblPool.Name = "lblPool";
            this.lblPool.Size = new System.Drawing.Size(40, 20);
            this.lblPool.TabIndex = 0;
            this.lblPool.Text = "Pool";
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlInvoice.Controls.Add(this.btnClose);
            this.pnlInvoice.Controls.Add(this.lblPool);
            this.pnlInvoice.Location = new System.Drawing.Point(0, 0);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(921, 39);
            this.pnlInvoice.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HotelManagementSys.Properties.Resources.Pool;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 638);
            this.panel1.TabIndex = 4;
            // 
            // frmPool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(919, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(435, 81);
            this.Name = "frmPool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmPool";
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPool;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Panel panel1;
    }
}