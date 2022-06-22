using BussinessLogicLayer_BLL;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmFoodManagement : Form
    {

        FoodManagement foodManagement = new FoodManagement();
        CustomerManagement customerManagement = new CustomerManagement();
        OutputManagement outputManagement = new OutputManagement();
        OutputInfoManagement outputInfoManagement = new OutputInfoManagement();
        SupilerManagement supilerManagement = new SupilerManagement();
        InputManagement inputManagement = new InputManagement();
        InputInfoManagement inputInfoManagement = new InputInfoManagement();



        BindingSource bindingFoodData = new BindingSource();
        BindingSource bindingCustomerData = new BindingSource();
        BindingSource bindingOutputData = new BindingSource();
        BindingSource bindingOutputInfoData = new BindingSource();
        BindingSource bindingSuplierData = new BindingSource();
        BindingSource bindingInputData = new BindingSource();


        //Init variable
        public static int customerId;
        public static int outputId;
        public static int outputInfoId;
        public static int suplierId;
        public static int inputId;
        public static int inputInfoId;
        public static int foodId;

        public FrmFoodManagement()
        {
            InitializeComponent();
        }

        private void FrmFoodManagement_Load(object sender, EventArgs e)
        {
            loadFoodData();
            loadCustomerData();
            loadOutputData();
            loadOutputInfoData();
            loadSuplierData();
            loadInputData();

        }
        //Tabs Food
        public void loadFoodData()
        {
            DataSet ds = foodManagement.ViewFoods();
            bindingFoodData = new BindingSource();
            bindingFoodData.DataSource = ds.Tables[0];
            gv_Food.DataSource = bindingFoodData;
        }
        private void lbl_searchFood_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_searchFood.Text.Trim() == "")
            {
                ds = foodManagement.searchByName(txt_searchFood.Text);
            }
            else
            {
                ds = foodManagement.searchByName(txt_searchFood.Text);
            }

            bindingFoodData.DataSource = ds.Tables[0];
            gv_Food.DataSource = bindingFoodData;
        }
        private void gv_Food_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_Food.SelectedRows.Count > 0)
            {
                foodId = int.Parse(gv_Food.SelectedRows[0].Cells["FoodId"].Value.ToString());
                pic_FoodImage.Image = Image.FromFile(gv_Food.SelectedRows[0].Cells["Image"].Value.ToString());
                txt_FilePath.Text = gv_Food.SelectedRows[0].Cells["Image"].Value.ToString();
                txt_idfood.Text = gv_Food.SelectedRows[0].Cells["FoodId"].Value.ToString();
                txt_namefood.Text = gv_Food.SelectedRows[0].Cells["DisplayNameFood"].Value.ToString();
                txt_quantity.Text = gv_Food.SelectedRows[0].Cells["Quantity"].Value.ToString();
                txt_idsuplier.Text = gv_Food.SelectedRows[0].Cells["IDSuplier"].Value.ToString();
                date_start.Value = DateTime.Parse(gv_Food.SelectedRows[0].Cells["DateOfManufacture"].Value.ToString());
                date_end.Value = DateTime.Parse(gv_Food.SelectedRows[0].Cells["ExpirationDate"].Value.ToString());
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            //Food food = new Food()
            //{
            //    //FoodId = 0,
            //    DisplayNameFood = txt_namefood.Text,
            //    Quantity = int.Parse(txt_quantity.Text),
            //    Image = "1.png",
            //    IDSuplier = int.Parse(txt_idsuplier.Text),
            //    StartDate = date_start.Value,
            //    EndDate = date_end.Value

            //};
            //int result = foodManagement.AddFood(food);
            //if (result < 0)
            //{
            //    Status.Text = "Food have inventory!!!";
            //}
            //else
            //{
            //    Status.Text = "Add done !!!";
            //}
            //loadFoodData();

            FrmAddFood frmAddFood = new FrmAddFood(this);
            frmAddFood.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Food food = new Food()
            //{
            //    FoodId = int.Parse(txt_idfood.Text.Trim()),
            //    DisplayNameFood = txt_namefood.Text.Trim(),
            //    Quantity = int.Parse(txt_quantity.Text.Trim()),
            //    Image = "1.png",
            //    IDSuplier = int.Parse(txt_idsuplier.Text.Trim()),
            //    StartDate = date_start.Value,
            //    EndDate = date_end.Value

            //};
            //int result = foodManagement.UpdateFood(food);
            //if (result < 0)
            //{
            //    Status.Text = "Food have inventory!!!";
            //}
            //else
            //{
            //    Status.Text = "Update done !!!";
            //}
            //loadFoodData();

            FrmUpdateFood frmUpdateFood = new FrmUpdateFood(this);
            frmUpdateFood.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "CONFIRMATION", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                int result = foodManagement.RemoveFood(foodId);

                if (result < 0)
                {
                    MessageBox.Show("Can not delete Item!");
                }
                else
                {
                    loadFoodData();
                    MessageBox.Show("Successful!");
                }
            }
            else MessageBox.Show("Nothing be changed!");


            //int result = foodManagement.RemoveFood(int.Parse(txt_idfood.Text.Trim()));
            //if (result < 0)
            //{
            //    Status.Text = "Food have inventory!!!";
            //}
            //else
            //{
            //    Status.Text = "Delete done !!!";
            //}

            //loadFoodData();
        }







        //Tabs Suplier
        public void loadSuplierData()
        {
            DataSet ds = supilerManagement.ViewSupilers();
            bindingSuplierData.DataSource = ds.Tables[0];
            gv_SuplierDataSource.DataSource = bindingSuplierData;
        }

        private void loadFoodDataSuplierTabs()
        {
            BindingSource bindingSource = new BindingSource();
            DataSet dsFood = foodManagement.listFoodById(suplierId);
            bindingSource.DataSource = dsFood.Tables[0];
            gv_SuplierTabsFoodData.DataSource = bindingSource;
        }


        private void gv_SuplierDataSource_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_SuplierDataSource.SelectedRows.Count > 0)
            {
                suplierId = int.Parse(gv_SuplierDataSource.SelectedRows[0].Cells["Id"].Value.ToString());
                loadFoodDataSuplierTabs();
            }
        }

        private void btn_AddSuplier_Click(object sender, EventArgs e)
        {
            FrmAddSuplier frmAddSuplier = new FrmAddSuplier(this);
            frmAddSuplier.Show();
        }

        private void btn_UpdateSuplier_Click(object sender, EventArgs e)
        {
            FrmUpdateSuplier frmUpdateSuplier = new FrmUpdateSuplier(this);
            frmUpdateSuplier.Show();
        }

        private void btn_DeleteSuplier_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete?", "CONFIRMATION", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                int result = supilerManagement.DeleteSuplier(suplierId);
                if (result < 0)
                {
                    MessageBox.Show("Can not delete Item!");
                }
                else
                {
                    loadSuplierData();
                    MessageBox.Show("Successful!");
                }
            }
            else MessageBox.Show("Nothing be changed!");
        }

        private void btn_SearchSuplier_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_SearchSuplier.Text.Trim() == "")
            {
                ds = supilerManagement.searchByName(txt_SearchSuplier.Text);
            }
            else
            {
                ds = supilerManagement.searchByName(txt_SearchSuplier.Text);
            }

            bindingSuplierData.DataSource = ds.Tables[0];
            gv_SuplierDataSource.DataSource = bindingSuplierData;
        }




        //Tabs Customer
        public void loadCustomerData()
        {
            DataSet ds = customerManagement.ViewCustomers();
            bindingCustomerData.DataSource = ds.Tables[0];
            gv_CustomerDataSource.DataSource = bindingCustomerData;
        }

        private void loadOutputInfoDataCustomerTabs()
        {
            BindingSource bindingSource = new BindingSource();
            DataSet dsOutputInfo = outputInfoManagement.listOutputInfoById(customerId);
            bindingSource.DataSource = dsOutputInfo.Tables[0];
            gv_CustomerTabsOutputInfoData.DataSource = bindingSource;
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer(this);
            frmAddCustomer.Show();
        }

        private void gv_CustomerDataSource_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_CustomerDataSource.SelectedRows.Count > 0)
            {
                customerId = int.Parse(gv_CustomerDataSource.SelectedRows[0].Cells["CustomerId"].Value.ToString());

                loadOutputInfoDataCustomerTabs();
            }
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            FrmUpdateCustomer frmUpdateSuplier = new FrmUpdateCustomer(this);
            frmUpdateSuplier.Show();
        }

        private void lbl_searchCustomer_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_searchCustomer.Text.Trim() == "")
            {
                ds = customerManagement.searchByName(txt_searchCustomer.Text);
            }
            else
            {
                ds = customerManagement.searchByName(txt_searchCustomer.Text);
            }

            bindingCustomerData.DataSource = ds.Tables[0];
            gv_CustomerDataSource.DataSource = bindingCustomerData;
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            int result = customerManagement.RemoveCustomer(customerId);
            if (result < 0)
            {
                Status.Text = "Customers have inventory!!!";
            }
            else
            {
                Status.Text = "Delete done !!!";
            }
            loadCustomerData();
        }

        //Tabs Input 
        public void loadInputData()
        {
            DataSet ds = inputManagement.ViewInputs();
            bindingInputData.DataSource = ds.Tables[0];
            gv_InputDataSource.DataSource = bindingInputData;
        }

        private void gv_InputDataSource_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_InputDataSource.SelectedRows.Count > 0)
            {
                inputId = int.Parse(gv_InputDataSource.SelectedRows[0].Cells["InputId"].Value.ToString());
                loadInputInfoData();
            }
        }



        //Input Info
        public void loadInputInfoData()
        {
            BindingSource bindingSource = new BindingSource();
            DataSet dsInputInfo = inputInfoManagement.listInfoByInputId(inputId);
            bindingSource.DataSource = dsInputInfo.Tables[0];
            gv_InputInfo.DataSource = bindingSource;
        }

        private void gv_InputInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_InputInfo.SelectedRows.Count > 0)
            {
                inputInfoId = int.Parse(gv_InputInfo.SelectedRows[0].Cells["Id"].Value.ToString());
            }
        }

        private void btn_ViewInputInfo_Click(object sender, EventArgs e)
        {
            FrmInputInfoDetails frmInputInfoDetails = new FrmInputInfoDetails(this);
            frmInputInfoDetails.Show();
        }



        //Tabs Output
        public void loadOutputData()
        {
            DataSet ds = outputManagement.ViewOutput();
            bindingOutputData.DataSource = ds.Tables[0];
            gv_Output.DataSource = bindingOutputData;
        }
        private void lbl_searchOutput_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_searchOutput.Text.Trim() == "")
            {
                ds = outputManagement.searchByName(txt_searchOutput.Text);
            }
            else
            {
                ds = outputManagement.searchByName(txt_searchOutput.Text);
            }

            bindingOutputData.DataSource = ds.Tables[0];
            gv_Output.DataSource = bindingOutputData;
        }
        private void gv_Output_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_Output.SelectedRows.Count > 0)
            {
                outputId = int.Parse(gv_Output.SelectedRows[0].Cells["OutputId"].Value.ToString());
            }
        }
        private void btn_addOutput_Click(object sender, EventArgs e)
        {
            FrmAddOutput frmAddOutput = new FrmAddOutput(this);
            frmAddOutput.Show();
        }

        private void btn_updateOutput_Click(object sender, EventArgs e)
        {
            FrmUpdateOutput frmUpdateOutput = new FrmUpdateOutput(this);
            frmUpdateOutput.Show();
        }
        private void btn_deleteOutput_Click(object sender, EventArgs e)
        {
            int result = outputManagement.RemoveOutput(outputId);
            if (result < 0)
            {
                Status.Text = "Delete Fail!!!";
            }
            else
            {
                Status.Text = "Delete Done !!!";
            }
            loadOutputData();
        }
        //Tabs OutputInfo
        public void loadOutputInfoData()
        {
            DataSet ds = outputInfoManagement.ViewOutputInfo();
            bindingOutputInfoData.DataSource = ds.Tables[0];
            gv_OutputInfo.DataSource = bindingOutputInfoData;
        }
        private void lbl_searchOutputInfo_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_searchOutputInfo.Text.Trim() == "")
            {
                ds = outputInfoManagement.searchByName(txt_searchOutputInfo.Text);
            }
            else
            {
                ds = outputInfoManagement.searchByName(txt_searchOutputInfo.Text);
            }

            bindingOutputInfoData.DataSource = ds.Tables[0];
            gv_OutputInfo.DataSource = bindingOutputInfoData;
        }
        private void gv_OutputInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_OutputInfo.SelectedRows.Count > 0)
            {
                outputInfoId = int.Parse(gv_OutputInfo.SelectedRows[0].Cells["Id"].Value.ToString());
            }
        }
        private void btn_addOutputInfo_Click(object sender, EventArgs e)
        {
            FrmAddOutputInfo frmAddOutputInfo = new FrmAddOutputInfo(this);
            frmAddOutputInfo.Show();
        }

        private void btn_updateOutputInfo_Click(object sender, EventArgs e)
        {
            FrmUpdateOutputInfo frmUpdateOutputInfo = new FrmUpdateOutputInfo(this);
            frmUpdateOutputInfo.Show();
        }

        private void btn_deleteOutputInfo_Click(object sender, EventArgs e)
        {
            int result = outputInfoManagement.RemoveOutputInfo(outputId);
            if (result < 0)
            {
                Status.Text = "Delete Fail!!!";
            }
            else
            {
                Status.Text = "Delete Done !!!";
            }
            loadOutputInfoData();
        }

        private void txt_idfood_Validating(object sender, CancelEventArgs e)
        {
            //e.Cancel = true;
            //if (string.IsNullOrEmpty(txt_idfood.Text))
            //{
            //    errorProvider1.SetError(txt_idfood, "ID is not left blank!");
            //}
            //else if (foodManagement.isExistIdFood(txt_idfood.Text))
            //{
            //    errorProvider1.SetError(txt_idfood, "ID existed!!!");
            //}
            //else
            //{
            //    errorProvider1.SetError(txt_idfood, null);
            //    e.Cancel = false;
            //}
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











        //
    }
}
