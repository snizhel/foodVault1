using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;

namespace PresentationLayer
{
    public partial class FrmFoodManagement : Form
    {

        FoodManagement mngFood = new FoodManagement();
        BindingSource bs;
        public FrmFoodManagement()
        {
            InitializeComponent();
        }

        private void FrmFoodManagement_Load(object sender, EventArgs e)
        {
            DataSet ds = mngFood.ViewFoods();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_Food.DataSource = bs;
        }

       

        private void txt_idfood_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_idfood.Text))
            {
                errorProvider1.SetError(txt_idfood, "ID is not left blank!");
            }
            else if (mngFood.isExistIdFood(txt_idfood.Text))
            {
                errorProvider1.SetError(txt_idfood, "ID existed!!!");
            }
            else
            {
                errorProvider1.SetError(txt_idfood, null);
                e.Cancel = false;
            }
        }
        
        private void txt_namefood_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_namefood.Text))
            {
                errorProvider1.SetError(txt_namefood, "Name Food is not left blank!");
            }
            else
            {
                errorProvider1.SetError(txt_namefood, null);
                e.Cancel = false;
            }
        }

        private void txt_quantity_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_quantity.Text))
            {
                errorProvider1.SetError(txt_quantity, "Quantity is not left blank!");
            }
            else
            {
                errorProvider1.SetError(txt_quantity, null);
                e.Cancel = false;
            }
        }
        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txt_idsuplier_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_idsuplier.Text))
            {
                errorProvider1.SetError(txt_idsuplier, "ID Suplier is not left blank!");
            }
            else
            {
                errorProvider1.SetError(txt_idsuplier, null);
                e.Cancel = false;
            }
        }
        private void txt_idsuplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
