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
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            //frmInvoice.DefaultBackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }
    }
}
