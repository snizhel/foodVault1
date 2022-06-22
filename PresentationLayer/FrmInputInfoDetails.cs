using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmInputInfoDetails : Form
    {
        private readonly FrmFoodManagement frmFoodManagement1;


        InputInfoManagement inputInfoManagement = new InputInfoManagement();

        public FrmInputInfoDetails(FrmFoodManagement frmFoodManagement)
        {
            InitializeComponent();
            frmFoodManagement1 = frmFoodManagement;

        }

        private void FrmInputInfoDetails_Load(object sender, EventArgs e)
        {
            loadInputInfoData();
        }

        private void loadInputInfoData()
        {
            SqlDataReader drInfo = inputInfoManagement.getDatails(FrmFoodManagement.inputInfoId.ToString());
            if (drInfo.Read())
            {
                txt_IdBilling.Text = drInfo.GetInt32(0).ToString();
                txt_IdFood.Text = drInfo.GetInt32(1).ToString();
                txt_IdInput.Text = drInfo.GetInt32(2).ToString();
                txt_CountInput.Text = drInfo.GetInt32(3).ToString();
                //txt_InputPrice.Text = drInfo.GetInt32(4);

            }
            inputInfoManagement.closeConnection();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string selected = cb_Status.SelectedItem.ToString();


            InputInfo inputInfo = new InputInfo()
            {

                Id = FrmFoodManagement.inputInfoId,
                StatusInput = selected

            };
            int result = inputInfoManagement.UpdateInputInfo(inputInfo);
            if (result < 0)
            {
                toolStripStatusLabel1.Text = "Fails!!!";
            }
            else
            {
                toolStripStatusLabel1.Text = "Update done !!!";
            }
            frmFoodManagement1.loadInputInfoData();
        }
    }
}
