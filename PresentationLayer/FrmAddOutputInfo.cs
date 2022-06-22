using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmAddOutputInfo : Form
    {
        OutputInfoManagement outputInfoManagement = new OutputInfoManagement();

        private readonly FrmFoodManagement frmFoodManagement1;

        public FrmAddOutputInfo(FrmFoodManagement frmFoodManagement)
        {
            InitializeComponent();
            frmFoodManagement1 = frmFoodManagement;
        }

        private void FrmAddOutputInfo_Load(object sender, EventArgs e)
        {
            loadOutputInfoDetail();
        }
        private void loadOutputInfoDetail()
        {
            SqlDataReader drOutputInfo = outputInfoManagement.getDatails(FrmFoodManagement.outputInfoId);
            if (drOutputInfo.Read())
            {
                txt_IdFood.Text = drOutputInfo.GetInt32(1).ToString();
                txt_IdOutput.Text = drOutputInfo.GetInt32(2).ToString();
                txt_IdInputInfo.Text = drOutputInfo.GetInt32(3).ToString();
                txt_IdCustomer.Text = drOutputInfo.GetInt32(4).ToString();
                txt_CountOutput.Text = drOutputInfo.GetInt32(5).ToString();
                txt_OutputPrice.Text = drOutputInfo.GetValue(6).ToString();
                txt_StatusOutput.Text = drOutputInfo.GetString(7);
            }
            outputInfoManagement.closeConnection();
        }

        private void btn_OutputSave_Click(object sender, EventArgs e)
        {
            OutputInfo outputInfo = new OutputInfo()
            {
                IdFood = int.Parse(txt_IdFood.Text.Trim()),
                IdOutput = int.Parse(txt_IdOutput.Text.Trim()),
                IdInputInfo = int.Parse(txt_IdInputInfo.Text.Trim()),
                IdCustomer = int.Parse(txt_IdCustomer.Text.Trim()),
                CountOutput = int.Parse(txt_CountOutput.Text.Trim()),
                OutputPrice = float.Parse(txt_OutputPrice.Text.Trim()),
                StatusOutput = txt_StatusOutput.Text.Trim(),

            };
            int result = outputInfoManagement.AddOutputInfo(outputInfo);
            if (result < 0)
            {
                Status.Text = "Save error!!!";
            }
            else
            {
                Status.Text = "Create successfully !!!";
            }
            frmFoodManagement1.loadOutputInfoData();
        }

        private void btn_CloseFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
