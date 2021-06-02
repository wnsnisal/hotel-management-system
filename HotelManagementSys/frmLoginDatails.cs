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
    public partial class frmLoginDatails : Form
    {
        public frmLoginDatails()
        {
            InitializeComponent();
        }

        private void frmLoginDatails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HotelHilroDataSet.tblLogin' table. You can move, or remove it, as needed.
            this.tblLoginTableAdapter.Fill(this.HotelHilroDataSet.tblLogin);

            this.reportViewer1.RefreshReport();
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            //btnPrint.BackgroundImage = Properties.Resources.NormalPrinter;
        }

        private void btnPrint_MouseLeave(object sender, EventArgs e)
        {
            //btnPrint.BackgroundImage = Properties.Resources.NormalPrinterSmall;
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            /*dgvLoginDetails.Rows.Clear();

            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblLogin", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblLogin");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS.Tables["tblLogin"].Rows.Count;
            while (currentRow < rowCount)
            {
                int n = dgvLoginDetails.Rows.Add();
                dgvLoginDetails.Rows[n].Cells[0].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[1].ToString();
                dgvLoginDetails.Rows[n].Cells[1].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString();
                dgvLoginDetails.Rows[n].Cells[2].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[3].ToString();
                dgvLoginDetails.Rows[n].Cells[3].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[4].ToString();
                dgvLoginDetails.Rows[n].Cells[4].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[5].ToString();
                dgvLoginDetails.Rows[n].Cells[5].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[6].ToString();
                currentRow++;
                if (currentRow > rowCount)
                {
                    break;
                }
            }*/
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*try
            {
                dgvLoginDetails.Rows.Clear();

                frmMain.DS.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblLogin WHERE LoginDate = '"+dtpLoginDate.Value+"'", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblLogin");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblLogin"].Rows.Count;
                while (currentRow < rowCount)
                {
                    int n = dgvLoginDetails.Rows.Add();
                    dgvLoginDetails.Rows[n].Cells[0].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[1].ToString();
                    dgvLoginDetails.Rows[n].Cells[1].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString();
                    dgvLoginDetails.Rows[n].Cells[2].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[3].ToString();
                    dgvLoginDetails.Rows[n].Cells[3].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[4].ToString();
                    dgvLoginDetails.Rows[n].Cells[4].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[5].ToString();
                    dgvLoginDetails.Rows[n].Cells[5].Value = frmMain.DS.Tables["tblLogin"].Rows[currentRow].ItemArray[6].ToString();
                    currentRow++;
                    if (currentRow > rowCount)
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalide date input,Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /*frmMain.DS.Clear();
            dgvLoginDetails.Rows.Clear();*/
        }

        private void dtpLoginDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
