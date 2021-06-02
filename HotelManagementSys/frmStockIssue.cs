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
    public partial class frmStockIssue : Form
    {
        
        public frmStockIssue()
        {
            InitializeComponent();
        }

        private void lblQuentity_Click(object sender, EventArgs e)
        {

        }

        private void btnIssue_MouseHover(object sender, EventArgs e)
        {
            btnIssue.BackgroundImage = Properties.Resources.IssueLight;
        }

        private void btnIssue_MouseLeave(object sender, EventArgs e)
        {
            btnIssue.BackgroundImage = Properties.Resources.IssueNormal;
        }

        private void btnNewIssue_Click(object sender, EventArgs e)
        {
            pnlIssueItem.Enabled = true;
        }

        private void frmStockIssue_Load(object sender, EventArgs e)
        {
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "MMM/yyyy";

            dtpStockIssueDate.Format = DateTimePickerFormat.Custom;
            dtpStockIssueDate.CustomFormat = "dd/MMM/yyyy";

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
                lstItemList.Items.Add(frmMain.DS.Tables["tblStock"].Rows[currentRow].ItemArray[1].ToString());
                currentRow++;
            }

            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStockIssue", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblStockIssue");
            frmMain.con.Close();

            int currentRow1 = 0;
            int rowCount1 = frmMain.DS.Tables["tblStockIssue"].Rows.Count;
            while (currentRow1 < rowCount1)
            {
                txtStockIssueId.Text = Convert.ToString(Convert.ToInt32(frmMain.DS.Tables["tblStockIssue"].Rows[currentRow1].ItemArray[0].ToString()) + 1);
                currentRow1++;
            }

            
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtQuentity.Text == "" || cmbDepartment.Text == "Select")
                {
                    MessageBox.Show("please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    


                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblStockIssue (StockIssueId,ItemName,Quentity,IssueDepartment,IssueMonth) VALUES('" + Convert.ToInt32(txtStockIssueId.Text) + "','" + txtItemName.Text + "','" + txtQuentity.Text + "','" + cmbDepartment.Text + "','" + dtpStockIssueDate.Text + "')";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    MessageBox.Show("Sucess", "infrmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtItemName.Text = "";
                    txtQuentity.Text = "";
                    cmbDepartment.Text = "Select";
                    dtpStockIssueDate.Value = DateTime.Now.Date;
                }
                
            }
            catch
            {
                MessageBox.Show("Invalied input, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void lstItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStockIssue", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblStockIssue");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS.Tables["tblStockIssue"].Rows.Count;
            while (currentRow < rowCount)
            {
                txtItemName.Text = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[1].ToString();
                currentRow++;
            }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            txtQuentity.Text = "";
            cmbDepartment.Text = "Select";
            dtpStockIssueDate.Value = DateTime.Now.Date;

            pnlIssueItem.Enabled = false;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStockIssue", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblStockIssue");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS.Tables["tblStockIssue"].Rows.Count;
            while (currentRow < rowCount)
            {
                int n = dgvStockIssueDetails.Rows.Add();
                dgvStockIssueDetails.Rows[n].Cells[0].Value = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[0].ToString();
                dgvStockIssueDetails.Rows[n].Cells[1].Value = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[1].ToString();
                dgvStockIssueDetails.Rows[n].Cells[2].Value = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[2].ToString();
                dgvStockIssueDetails.Rows[n].Cells[3].Value = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[3].ToString();
                dgvStockIssueDetails.Rows[n].Cells[4].Value = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[4].ToString();
                currentRow++;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                frmMain.DS.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStockIssue", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblStockIssue");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblStockIssue"].Rows.Count;
                while (currentRow < rowCount)
                {
                    
                    string NowDate = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[4].ToString();
                    int x = NowDate.LastIndexOf("/") - 3;
                    string IssueMonth = NowDate.Substring(x, 8);

                    if (dtpMonth.Text == IssueMonth)
                    {
                        int n = dgvStockIssueDetails.Rows.Add();
                        dgvStockIssueDetails.Rows[n].Cells[0].Value = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[0].ToString();
                        dgvStockIssueDetails.Rows[n].Cells[1].Value = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[1].ToString();
                        dgvStockIssueDetails.Rows[n].Cells[2].Value = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[2].ToString();
                        dgvStockIssueDetails.Rows[n].Cells[3].Value = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[3].ToString();
                        dgvStockIssueDetails.Rows[n].Cells[4].Value = frmMain.DS.Tables["tblStockIssue"].Rows[currentRow].ItemArray[4].ToString();
                        
                    }

                        currentRow++;

                    }
                
            
                
            }
            catch
            {
                MessageBox.Show("Invalied month, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}
