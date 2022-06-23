using BussinessLogicLayer_BLL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmOutputInfoDetail : Form

    {
        CustomerManagement customerManagement = new CustomerManagement();
        InputManagement inputManagement = new InputManagement();
        FoodManagement foodManagement = new FoodManagement();
        InputInfoManagement infoManagement = new InputInfoManagement();
        OutputInfoManagement outputInfo = new OutputInfoManagement();

        public FrmOutputInfoDetail(FrmFoodManagement frmFoodManagement)
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {



        }

        private void FrmOutputInfoDetail_Load(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader = outputInfo.getDatails(FrmFoodManagement.outputInfoId);
            if (sqlDataReader.Read())
            {
                txt_Id.Text = sqlDataReader.GetInt32(0).ToString();
                string food = sqlDataReader.GetInt32(1).ToString();
                txt_food.Text = foodManagement.getDatails(food).ToString();
                txt_IdInputInfo.Text = sqlDataReader.GetInt32(2).ToString();
                txt_OutputPrice.Text = sqlDataReader.GetInt32(3).ToString();


            }
        }
    }
}
