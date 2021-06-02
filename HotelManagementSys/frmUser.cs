using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSys
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnSaveAndUpdate_MouseHover(object sender, EventArgs e)
        {
            btnSaveAndUpdate.BackgroundImage = Properties.Resources.button;
        }

        private void btnSaveAndUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnSaveAndUpdate.BackgroundImage = Properties.Resources.button_clear;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = Properties.Resources.AddLight;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close();
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = Properties.Resources.AddNormal;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            pnlAddEmployee.Enabled = true;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            //change to the default values
            txtFullNameAdd.Text = "";
            txtAddressAdd.Text = "";
            txtNICAdd.Text = "";
            txtPasswordAdd.Text = "";
            cmbUserTypeAdd.Text = "Select";
            txtUserNameAdd.Text = "";
            //disable the pannel
            pnlAddEmployee.Enabled = false;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            //btnClose.ForeColor = Color.Red;
        }

        private void btnClose_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            //btnClose.ForeColor = Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFullNameAdd.Text == "" || txtAddressAdd.Text == "" || txtUserNameAdd.Text == "" || txtPasswordAdd.Text == "" || cmbUserTypeAdd.Text == "Select" || txtNICAdd.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAddressAdd.Text.Length > 100)
            {
                MessageBox.Show("maximum length of Address is 100 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtUserNameAdd.Text.Length > 15)
            {
                MessageBox.Show("maximum length of Unser Name is 15 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtFullNameAdd.Text.Length > 50)
            {
                MessageBox.Show("maximum length of Full Name is 50 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtPasswordAdd.Text.Length > 20)
            {
                MessageBox.Show("maximum length of Password is 20 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtNICAdd.Text.Length > 15)
            {
                MessageBox.Show("maximum length of NIC is 15 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //use try catch for exception hanndling
                try
                {
                    
                    //encript the password
                    String PasswordAdd = Convert.ToBase64String(Encoding.Unicode.GetBytes(txtPasswordAdd.Text));
                    //Insert data to tblUser
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblUser(UserId, FullName, Address, UserName, Password, USerType, NIC, Status) VALUES('" + Convert.ToInt32(txtEmployeeIdAdd.Text) + "','" + txtFullNameAdd.Text + "','" + txtAddressAdd.Text + "','" + txtUserNameAdd.Text + "','" + PasswordAdd + "','" + cmbUserTypeAdd.Text + "','" + txtNICAdd.Text + "','"+"Active"+"')";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    MessageBox.Show("Sucess", "infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtFullNameAdd.Text = "";
                    txtAddressAdd.Text = "";
                    txtUserNameAdd.Text = "";
                    txtPasswordAdd.Text = "";
                    cmbUserTypeAdd.Text = "Select";
                    txtNICAdd.Text = "";
                    

                    pnlAddEmployee.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("invalid input, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            

        }

        private void btnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtAddress.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || cmbUserType.Text == "Select" || txtNIC.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAddressAdd.Text.Length > 100)
            {
                MessageBox.Show("maximum length of Address is 100 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtUserNameAdd.Text.Length > 15)
            {
                MessageBox.Show("maximum length of Unser Name is 15 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtFullNameAdd.Text.Length > 50)
            {
                MessageBox.Show("maximum length of Full Name is 50 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPasswordAdd.Text.Length > 20)
            {
                MessageBox.Show("maximum length of Password is 20 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtNICAdd.Text.Length > 15)
            {
                MessageBox.Show("maximum length of NIC is 15 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //use try catch for exception hanndling
                //try
                //{
                    //encript the password
                    String PasswordUpdate = Convert.ToBase64String(Encoding.Unicode.GetBytes(txtPassword.Text));
                    //send Update comment to SQL server
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "UPDATE tblUser SET FullName='" + txtFullName.Text + "', Address='" + txtAddress.Text + "', UserName='" + txtUserName.Text + "', Password='" + PasswordUpdate + "', UserType='" + cmbUserType.Text + "', NIC='" + txtNIC.Text + "', Status='"+ cmbStatus.Text+"' WHERE UserId = '"+Convert.ToInt32(txtEmpId.Text)+"'";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    MessageBox.Show("Update sucess..!!", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtEmpId.Text = "";
                    txtFullName.Text = "";
                    txtAddress.Text = "";
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    cmbUserType.Text = "Select";
                    txtNIC.Text = "";
                    cmbStatus.Text = "Select";
                /*}
                catch
                {
                    MessageBox.Show("invalid input, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
            }
            
            
        }

        private void lstViweEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                frmMain.DS.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser WHERE FullName = '" + lstViweEmployee.SelectedItem.ToString() + "'", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblUser");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblUser"].Rows.Count;
                while(currentRow < rowCount)
                {
                    String Password = Encoding.Unicode.GetString(Convert.FromBase64String(frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[4].ToString()));

                    
                    txtEmpId.Text = frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[0].ToString();
                    txtFullName.Text = frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString();
                    txtAddress.Text = frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[2].ToString();
                    txtUserName.Text = frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[3].ToString();
                    txtPassword.Text = Password;
                    cmbUserType.Text = frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[5].ToString();
                    txtNIC.Text = frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[6].ToString();
                    cmbStatus.Text = frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[7].ToString();
                    currentRow++;
                }
            }
            catch
            {
                MessageBox.Show("Plesae select the Employee Name.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                frmMain.DS.Clear();
                frmMain.con.Close();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblUser");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblUser"].Rows.Count;
                while (currentRow < rowCount)
                {
                    txtEmployeeIdAdd.Text = Convert.ToString(Convert.ToInt32(frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[0].ToString()) + 1);
                    lstViweEmployee.Items.Add(frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString());

                    currentRow++;
                }
            }
            catch
            {
                MessageBox.Show("data base error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnLoginDatails_Click(object sender, EventArgs e)
        {
            frmLoginDatails LoginDetails = new frmLoginDatails();
            LoginDetails.ShowDialog();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
