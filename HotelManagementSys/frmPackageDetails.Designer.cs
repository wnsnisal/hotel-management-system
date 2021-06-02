namespace HotelManagementSys
{
    partial class frmPackageDetails
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
            this.lblPackageDetails = new System.Windows.Forms.Label();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.btnWedding = new System.Windows.Forms.Button();
            this.btnPool = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnKitchen = new System.Windows.Forms.Button();
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
            this.btnClose.Location = new System.Drawing.Point(881, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPackageDetails
            // 
            this.lblPackageDetails.AutoSize = true;
            this.lblPackageDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPackageDetails.Location = new System.Drawing.Point(405, 9);
            this.lblPackageDetails.Name = "lblPackageDetails";
            this.lblPackageDetails.Size = new System.Drawing.Size(124, 20);
            this.lblPackageDetails.TabIndex = 0;
            this.lblPackageDetails.Text = "Package Details";
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlInvoice.Controls.Add(this.btnClose);
            this.pnlInvoice.Controls.Add(this.lblPackageDetails);
            this.pnlInvoice.Location = new System.Drawing.Point(-1, 0);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(921, 39);
            this.pnlInvoice.TabIndex = 2;
            // 
            // btnWedding
            // 
            this.btnWedding.BackColor = System.Drawing.Color.Transparent;
            this.btnWedding.BackgroundImage = global::HotelManagementSys.Properties.Resources.WeddingNormal;
            this.btnWedding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWedding.FlatAppearance.BorderSize = 0;
            this.btnWedding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWedding.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWedding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWedding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWedding.Location = new System.Drawing.Point(32, 258);
            this.btnWedding.Name = "btnWedding";
            this.btnWedding.Size = new System.Drawing.Size(210, 184);
            this.btnWedding.TabIndex = 4;
            this.btnWedding.Text = "Wedding";
            this.btnWedding.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWedding.UseVisualStyleBackColor = false;
            this.btnWedding.MouseLeave += new System.EventHandler(this.btnWedding_MouseLeave);
            this.btnWedding.MouseHover += new System.EventHandler(this.btnWedding_MouseHover);
            // 
            // btnPool
            // 
            this.btnPool.BackColor = System.Drawing.Color.Transparent;
            this.btnPool.BackgroundImage = global::HotelManagementSys.Properties.Resources.PoolNormal;
            this.btnPool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPool.FlatAppearance.BorderSize = 0;
            this.btnPool.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPool.Location = new System.Drawing.Point(680, 68);
            this.btnPool.Name = "btnPool";
            this.btnPool.Size = new System.Drawing.Size(210, 184);
            this.btnPool.TabIndex = 3;
            this.btnPool.Text = "Pool";
            this.btnPool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPool.UseVisualStyleBackColor = false;
            this.btnPool.Click += new System.EventHandler(this.btnPool_Click);
            this.btnPool.MouseLeave += new System.EventHandler(this.btnPool_MouseLeave);
            this.btnPool.MouseHover += new System.EventHandler(this.btnPool_MouseHover);
            // 
            // btnBar
            // 
            this.btnBar.BackColor = System.Drawing.Color.Transparent;
            this.btnBar.BackgroundImage = global::HotelManagementSys.Properties.Resources.BarNormal;
            this.btnBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBar.FlatAppearance.BorderSize = 0;
            this.btnBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBar.Location = new System.Drawing.Point(464, 68);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(210, 184);
            this.btnBar.TabIndex = 3;
            this.btnBar.Text = "Bar";
            this.btnBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBar.UseVisualStyleBackColor = false;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            this.btnBar.MouseLeave += new System.EventHandler(this.btnBar_MouseLeave);
            this.btnBar.MouseHover += new System.EventHandler(this.btnBar_MouseHover);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.Transparent;
            this.btnRooms.BackgroundImage = global::HotelManagementSys.Properties.Resources.RoomsNormal;
            this.btnRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.Location = new System.Drawing.Point(248, 68);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(210, 184);
            this.btnRooms.TabIndex = 3;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            this.btnRooms.MouseLeave += new System.EventHandler(this.btnRooms_MouseLeave);
            this.btnRooms.MouseHover += new System.EventHandler(this.btnRooms_MouseHover);
            // 
            // btnKitchen
            // 
            this.btnKitchen.BackColor = System.Drawing.Color.Transparent;
            this.btnKitchen.BackgroundImage = global::HotelManagementSys.Properties.Resources.KitchenNormal;
            this.btnKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKitchen.FlatAppearance.BorderSize = 0;
            this.btnKitchen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKitchen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.Location = new System.Drawing.Point(32, 68);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(210, 184);
            this.btnKitchen.TabIndex = 3;
            this.btnKitchen.Text = "Kitchen";
            this.btnKitchen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitchen.UseVisualStyleBackColor = false;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            this.btnKitchen.MouseLeave += new System.EventHandler(this.btnKitchen_MouseLeave);
            this.btnKitchen.MouseHover += new System.EventHandler(this.btnKitchen_MouseHover);
            // 
            // frmPackageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 675);
            this.Controls.Add(this.btnWedding);
            this.Controls.Add(this.btnPool);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnKitchen);
            this.Controls.Add(this.pnlInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(435, 81);
            this.Name = "frmPackageDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmPackageDetails";
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPackageDetails;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnPool;
        private System.Windows.Forms.Button btnWedding;
    }
}