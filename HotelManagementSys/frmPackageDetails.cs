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
    public partial class frmPackageDetails : Form
    {
        public frmPackageDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            frmKitchen Kitchen = new frmKitchen();
            Kitchen.ShowDialog();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            frmRooms Rooms = new frmRooms();
            Rooms.ShowDialog();
        }

        private void btnKitchen_MouseHover(object sender, EventArgs e)
        {
            btnKitchen.BackgroundImage = Properties.Resources.KitchenLighrt;
        }

        private void btnKitchen_MouseLeave(object sender, EventArgs e)
        {
            btnKitchen.BackgroundImage = Properties.Resources.KitchenNormal;

        }

        private void btnRooms_MouseHover(object sender, EventArgs e)
        {
            btnRooms.BackgroundImage = Properties.Resources.RoomsLight;
        }

        private void btnRooms_MouseLeave(object sender, EventArgs e)
        {
            btnRooms.BackgroundImage = Properties.Resources.RoomsNormal;
        }

        private void btnBar_MouseHover(object sender, EventArgs e)
        {
            btnBar.BackgroundImage = Properties.Resources.barLight;
        }

        private void btnBar_MouseLeave(object sender, EventArgs e)
        {
            btnBar.BackgroundImage = Properties.Resources.BarNormal;
        }

        private void btnPool_MouseHover(object sender, EventArgs e)
        {
            btnPool.BackgroundImage = Properties.Resources.PoolLight;
        }

        private void btnPool_MouseLeave(object sender, EventArgs e)
        {
            btnPool.BackgroundImage = Properties.Resources.PoolNormal;
        }

        private void btnWedding_MouseHover(object sender, EventArgs e)
        {
            btnWedding.BackgroundImage = Properties.Resources.WeddingLight;
        }

        private void btnWedding_MouseLeave(object sender, EventArgs e)
        {
            btnWedding.BackgroundImage = Properties.Resources.WeddingNormal;
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            frmBar Bar = new frmBar();
            Bar.ShowDialog();
        }

        private void btnPool_Click(object sender, EventArgs e)
        {
            frmPool Pool = new frmPool();
            Pool.ShowDialog();
        }
    }
}
