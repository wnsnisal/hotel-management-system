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
    public partial class frmBooking : Form
    {
        public static int BookingID;
        public static string BookingPackage;
        public static DateTime BookingDate;
        public static int RoomNumber;
        public static string CustomerName;
        public static string Status;
        public static string UserName;
        public frmBooking()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void mcBookingDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            dgvBookingViwe.Rows.Clear();
            DateTime BookingDate = Convert.ToDateTime(mcBookingDate.SelectionEnd.Date.ToString());

            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblBookingDetails", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblBookingDetails");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS.Tables["tblBookingDetails"].Rows.Count;
            while (currentRow < rowCount)
            {
                if(BookingDate == Convert.ToDateTime(frmMain.DS.Tables["tblBookingDetails"].Rows[currentRow].ItemArray[2].ToString()))
                {
                    int n = dgvBookingViwe.Rows.Add();
                    dgvBookingViwe.Rows[n].Cells[0].Value = (frmMain.DS.Tables["tblBookingDetails"].Rows[currentRow].ItemArray[0].ToString());
                    dgvBookingViwe.Rows[n].Cells[1].Value = (frmMain.DS.Tables["tblBookingDetails"].Rows[currentRow].ItemArray[1].ToString());
                    dgvBookingViwe.Rows[n].Cells[2].Value = (frmMain.DS.Tables["tblBookingDetails"].Rows[currentRow].ItemArray[2].ToString());
                    dgvBookingViwe.Rows[n].Cells[3].Value = (frmMain.DS.Tables["tblBookingDetails"].Rows[currentRow].ItemArray[3].ToString());
                    dgvBookingViwe.Rows[n].Cells[4].Value = (frmMain.DS.Tables["tblBookingDetails"].Rows[currentRow].ItemArray[4].ToString());
                    dgvBookingViwe.Rows[n].Cells[5].Value = (frmMain.DS.Tables["tblBookingDetails"].Rows[currentRow].ItemArray[5].ToString());
                    dgvBookingViwe.Rows[n].Cells[6].Value = (frmMain.DS.Tables["tblBookingDetails"].Rows[currentRow].ItemArray[6].ToString());
                    break;
                }
                
                
                currentRow++;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            grpAddBookings.Enabled = true;

            txtUserName.Text = Commons.LogedUser;

            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT BookingId FROM tblBookingDetails", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblBookingDetails");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS.Tables["tblBookingDetails"].Rows.Count;
            while (currentRow < rowCount)
            {
                txtBookingId.Text = Convert.ToString(Convert.ToInt32(frmMain.DS.Tables["tblBookingDetails"].Rows[currentRow].ItemArray[0].ToString())+1);
                currentRow++;
            }

            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT RoomPackageName FROM tblRoomPackage", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblRoomPackage");
            frmMain.con.Close();

            int currentRow1 = 0;
            int rowCount1 = frmMain.DS.Tables["tblRoomPackage"].Rows.Count;
            while (currentRow1 < rowCount1)
            {
                cmdBookingPackageName.Items.Add(frmMain.DS.Tables["tblRoomPackage"].Rows[currentRow1].ItemArray[0].ToString());
                currentRow1++;
            }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            
            
            txtCustomerName.Text = "";
            
            txtUserName.Text = "";
            grpAddBookings.Enabled = false;
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRoomNumber.Text == "" || cmdBookingPackageName.Text == "Select" || txtCustomerName.Text == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtCustomerName.Text.Length >= 50)
                {
                    MessageBox.Show("Maximum length of Customer Name is 50 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblBookingDetails (BookingID,BookingPackageName,BookingDate,RoomNumber,CustomerName,UserName,Status) VALUES('"+Convert.ToInt32(txtBookingId.Text)+"','"+cmdBookingPackageName.SelectedItem.ToString()+"','"+dtmBookingDate.Value+"','"+Convert.ToInt32(cmbRoomNumber.Text)+"','"+txtCustomerName.Text+"','"+txtUserName.Text+"','"+"Pending"+"')";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    MessageBox.Show("Sucess", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch
            {
                MessageBox.Show("Invalied input,Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomNumber.Items.Clear();

            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT RoomNumber FROM tblRooms WHERE RoomType='"+cmbRoomType.SelectedItem.ToString()+"'", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblRooms");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS.Tables["tblRooms"].Rows.Count;
            while (currentRow < rowCount)
            {
                cmbRoomNumber.Items.Add(Convert.ToInt32(frmMain.DS.Tables["tblRooms"].Rows[currentRow].ItemArray[0].ToString()));
                currentRow++;
            }
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookingID = Convert.ToInt32(dgvBookingViwe.CurrentRow.Cells[0].Value.ToString());
            BookingPackage = dgvBookingViwe.CurrentRow.Cells[1].Value.ToString();
            BookingDate = Convert.ToDateTime(dgvBookingViwe.CurrentRow.Cells[2].Value.ToString());
            RoomNumber = Convert.ToInt32(dgvBookingViwe.CurrentRow.Cells[3].Value.ToString());
            CustomerName = dgvBookingViwe.CurrentRow.Cells[4].Value.ToString();
            UserName = dgvBookingViwe.CurrentRow.Cells[5].Value.ToString();
            Status = dgvBookingViwe.CurrentRow.Cells[6].Value.ToString();

            frmUpdateBooking UpdateBooking = new frmUpdateBooking();
            UpdateBooking.ShowDialog();
        }

        private void btnComplteBooking_Click(object sender, EventArgs e)
        {
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "UPDATE tblBookingDetails SET Status = '" + "Complate" + "' WHERE BookingId = '" + dgvBookingViwe.CurrentRow.Cells[0].ToString() + "'";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();
        }

        private void btnCanselBooking_Click(object sender, EventArgs e)
        {
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "UPDATE tblBookingDetails SET Status = '" + "Canseled" + "' WHERE BookingId = '" + dgvBookingViwe.CurrentRow.Cells[0].ToString() + "'";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();
        }

        private void btnBookingReport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
