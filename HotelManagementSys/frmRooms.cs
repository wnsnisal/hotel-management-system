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
    public partial class frmRooms : Form
    {
        public int RoomPackageId;
        public frmRooms()
        {
            InitializeComponent();
        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            
            lstPackageName.Items.Clear();
            frmMain.DS1.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT DISTINCT RoomPackageName FROM tblRoomPackage", frmMain.con);
            frmMain.da.Fill(frmMain.DS1, "tblRoomPackage");
            frmMain.con.Close();

            
            int CurrentRow = 0;
            int RowCount = frmMain.DS1.Tables["tblRoomPackage"].Rows.Count;
            while (CurrentRow < RowCount)
            {

                lstPackageName.Items.Add(frmMain.DS1.Tables["tblRoomPackage"].Rows[CurrentRow].ItemArray[0].ToString());
                
                CurrentRow++;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbPackageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnPackagePrice_Click(object sender, EventArgs e)
        {
            try
            {
                frmMain.DS.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblRoomPackage", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblRoomPackage");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblRoomPackage"].Rows.Count;
                while (currentRow < rowCount)
                {

                    if (cmbPackageName.SelectedItem.ToString() == frmMain.DS.Tables["tblRoomPackage"].Rows[currentRow].ItemArray[1].ToString())
                    {
                        if (cmbRoomType.SelectedItem.ToString() == frmMain.DS.Tables["tblRoomPackage"].Rows[currentRow].ItemArray[2].ToString())
                        {
                            txtPackagePrice.Text = frmMain.DS.Tables["tblRoomPackage"].Rows[currentRow].ItemArray[3].ToString();
                            break;
                        }

                    }
                    currentRow++;
                }
            }
            catch
            {
                MessageBox.Show("Undefined Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlEditPackage.Enabled = true;

            
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            txtPackagePrice.Text = "";
            
            pnlEditPackage.Enabled = false;
        }

        private void btnEditAndSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPriceEdit.Text == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "UPDATE tblPackage SET Rate = '"+txtPriceEdit.Text+ "' WHERE RoomPackageName = '" + Convert.ToString(RoomPackageId)+ "'";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    txtPriceEdit.Text = "";
                    
                    txtRoomTypeEdit.Text = "";

                    pnlEditPackage.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("invalide input, Please try agan", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cmbPackageNameEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPackageNameEdit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lstPackageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblRoomPackage", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblRoomPackage");
            frmMain.con.Close();


            int CurrentRow = 0;
            int RowCount = frmMain.DS.Tables["tblRoomPackage"].Rows.Count;
            while (CurrentRow < RowCount)
            {
                if (lstPackageName.SelectedItem.ToString() == frmMain.DS.Tables["tblRoomPackage"].Rows[CurrentRow].ItemArray[1].ToString())
                {
                    
                    txtRoomTypeEdit.Text = frmMain.DS.Tables["tblRoomPackage"].Rows[CurrentRow].ItemArray[2].ToString();
                    txtPackagePrice.Text = frmMain.DS.Tables["tblRoomPackage"].Rows[CurrentRow].ItemArray[3].ToString();
                    RoomPackageId = Convert.ToInt32(frmMain.DS.Tables["tblRoomPackage"].Rows[CurrentRow].ItemArray[0].ToString());
                    break;
                }

                CurrentRow++;
            }
        }
    }
}
