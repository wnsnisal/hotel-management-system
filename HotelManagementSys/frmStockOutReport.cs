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
    public partial class frmStockOutReport : Form
    {
        public frmStockOutReport()
        {
            InitializeComponent();
        }

        private void printStockOutReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }

        Bitmap bmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = pnlStockOutReport.CreateGraphics();
            bmp = new Bitmap(pnlStockOutReport.Size.Width, pnlStockOutReport.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(pnlStockOutReport.Location.X, pnlStockOutReport.Location.Y, 12, 12, pnlStockOutReport.Size);
            printStockOutReportPreviewDialog.ShowDialog();
        }
    }
}
