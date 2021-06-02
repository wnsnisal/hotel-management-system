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
    public partial class frmUpdateBooking : Form
    {
        public frmUpdateBooking()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbBookingPackageName.Text = "Select";
            cmbRoomNumber.Text = "Select";
            cmbStatus.Text = "Select";
            txtCustomerName.Text = "";
            
        }

        private void frmUpdateBooking_Load(object sender, EventArgs e)
        {
            txtBookingId.Text = Convert.ToString(frmBooking.BookingID);
            cmbBookingPackageName.Text = frmBooking.BookingPackage;
            cmbRoomNumber.Text = Convert.ToString(frmBooking.RoomNumber);
            dtmBookingDate.Value = frmBooking.BookingDate;
            cmbStatus.Text = frmBooking.Status;
            txtUserName.Text = frmBooking.UserName;
            txtCustomerName.Text = frmBooking.CustomerName;
        }

        private void btnUpdateAndSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerName.Text.Length >= 100)
                {
                    MessageBox.Show("Maximum length of Customer name is 100 latters, Please try agan", "infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbBookingPackageName.Text == "Select" || cmbRoomNumber.Text == "Select" || cmbStatus.Text == "Select")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "UPDATE tblBookingDetails SET BookingPackageName = '"+cmbBookingPackageName.Text+ "', BookingDate = '"+dtmBookingDate.Value+ "', RoomNumber = '"+Convert.ToInt32(cmbRoomNumber.Text)+ "', CustomerName = '"+txtCustomerName.Text+"', Status = '"+cmbStatus.Text+ "' WHERE BookingId = '" + Convert.ToInt32(txtBookingId.Text)+"'";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    MessageBox.Show("Sucess", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

            }
            catch
            {
                MessageBox.Show("Invalide input, Please try agan", "infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
