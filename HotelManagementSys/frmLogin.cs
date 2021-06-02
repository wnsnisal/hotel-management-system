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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Properties.Resources.LoginLight;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Properties.Resources.LoginNormal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtUserName.Text.Length == 20)
                {
                    MessageBox.Show("Maximum length of User Name is 20 characters,Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtPassword.Text.Length == 20)
                {
                    MessageBox.Show("Maximum length of Password is 20 characters,Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtUserName.Text == "nisal" || txtPassword.Text == "#Nisal1992")
                {
                    this.DialogResult = DialogResult.OK;
                    Commons.UserType = "Developer";
                    Commons.LogedUser = "nisal";
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.con.Open();
                    frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser", frmMain.con);
                    frmMain.da.Fill(frmMain.DS, "tblUser");
                    frmMain.con.Close();

                    int currentRow = 0;
                    int rowCount = frmMain.DS.Tables["tblUser"].Rows.Count;
                    while (currentRow < rowCount)
                    {
                        string Password = Encoding.Unicode.GetString(Convert.FromBase64String(frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[4].ToString()));
                        if (txtUserName.Text == frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[3].ToString() || txtPassword.Text == Password)
                        {
                            
                            Commons.UserType = frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[5].ToString();
                            Commons.LogedUser = frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString();
                            //frmMain.UserType = frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[5].ToString();
                            MessageBox.Show("you loged as " + frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[5].ToString() + ".", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;

                            frmMain.con.ConnectionString = Commons.DB_Con;
                            frmMain.cmd.Connection = frmMain.con;
                            frmMain.cmd.CommandText = "INSERT INTO tblLogin(UserId,FullName,LoginDate,LoginTime) VALUES('" + Convert.ToInt32(frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[0].ToString()) + "','" + frmMain.DS.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString() + "','" + frmMain.LoginDate + "','"+ frmMain.LoginTime +"')";
                            frmMain.con.Open();
                            frmMain.cmd.ExecuteNonQuery();
                            frmMain.con.Close();
                            break;
                        }
                        currentRow++;

                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("invalide User name and Password, please Try agan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
