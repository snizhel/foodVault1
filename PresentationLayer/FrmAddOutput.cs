using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmAddOutput : Form
    {
        OutputManagement outputManagement = new OutputManagement();

        private readonly FrmFoodManagement frmFoodManagement1;

        public FrmAddOutput(FrmFoodManagement frmFoodManagement)
        {
            InitializeComponent();
            frmFoodManagement1 = frmFoodManagement;
        }

        private void FrmAddOutput_Load(object sender, EventArgs e)
        {
            loadOutputDetail();
        }
        private void loadOutputDetail()
        {
            SqlDataReader drOutput = outputManagement.getDatails(FrmFoodManagement.outputId.ToString());
            if (drOutput.Read())
            {
                dt_DataOutput.Value = drOutput.GetDateTime(1);
                txt_TotalPriceOutput.Text = drOutput.GetInt32(2).ToString();
            }
            outputManagement.closeConnection();
        }

        private void btn_OutputSave_Click(object sender, EventArgs e)
        {
            Output output = new Output()
            {
                DateOutput = dt_DataOutput.Value,
                TotalPrice = int.Parse(txt_TotalPriceOutput.Text.Trim()),
            };
            int result = outputManagement.AddOutput(output);
            if (result < 0)
            {
                Status.Text = "Save error!!!";
            }
            else
            {
                Status.Text = "Create successfully !!!";
            }
            frmFoodManagement1.loadOutputData();
        }

        private void btn_CloseFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
