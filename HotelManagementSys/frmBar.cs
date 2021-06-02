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
    public partial class frmBar : Form
    {
        public frmBar()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            pnlAddItem.Enabled = true;

            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblBar", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblBar");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS.Tables["tblBar"].Rows.Count;
            while (currentRow < rowCount)
            {
                txtItemIdAdd.Text = Convert.ToString(Convert.ToInt32(frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[0].ToString()) + 1);
                
                currentRow++;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemNameAdd.Text == "" || txtPriceAdd.Text == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtItemNameAdd.Text.Length == 50)
                {
                    MessageBox.Show("Maximum length of Item name is 50 latters, Please try agan", "infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblBar (BarItemId, ItemName, price, Status) VALUES(" + Convert.ToInt32(txtItemIdAdd.Text) + ",'" + txtItemNameAdd.Text + "','" + Convert.ToDouble(txtPriceAdd.Text) + "','" + "Available" + "')";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    MessageBox.Show("Secuss", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Invalied input, Plese try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            txtItemIdAdd.Text = "";
            txtItemNameAdd.Text = "";
            txtPriceAdd.Text = "";
        }

        private void cmbSearchItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lstViweItem.Items.Clear();

                frmMain.DS.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblBar", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblBar");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblBar"].Rows.Count;
                while (currentRow < rowCount)
                {

                    if (frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[1].ToString().Contains(txtItemSearch.Text))
                    {
                        lstViweItem.Items.Add(frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[1].ToString());
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

        private void lstViweItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvItemViwe.Rows.Clear();

                frmMain.DS.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblBar", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblBar");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblBar"].Rows.Count;
                while (currentRow < rowCount)
                {
                    if (lstViweItem.SelectedItem.ToString() == frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[1].ToString())
                    {
                        int n = dgvItemViwe.Rows.Add();
                        dgvItemViwe.Rows[n].Cells[0].Value = (frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[0].ToString());
                        dgvItemViwe.Rows[n].Cells[1].Value = (frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[1].ToString());
                        dgvItemViwe.Rows[n].Cells[2].Value = (frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[2].ToString());
                        dgvItemViwe.Rows[n].Cells[3].Value = (frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[3].ToString());
                        
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                dgvItemViwe.Rows.Clear();

                frmMain.DS.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblBar", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblBar");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblBar"].Rows.Count;
                while (currentRow < rowCount)
                {
                    int n = dgvItemViwe.Rows.Add();
                    dgvItemViwe.Rows[n].Cells[0].Value = (frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[0].ToString());
                    dgvItemViwe.Rows[n].Cells[1].Value = (frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[1].ToString());
                    dgvItemViwe.Rows[n].Cells[2].Value = (frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[2].ToString());
                    dgvItemViwe.Rows[n].Cells[3].Value = (frmMain.DS.Tables["tblBar"].Rows[currentRow].ItemArray[3].ToString());
                    currentRow++;
                }
            }
            catch
            {
                MessageBox.Show("Please select the item name", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemViwe.CurrentRow.Cells[1].Value.ToString() == "" || dgvItemViwe.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "UPDATE tblBar SET ItemName = '" + dgvItemViwe.CurrentRow.Cells[1].Value.ToString() + "', price = '" + dgvItemViwe.CurrentRow.Cells[2].Value.ToString() + "' WHERE BarItemId = '" + dgvItemViwe.CurrentRow.Cells[0].Value.ToString() + "'";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    MessageBox.Show("Sucess", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            catch
            {
                MessageBox.Show("Invalide input, Please try agan", "infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEnembleItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemViwe.CurrentRow.Cells[1].Value.ToString() == "" || dgvItemViwe.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "UPDATE tblBar SET Status = '" + "Available" +"' WHERE BarItemId = '" + dgvItemViwe.CurrentRow.Cells[0].Value.ToString() + "'";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    dgvItemViwe.CurrentRow.Cells[3].Value = "Available";

                }

            }
            catch
            {
                MessageBox.Show("Invalide input, Please try agan", "infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDisableItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemViwe.CurrentRow.Cells[1].Value.ToString() == "" || dgvItemViwe.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "UPDATE tblBar SET Status = '" + "Unavailable" + "' WHERE BarItemId = '" + dgvItemViwe.CurrentRow.Cells[0].Value.ToString() + "'";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    dgvItemViwe.CurrentRow.Cells[3].Value = "Unavailable";

                }

            }
            catch
            {
                MessageBox.Show("Invalide input, Please try agan", "infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
