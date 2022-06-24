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
        public string food;
        public string customer;

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
                this.food = sqlDataReader.GetInt32(1).ToString();
                txt_food.Text = foodManagement.getFoodById(this.food);
                this.customer = sqlDataReader.GetInt32(4).ToString();
                txt_customer.Text = customerManagement.getCustomerById(this.customer);
                txt_IdInputInfo.Text = sqlDataReader.GetInt32(3).ToString();
                txt_OutputPrice.Text = sqlDataReader.GetDouble(6).ToString();
                txt_CountOutput.Text = sqlDataReader.GetInt32(5).ToString();
                status_OutputInfo.Text = sqlDataReader.GetString(7);


            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {


        }

        private void txt_customer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
