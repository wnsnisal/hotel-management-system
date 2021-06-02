namespace HotelManagementSys
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.lstViweEmployee = new System.Windows.Forms.ListBox();
            this.lblViweEmployee = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.pnlUpdateEmployes = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSaveAndUpdate = new System.Windows.Forms.Button();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbUserTypeAdd = new System.Windows.Forms.ComboBox();
            this.txtNICAdd = new System.Windows.Forms.TextBox();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserNameAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFullNameAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeeIdAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnLoginDatails = new System.Windows.Forms.Button();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pnlUpdateEmployes.SuspendLayout();
            this.pnlAddEmployee.SuspendLayout();
            this.pnlInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstViweEmployee
            // 
            this.lstViweEmployee.FormattingEnabled = true;
            this.lstViweEmployee.Location = new System.Drawing.Point(22, 44);
            this.lstViweEmployee.Name = "lstViweEmployee";
            this.lstViweEmployee.Size = new System.Drawing.Size(150, 199);
            this.lstViweEmployee.TabIndex = 2;
            this.lstViweEmployee.SelectedIndexChanged += new System.EventHandler(this.lstViweEmployee_SelectedIndexChanged);
            // 
            // lblViweEmployee
            // 
            this.lblViweEmployee.AutoSize = true;
            this.lblViweEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.lblViweEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViweEmployee.ForeColor = System.Drawing.Color.Crimson;
            this.lblViweEmployee.Location = new System.Drawing.Point(406, 52);
            this.lblViweEmployee.Name = "lblViweEmployee";
            this.lblViweEmployee.Size = new System.Drawing.Size(116, 20);
            this.lblViweEmployee.TabIndex = 3;
            this.lblViweEmployee.Text = "Viwe Employes";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.lblEmployeeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblEmployeeId.Location = new System.Drawing.Point(199, 32);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(65, 13);
            this.lblEmployeeId.TabIndex = 4;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // pnlUpdateEmployes
            // 
            this.pnlUpdateEmployes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlUpdateEmployes.Controls.Add(this.cmbStatus);
            this.pnlUpdateEmployes.Controls.Add(this.btnSaveAndUpdate);
            this.pnlUpdateEmployes.Controls.Add(this.lstViweEmployee);
            this.pnlUpdateEmployes.Controls.Add(this.cmbUserType);
            this.pnlUpdateEmployes.Controls.Add(this.txtNIC);
            this.pnlUpdateEmployes.Controls.Add(this.txtPassword);
            this.pnlUpdateEmployes.Controls.Add(this.lblStatus);
            this.pnlUpdateEmployes.Controls.Add(this.label1);
            this.pnlUpdateEmployes.Controls.Add(this.lblUserType);
            this.pnlUpdateEmployes.Controls.Add(this.lblPassword);
            this.pnlUpdateEmployes.Controls.Add(this.txtUserName);
            this.pnlUpdateEmployes.Controls.Add(this.lblUserName);
            this.pnlUpdateEmployes.Controls.Add(this.txtAddress);
            this.pnlUpdateEmployes.Controls.Add(this.lblAddress);
            this.pnlUpdateEmployes.Controls.Add(this.txtFullName);
            this.pnlUpdateEmployes.Controls.Add(this.lblFullName);
            this.pnlUpdateEmployes.Controls.Add(this.txtEmpId);
            this.pnlUpdateEmployes.Controls.Add(this.lblEmployeeId);
            this.pnlUpdateEmployes.Location = new System.Drawing.Point(37, 77);
            this.pnlUpdateEmployes.Name = "pnlUpdateEmployes";
            this.pnlUpdateEmployes.Size = new System.Drawing.Size(847, 253);
            this.pnlUpdateEmployes.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(270, 229);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(171, 21);
            this.cmbStatus.TabIndex = 11;
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.BackgroundImage = global::HotelManagementSys.Properties.Resources.button_clear;
            this.btnSaveAndUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveAndUpdate.FlatAppearance.BorderSize = 0;
            this.btnSaveAndUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveAndUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveAndUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(666, 110);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(150, 51);
            this.btnSaveAndUpdate.TabIndex = 9;
            this.btnSaveAndUpdate.Text = "Save and update";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.btnSaveAndUpdate_Click);
            this.btnSaveAndUpdate.MouseLeave += new System.EventHandler(this.btnSaveAndUpdate_MouseLeave);
            this.btnSaveAndUpdate.MouseHover += new System.EventHandler(this.btnSaveAndUpdate_MouseHover);
            // 
            // cmbUserType
            // 
            this.cmbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Manager",
            "Developer"});
            this.cmbUserType.Location = new System.Drawing.Point(270, 174);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(171, 21);
            this.cmbUserType.TabIndex = 8;
            // 
            // txtNIC
            // 
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNIC.Location = new System.Drawing.Point(270, 203);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(171, 20);
            this.txtNIC.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPassword.Location = new System.Drawing.Point(270, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(343, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblStatus.Location = new System.Drawing.Point(227, 232);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(239, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NIC";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.lblUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblUserType.Location = new System.Drawing.Point(211, 177);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(53, 13);
            this.lblUserType.TabIndex = 6;
            this.lblUserType.Text = "UserType";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblPassword.Location = new System.Drawing.Point(211, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUserName.Location = new System.Drawing.Point(270, 117);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(343, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblUserName.Location = new System.Drawing.Point(204, 119);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "User Name";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAddress.Location = new System.Drawing.Point(270, 88);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(343, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblAddress.Location = new System.Drawing.Point(219, 90);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFullName.Location = new System.Drawing.Point(270, 59);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(343, 20);
            this.txtFullName.TabIndex = 7;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.lblFullName.Location = new System.Drawing.Point(210, 61);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Full Name";
            // 
            // txtEmpId
            // 
            this.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmpId.Location = new System.Drawing.Point(270, 30);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.ReadOnly = true;
            this.txtEmpId.Size = new System.Drawing.Size(171, 20);
            this.txtEmpId.TabIndex = 5;
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAddEmployee.Controls.Add(this.btnCansel);
            this.pnlAddEmployee.Controls.Add(this.btnAdd);
            this.pnlAddEmployee.Controls.Add(this.cmbUserTypeAdd);
            this.pnlAddEmployee.Controls.Add(this.txtNICAdd);
            this.pnlAddEmployee.Controls.Add(this.txtPasswordAdd);
            this.pnlAddEmployee.Controls.Add(this.label2);
            this.pnlAddEmployee.Controls.Add(this.label3);
            this.pnlAddEmployee.Controls.Add(this.label4);
            this.pnlAddEmployee.Controls.Add(this.txtUserNameAdd);
            this.pnlAddEmployee.Controls.Add(this.label5);
            this.pnlAddEmployee.Controls.Add(this.txtAddressAdd);
            this.pnlAddEmployee.Controls.Add(this.label6);
            this.pnlAddEmployee.Controls.Add(this.txtFullNameAdd);
            this.pnlAddEmployee.Controls.Add(this.label7);
            this.pnlAddEmployee.Controls.Add(this.txtEmployeeIdAdd);
            this.pnlAddEmployee.Controls.Add(this.label8);
            this.pnlAddEmployee.Enabled = false;
            this.pnlAddEmployee.Location = new System.Drawing.Point(217, 371);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(667, 282);
            this.pnlAddEmployee.TabIndex = 5;
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
            this.btnCansel.Location = new System.Drawing.Point(524, 214);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(126, 32);
            this.btnCansel.TabIndex = 10;
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
            this.btnAdd.Location = new System.Drawing.Point(534, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 122);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // cmbUserTypeAdd
            // 
            this.cmbUserTypeAdd.FormattingEnabled = true;
            this.cmbUserTypeAdd.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Manager",
            "Developer"});
            this.cmbUserTypeAdd.Location = new System.Drawing.Point(96, 171);
            this.cmbUserTypeAdd.Name = "cmbUserTypeAdd";
            this.cmbUserTypeAdd.Size = new System.Drawing.Size(231, 21);
            this.cmbUserTypeAdd.TabIndex = 8;
            this.cmbUserTypeAdd.Text = "Select";
            // 
            // txtNICAdd
            // 
            this.txtNICAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNICAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNICAdd.Location = new System.Drawing.Point(96, 198);
            this.txtNICAdd.Name = "txtNICAdd";
            this.txtNICAdd.Size = new System.Drawing.Size(231, 23);
            this.txtNICAdd.TabIndex = 7;
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordAdd.Location = new System.Drawing.Point(96, 141);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(403, 23);
            this.txtPasswordAdd.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(64, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.label3.Location = new System.Drawing.Point(36, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.label4.Location = new System.Drawing.Point(36, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // txtUserNameAdd
            // 
            this.txtUserNameAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameAdd.Location = new System.Drawing.Point(96, 112);
            this.txtUserNameAdd.Name = "txtUserNameAdd";
            this.txtUserNameAdd.Size = new System.Drawing.Size(403, 23);
            this.txtUserNameAdd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.label5.Location = new System.Drawing.Point(29, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "User Name";
            // 
            // txtAddressAdd
            // 
            this.txtAddressAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddressAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressAdd.Location = new System.Drawing.Point(96, 83);
            this.txtAddressAdd.Name = "txtAddressAdd";
            this.txtAddressAdd.Size = new System.Drawing.Size(403, 23);
            this.txtAddressAdd.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.label6.Location = new System.Drawing.Point(44, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address";
            // 
            // txtFullNameAdd
            // 
            this.txtFullNameAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullNameAdd.Location = new System.Drawing.Point(96, 54);
            this.txtFullNameAdd.Name = "txtFullNameAdd";
            this.txtFullNameAdd.Size = new System.Drawing.Size(403, 23);
            this.txtFullNameAdd.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.label7.Location = new System.Drawing.Point(35, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Full Name";
            // 
            // txtEmployeeIdAdd
            // 
            this.txtEmployeeIdAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeIdAdd.Location = new System.Drawing.Point(96, 25);
            this.txtEmployeeIdAdd.Name = "txtEmployeeIdAdd";
            this.txtEmployeeIdAdd.ReadOnly = true;
            this.txtEmployeeIdAdd.Size = new System.Drawing.Size(231, 23);
            this.txtEmployeeIdAdd.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.label8.Location = new System.Drawing.Point(24, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Employee Id";
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.lblAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddEmployee.Location = new System.Drawing.Point(507, 348);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(111, 20);
            this.lblAddEmployee.TabIndex = 3;
            this.lblAddEmployee.Text = "Add Employes";
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
            this.btnAddNew.Location = new System.Drawing.Point(59, 371);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(135, 40);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnLoginDatails
            // 
            this.btnLoginDatails.BackgroundImage = global::HotelManagementSys.Properties.Resources.icon;
            this.btnLoginDatails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoginDatails.FlatAppearance.BorderSize = 0;
            this.btnLoginDatails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLoginDatails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLoginDatails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginDatails.Location = new System.Drawing.Point(83, 529);
            this.btnLoginDatails.Name = "btnLoginDatails";
            this.btnLoginDatails.Size = new System.Drawing.Size(85, 124);
            this.btnLoginDatails.TabIndex = 7;
            this.btnLoginDatails.Text = "Login Datails";
            this.btnLoginDatails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoginDatails.UseVisualStyleBackColor = true;
            this.btnLoginDatails.Click += new System.EventHandler(this.btnLoginDatails_Click);
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlInvoice.Controls.Add(this.btnClose);
            this.pnlInvoice.Controls.Add(this.lblEmployee);
            this.pnlInvoice.Location = new System.Drawing.Point(0, -1);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(921, 39);
            this.pnlInvoice.TabIndex = 8;
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
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmployee.Location = new System.Drawing.Point(424, 10);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(79, 20);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 675);
            this.Controls.Add(this.pnlInvoice);
            this.Controls.Add(this.btnLoginDatails);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblAddEmployee);
            this.Controls.Add(this.lblViweEmployee);
            this.Controls.Add(this.pnlAddEmployee);
            this.Controls.Add(this.pnlUpdateEmployes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(435, 81);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.pnlUpdateEmployes.ResumeLayout(false);
            this.pnlUpdateEmployes.PerformLayout();
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstViweEmployee;
        private System.Windows.Forms.Label lblViweEmployee;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Panel pnlUpdateEmployes;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Button btnSaveAndUpdate;
        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbUserTypeAdd;
        private System.Windows.Forms.TextBox txtNICAdd;
        private System.Windows.Forms.TextBox txtPasswordAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserNameAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFullNameAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmployeeIdAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnLoginDatails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEmployee;
    }
}