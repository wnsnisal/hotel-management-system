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
    public partial class frmMealItemReport : Form
    {
        public frmMealItemReport()
        {
            InitializeComponent();
        }

        private void frmMealItemReport_Load(object sender, EventArgs e)
        {
            frmMain.DS1.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT DISTINCT Category FROM tblKitchen", frmMain.con);
            frmMain.da.Fill(frmMain.DS1, "tblKitchen");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS1.Tables["tblKitchen"].Rows.Count;
            while (currentRow < rowCount)
            {
                cmbCategoryReport.Items.Add(frmMain.DS1.Tables["tblKitchen"].Rows[currentRow].ItemArray[0].ToString());
                currentRow++;
            }
        }

        private void cmbCategoryReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMeals.Rows.Clear();

            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblKitchen", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblKitchen");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS.Tables["tblKitchen"].Rows.Count;
            while (currentRow < rowCount)
            {
                if(cmbCategoryReport.SelectedItem.ToString() == frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[2].ToString())
                {
                    int n = dgvMeals.Rows.Add();
                    dgvMeals.Rows[n].Cells[0].Value = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[0].ToString();
                    dgvMeals.Rows[n].Cells[1].Value = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[1].ToString();
                    dgvMeals.Rows[n].Cells[2].Value = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[2].ToString();
                    dgvMeals.Rows[n].Cells[3].Value = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[3].ToString();
                }
                else if(cmbCategoryReport.SelectedItem.ToString() == "All")
                {

                    int n = dgvMeals.Rows.Add();
                    dgvMeals.Rows[n].Cells[0].Value = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[0].ToString();
                    dgvMeals.Rows[n].Cells[1].Value = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[1].ToString();
                    dgvMeals.Rows[n].Cells[2].Value = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[2].ToString();
                    dgvMeals.Rows[n].Cells[3].Value = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[3].ToString();
                }
                currentRow++;
            }
        }
    }
}
