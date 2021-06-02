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
    public partial class frmKitchen : Form
    {
        
        public frmKitchen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
            pnlAddMeal.Enabled = true;

            

            frmMain.DS1.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT DISTINCT Category FROM tblKitchen", frmMain.con);
            frmMain.da.Fill(frmMain.DS1,"tblKitchen");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.DS1.Tables["tblKitchen"].Rows.Count;
            while (currentRow < rowCount)
            {
                cmbCategoryAdd.Items.Add(frmMain.DS1.Tables["tblKitchen"].Rows[currentRow].ItemArray[0].ToString());
                currentRow++;
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            pnlAddNewCategory.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewCategoryName.Text.Length >= 50)
                {
                    MessageBox.Show("Maximum text of category is 50", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else if(txtNewCategoryName.Text == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmbCategory.Items.Add(txtNewCategoryName.Text);
                    pnlAddNewCategory.Enabled = false;
                    txtNewCategoryName.Text = "";
                }
                
            }
            catch
            {
                MessageBox.Show("Invalied input,Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            txtMealNameAdd.Text = "";
            cmbCategoryAdd.Text = "Select";
            txtRateAdd.Text = "";
            pnlAddMeal.Enabled = false;
        }

        private void btnAddNewCategoryAdd_Click(object sender, EventArgs e)
        {
            pnlAddNewCategoryAdd.Enabled = true;
        }

        private void btnAddNewAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewCategoryNameAdd.Text.Length >= 50)
                {
                    MessageBox.Show("Maximum text of category is 50", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtNewCategoryNameAdd.Text == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmbCategoryAdd.Items.Add(txtNewCategoryNameAdd.Text);
                    pnlAddNewCategoryAdd.Enabled = false;
                    txtNewCategoryNameAdd.Text = "";
                }
                
            }
            catch
            {
                MessageBox.Show("Invalied input,Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmKitchen_Load(object sender, EventArgs e)
        {
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT MealItemId FROM tblKitchen", frmMain.con);
            frmMain.da.Fill(frmMain.DS, "tblKitchen");
            frmMain.con.Close();

            int currentRow1 = 0;
            int rowCount1 = frmMain.DS.Tables["tblKitchen"].Rows.Count;
            while (currentRow1 < rowCount1)
            {
                txtMealItemIdAdd.Text = Convert.ToString(Convert.ToInt32(frmMain.DS.Tables["tblKitchen"].Rows[currentRow1].ItemArray[0].ToString()) + 1);

                currentRow1++;
            }

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
                cmbCategory.Items.Add(frmMain.DS1.Tables["tblKitchen"].Rows[currentRow].ItemArray[0].ToString());
                cmbSearchCategory.Items.Add(frmMain.DS1.Tables["tblKitchen"].Rows[currentRow].ItemArray[0].ToString());
                currentRow++;
            }
        }

        private void btnCategoryCanselAdd_Click(object sender, EventArgs e)
        {
            txtNewCategoryNameAdd.Text = "";
            pnlAddNewCategoryAdd.Enabled = false;
        }

        private void btnCategoryCansel_Click(object sender, EventArgs e)
        {
            txtNewCategoryName.Text = "";
            pnlAddNewCategory.Enabled = false;
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = Properties.Resources.AddLight;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = Properties.Resources.AddNormal;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMealNameAdd.Text == "" || cmbCategoryAdd.Text == "Select" || txtRateAdd.Text == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtMealNameAdd.Text.Length >= 100)
                {
                    MessageBox.Show("Maximum length of ItemName is 100 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblKitchen (MealItemId,ItemName,Category,Rate) VALUES('" + txtMealItemIdAdd.Text + "','" + txtMealNameAdd.Text + "','" + cmbCategoryAdd.Text + "','" + txtRateAdd.Text + "')";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    MessageBox.Show("Sucess", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            catch
            {
                MessageBox.Show("Invalied input,Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstViweMeals.Items.Clear();
            try
            {
                frmMain.DS.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblKitchen WHERE Category = '" + cmbSearchCategory.Text + "'", frmMain.con);
                frmMain.da.Fill(frmMain.DS, "tblKitchen");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.DS.Tables["tblKitchen"].Rows.Count;
                while (currentRow < rowCount)
                {
                    lstViweMeals.Items.Add(frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[1].ToString());
                    currentRow++;
                }
            }
            catch
            {
                MessageBox.Show("Please select the Category", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void lstViweMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                if (lstViweMeals.SelectedItem.ToString() == frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[1].ToString())
                {
                    txtMealItemId.Text = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[0].ToString();
                    txtMealName.Text = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[1].ToString();
                    cmbCategory.Text = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[2].ToString();
                    txtRate.Text = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[3].ToString();
                    txtStatus.Text = frmMain.DS.Tables["tblKitchen"].Rows[currentRow].ItemArray[4].ToString();
                    
                    break;

                }
                currentRow++;
            }
        }

        private void btnReportOfMealItems_Click(object sender, EventArgs e)
        {
            frmMealItemReport MealItemReport = new frmMealItemReport();
            MealItemReport.ShowDialog();
        }

        private void btnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMealName.Text == "" || cmbCategory.Text == "Select" || txtRate.Text == "")
                {
                    MessageBox.Show("Please fill mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtMealName.Text.Length >= 100)
                {
                    MessageBox.Show("Maximum length of ItemName is 100 latters, Please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.DS.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "UPDATE tblKitchen SET ItemName = '"+txtMealName.Text+"',Category = '"+cmbCategory.Text+"',Rate = '"+Convert.ToInt32(txtRate.Text)+"', Status = '"+cmbCategory.Text+"'";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    MessageBox.Show("Sucess", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("invalide inputs please try agan", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "UPDATE tblKitchen SET Status = '" + "Disable"+ "' WHERE MealItemId = '"+Convert.ToInt32(txtMealItemId.Text)+"'";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();

            MessageBox.Show("Sucess", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveAndUpdate_MouseHover(object sender, EventArgs e)
        {
            btnSaveAndUpdate.BackgroundImage = Properties.Resources.button;
        }

        private void btnSaveAndUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnSaveAndUpdate.BackgroundImage = Properties.Resources.button_clear;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnSaveAndUpdate.BackgroundImage = Properties.Resources.button;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnSaveAndUpdate.BackgroundImage = Properties.Resources.button_clear;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            frmMain.DS.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "UPDATE tblKitchen SET Status = '" + "Enable" + "' WHERE MealItemId = '" + Convert.ToInt32(txtMealItemId.Text) + "'";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();

            MessageBox.Show("Sucess", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
