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
    public partial class frmUpdateStockDetails : Form
    {
        public frmUpdateStockDetails()
        {
            InitializeComponent();
        }

        private void btnUpdateAndSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtItemName.Text.Length >= 100)
                {
                    MessageBox.Show("Maximum length of ItemName is 100 latters, Please try agan", "infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "UPDATE tblStock SET ItemName = '" + txtItemName.Text + "', ItemRate = '" + Convert.ToDouble(txtItemRate.Text) + "', Quentity = '" + Convert.ToInt32(txtQuentity.Text) + "' , ItemCategory = '" + cmbItemCatagery.SelectedItem.ToString()+"' WHERE StockItemId = '"+Convert.ToInt32(txtStockItemId.Text)+"'";
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

        private void frmUpdateStockDetails_Load(object sender, EventArgs e)
        {
            txtStockItemId.Text = frmStockDetails.StockItemId;
            txtItemName.Text = frmStockDetails.ItemName;
            txtItemRate.Text = frmStockDetails.ItemRate;
            txtQuentity.Text = frmStockDetails.Quentity;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbItemCatagery.Text = "Select";
            txtItemName.Text = "";
            txtItemRate.Text = "";
            txtQuentity.Text = "";
            
        }
    }
}
