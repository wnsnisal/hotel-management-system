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
    public partial class frmStockDetails : Form
    {
        public static String StockItemId;
        public static String ItemName;
        public static String ItemRate;
        public static String Quentity;
        public static String ItemCategory;

        public frmStockDetails()
        {
            InitializeComponent();
        }

        private void grbAddToStock_Enter(object sender, EventArgs e)
        {

        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            cmbCategory.Text = "Select";
            txtItemName.Text = "";
            txtItemRate.Text = "";
            txtQuentity.Text = "";
            frmMain.DS.Clear();
            grbAddToStock.Enabled = false;
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            grbAddToStock.Enabled = true;

            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStock", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblStock");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS.Tables["tblStock"].Rows.Count;
            while (currentRow < rowCount)
            {
                txtStockItemId.Text = Convert.ToString(Convert.ToInt32(frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[0].ToString()) + 1);
                currentRow++;
            }
        }

        private void frmStockDetails_Load(object sender, EventArgs e)
        {
           
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemName.Text == "" || txtItemRate.Text == "" || txtQuentity.Text == "" || cmbCategory.Text == "Select")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtItemName.Text.Length >= 100)
                {
                    MessageBox.Show("Maximum length of ItemName is 100 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblStock (StockItemId,ItemName,itemRate,Quentity,ItemCategory) VALUES('" + Convert.ToInt32(txtStockItemId.Text) + "','" + txtItemName.Text + "','" + Convert.ToDouble(txtItemRate.Text) + "','" + Convert.ToInt32(txtQuentity.Text) + "','"+cmbCategory.Text+"')";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    MessageBox.Show("Sucess..!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtItemName.Text = "";
                    txtItemRate.Text = "";
                    txtQuentity.Text = "";

                    grbAddToStock.Enabled = false;
                }
                
            }
            catch
            {
                MessageBox.Show("invalide input, Please try agan","infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void btItemSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lstItems.Items.Clear();

                frmMain.DS.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStock", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblStock");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblStock"].Rows.Count;
                while (currentRow < rowCount)
                {
                    
                    if (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[1].ToString().Contains(btItemSearch.Text))
                    {
                        lstItems.Items.Add(frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[1].ToString());
                        currentRow++;
                    }
                    else
                    {
                        break;
                    }


                }
            }
            catch
            {
                MessageBox.Show("invailed item name", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btItemSearch_MouseEnter(object sender, EventArgs e)
        {

        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvStockDetails.Rows.Clear();

                frmMain.DS.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStock", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblStock");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblStock"].Rows.Count;
                while (currentRow < rowCount)
                {
                    if(lstItems.SelectedItem.ToString() == frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[1].ToString())
                    {
                        int n = dgvStockDetails.Rows.Add();
                        dgvStockDetails.Rows[n].Cells[0].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[0].ToString());
                        dgvStockDetails.Rows[n].Cells[1].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[1].ToString());
                        dgvStockDetails.Rows[n].Cells[2].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[4].ToString());
                        dgvStockDetails.Rows[n].Cells[3].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[2].ToString());
                        dgvStockDetails.Rows[n].Cells[4].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[3].ToString());
                        dgvStockDetails.Rows[n].Cells[5].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[5].ToString());
                        break;
                    }
                    
                    currentRow++;

                }
            }
            catch
            {
                MessageBox.Show("Please select the item name", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnAllItems_Click(object sender, EventArgs e)
        {
            dgvStockDetails.Rows.Clear();
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStock", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblStock");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS.Tables["tblStock"].Rows.Count;
            while (currentRow < rowCount)
            {
                int n = dgvStockDetails.Rows.Add();
                dgvStockDetails.Rows[n].Cells[0].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[0].ToString());
                dgvStockDetails.Rows[n].Cells[1].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[1].ToString());
                dgvStockDetails.Rows[n].Cells[2].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[4].ToString());
                dgvStockDetails.Rows[n].Cells[3].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[2].ToString());
                dgvStockDetails.Rows[n].Cells[4].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[3].ToString());
                dgvStockDetails.Rows[n].Cells[5].Value = (frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[5].ToString());
                currentRow++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvStockDetails.Rows.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dgvStockDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvStockDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }

        private void dgvStockDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            
            StockItemId = dgvStockDetails.CurrentRow.Cells[0].Value.ToString();
            ItemName = dgvStockDetails.CurrentRow.Cells[1].Value.ToString();
            ItemCategory = dgvStockDetails.CurrentRow.Cells[2].Value.ToString();
            ItemRate = dgvStockDetails.CurrentRow.Cells[3].Value.ToString();
            Quentity = dgvStockDetails.CurrentRow.Cells[4].Value.ToString();

            frmUpdateStockDetails UpdateStockDetails = new frmUpdateStockDetails();
            UpdateStockDetails.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "UPDATE tblStock SET Status='"+"Active"+"' WHERE StockItemId = '" + Convert.ToInt32(dgvStockDetails.CurrentRow.Cells[0].Value.ToString()) + "'";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();

            
        }

        private void btnStockIssueDetails_MouseHover(object sender, EventArgs e)
        {
            btnStockIssueDetails.BackgroundImage = Properties.Resources.StockIssureLight;
        }

        private void btnStockIssueDetails_MouseLeave(object sender, EventArgs e)
        {
            btnStockIssueDetails.BackgroundImage = Properties.Resources.StockIssure;
        }

        private void btnStockIssueDetails_Click(object sender, EventArgs e)
        {
            frmStockIssue StockIssue = new frmStockIssue();
            StockIssue.ShowDialog();
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "UPDATE tblStock SET Status='" + "Inactive" + "' WHERE StockItemId = '" + Convert.ToInt32(dgvStockDetails.CurrentRow.Cells[0].Value.ToString()) + "'";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();
        }
    }
}
