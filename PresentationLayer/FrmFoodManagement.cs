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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
