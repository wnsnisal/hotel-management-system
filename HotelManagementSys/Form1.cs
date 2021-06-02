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
    public partial class frmMain : Form
    {
        public static System.Data.SqlClient.SqlConnection
            con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlCommand
            cmd = new System.Data.SqlClient.SqlCommand();
        public static System.Data.SqlClient.SqlDataAdapter
            da = new System.Data.SqlClient.SqlDataAdapter();

        public static DataSet DS = new DataSet();
        public static DataSet DS1 = new DataSet();

        //public static String UserType;
        public static DateTime LoginDate = DateTime.Now;
        public static DateTime LoginTime = DateTime.Now;
        public static DateTime LogoutDate = DateTime.Now;
        public static DateTime LogoutTime = DateTime.Now;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            //btnLogin.BackColor = Color.Purple;
        }

        private void btnInvoice_MouseHover(object sender, EventArgs e)
        {
            //btnInvoice.BackColor = Color.Purple;
        }

        private void btnStockDetails_MouseHover(object sender, EventArgs e)
        {
            //btnStockDetails.BackColor = Color.Purple;
        }

        private void btnCustomerDetails_MouseHover(object sender, EventArgs e)
        {
           // btnCustomerDetails.BackColor = Color.Purple;
        }

        private void btnPackageDEtails_MouseHover(object sender, EventArgs e)
        {
           // btnPackageDEtails.BackColor = Color.Purple;
        }

        private void btnEmployeeDetails_MouseHover(object sender, EventArgs e)
        {
            //btnEmployeeDetails.BackColor = Color.Purple;
        }

        private void btnRooms_MouseHover(object sender, EventArgs e)
        {
            //btnRooms.BackColor = Color.Purple;
        }

        private void btnBar_MouseHover(object sender, EventArgs e)
        {
            //btnBar.BackColor = Color.Purple;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            //btnLogin.BackColor = Color.Transparent;
        }

        private void btnInvoice_MouseLeave(object sender, EventArgs e)
        {
            //btnInvoice.BackColor = Color.Transparent;

        }

        private void btnStockDetails_MouseLeave(object sender, EventArgs e)
        {
            //btnStockDetails.BackColor = Color.Transparent;
        }

        private void btnCustomerDetails_MouseLeave(object sender, EventArgs e)
        {
            //btnCustomerDetails.BackColor = Color.Transparent;
        }

        private void btnPackageDEtails_MouseLeave(object sender, EventArgs e)
        {
            //btnPackageDEtails.BackColor = Color.Transparent;
        }

        private void btnEmployeeDetails_MouseLeave(object sender, EventArgs e)
        {
            //btnEmployeeDetails.BackColor = Color.Transparent;
        }

        private void btnRooms_MouseLeave(object sender, EventArgs e)
        {
            //btnRooms.BackColor = Color.Transparent;
        }

        private void btnBar_MouseLeave(object sender, EventArgs e)
        {
            //btnBar.BackColor = Color.Transparent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnLogin.Enabled == true)
                {
                    Close();
                }
                else
                {
                    Close();

                    btnLogin.Enabled = true;
                    btnLogout.Enabled = false;
                    btnInvoice.Enabled = false;
                    btnBackup.Enabled = false;
                    btnStockDetails.Enabled = false;
                    btnCustomerDetails.Enabled = false;
                    btnPackageDEtails.Enabled = false;
                    btnEmployeeDetails.Enabled = false;
                    btnBooking.Enabled = false;
                    //btnBar.Enabled = false;

                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.con.Open();
                    frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser WHERE FullName = '" + Commons.LogedUser + "'", frmMain.con);
                    frmMain.da.Fill(frmMain.DS, "tblUser");
                    frmMain.con.Close();

                    //DateTime LogoutDateTime = DateTime.Now;

                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblLogin(UserId,FullName,LogoutDate,LogoutTime) VALUES('" + Convert.ToInt32(frmMain.DS.Tables["tblUser"].Rows[0].ItemArray[0].ToString()) + "','" + frmMain.DS.Tables["tblUser"].Rows[0].ItemArray[1].ToString() + "','" + LogoutDate + "','" + LogoutTime + "')";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();
                }
            }
            catch
            {
                if(Commons.LogedUser == "nisal")
                {
                    Close();
                }
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            
            if(Login.ShowDialog() == DialogResult.OK)
            {
                btnLogout.Enabled = true;
                btnLogin.Enabled = false;
                
                if(Commons.UserType == "Developer")
                {
                    btnInvoice.Enabled = true;
                    btnBackup.Enabled = true;
                    btnStockDetails.Enabled = true;
                    btnCustomerDetails.Enabled = true;
                    btnPackageDEtails.Enabled = true;
                    btnEmployeeDetails.Enabled = true;
                    btnBooking.Enabled = true;
                    //btnBar.Enabled = true;
                }
                else if(Commons.UserType == "Admin")
                {
                    btnInvoice.Enabled = true;
                    btnBackup.Enabled = true;
                    btnStockDetails.Enabled = true;
                    btnCustomerDetails.Enabled = true;
                    btnPackageDEtails.Enabled = true;
                    btnEmployeeDetails.Enabled = true;
                    btnBooking.Enabled = true;
                    //btnBar.Enabled = true;
                }
                else if(Commons.UserType == "Manager")
                {
                    btnInvoice.Enabled = true;
                    btnBackup.Enabled = true;
                    btnStockDetails.Enabled = true;
                    btnCustomerDetails.Enabled = true;
                    btnPackageDEtails.Enabled = true;
                    btnEmployeeDetails.Enabled = true;
                    btnBooking.Enabled = true;
                    //btnBar.Enabled = true;
                }
                else if(Commons.UserType == "User")
                {
                    btnInvoice.Enabled = true;
                    btnBackup.Enabled = true;
                }
            }
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = Properties.Resources.powerPopup;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = Properties.Resources.power;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice Invoice = new frmInvoice();
            Invoice.ShowDialog();
        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            frmUser User = new frmUser();
            User.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dtmDate.Value = LoginDate;
            dtmDate.Value = LogoutDate;
            dtmTime.Value = LoginTime;
            dtmTime.Value = LogoutDate;
            btnLogout.Enabled = false;
            //lblUserType.Text = frmMain.UserType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            btnInvoice.Enabled = false;
            btnBackup.Enabled = false;
            btnStockDetails.Enabled = false;
            btnCustomerDetails.Enabled = false;
            btnPackageDEtails.Enabled = false;
            btnEmployeeDetails.Enabled = false;
            btnBooking.Enabled = false;
            //btnBar.Enabled = false;

            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser WHERE FullName = '" + Commons.LogedUser + "'", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblUser");
            frmMain.con.Close();

            //DateTime LogoutDateTime = DateTime.Now;

            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "INSERT INTO tblLogin(UserId,FullName,LogoutDate,LogoutTime) VALUES('" + Convert.ToInt32(frmMain.DS.Tables["tblUser"].Rows[0].ItemArray[0].ToString()) + "','" + frmMain.DS.Tables["tblUser"].Rows[0].ItemArray[1].ToString() + "','" + LogoutDate + "','"+ LogoutTime +"')";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();
        }

        private void btnMinimize_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStockDetails_Click(object sender, EventArgs e)
        {
            frmStockDetails Stockdetails = new frmStockDetails();
            Stockdetails.ShowDialog();
        }

        private void btnPackageDEtails_Click(object sender, EventArgs e)
        {
            frmPackageDetails PackageDetails = new frmPackageDetails();
            PackageDetails.ShowDialog();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking Booking = new frmBooking();
            Booking.ShowDialog();
        }
    }
}
