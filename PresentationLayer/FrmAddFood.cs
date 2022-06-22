using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmAddFood : Form
    {
        private readonly FrmFoodManagement frmFoodManagement1;


        InputManagement inputManagement = new InputManagement();
        InputInfoManagement inputInfoManagement = new InputInfoManagement();
        SupilerManagement suplierManagement = new SupilerManagement();
        FoodManagement foodManagement = new FoodManagement();

        private static int countInputId;
        private static int countFoodId;
        private static int suplierId;

        private static string fileName;
        private static string rootPath;

        public FrmAddFood(FrmFoodManagement frmFoodManagement)
        {
            InitializeComponent();
            frmFoodManagement1 = frmFoodManagement;

        }

        private void FrmAddFood_Load(object sender, EventArgs e)
        {
            loadSuplier();
        }

        private void loadSuplier()
        {
            DataSet dataSet = suplierManagement.ViewSupilers();
            cb_Suplier.DataSource = dataSet.Tables[0];
            cb_Suplier.DisplayMember = "DisplayName";
            cb_Suplier.ValueMember = "Id";

        }

        private int returnNewestInputId()
        {
            DataSet dsInput = inputManagement.ViewInputs();
            foreach (DataRow dataRow in dsInput.Tables[0].Rows)
            {
                countInputId = Convert.ToInt32(dataRow["InputId"]);
            }
            //return countInputId = dsInput.Tables[0].Rows.Count - 1;
            return countInputId;
        }

        private int returnNewestFoodId()
        {
            DataSet dsFood = foodManagement.ViewFoods();
            foreach (DataRow dataRow in dsFood.Tables[0].Rows)
            {
                countFoodId = Convert.ToInt32(dataRow["FoodId"]);
            }
            //return countInputId = dsInput.Tables[0].Rows.Count - 1;
            return countFoodId;
        }

        private void btn_CreateTotalPriceAndInput_Click(object sender, EventArgs e)
        {
            int Quantity = int.Parse(txt_Quantity.Text.Trim());
            int Price = int.Parse(txt_Price.Text.Trim());
            int totalPrice = Quantity * Price;

            string selected = cb_StatusInputInfo.SelectedItem.ToString();


            Food food = new Food()
            {
                //FoodId = 0,
                DisplayNameFood = txt_namefood.Text,
                Quantity = int.Parse(txt_Quantity.Text),
                Image = rootPath + "/" + fileName,
                IDSuplier = int.Parse(cb_Suplier.SelectedValue.ToString()),
                StartDate = date_start.Value,
                EndDate = date_end.Value

            };
            int result = foodManagement.AddFood(food);
            if (result < 0)
            {
                MessageBox.Show("Fails");
            }
            else
            {
                returnNewestFoodId();

                
                Input newInput = new Input()
                {
                    DateInput = dt_InputDate.Value,
                    TotalPrice = totalPrice,
                    IdSuplier = int.Parse(cb_Suplier.SelectedValue.ToString())
                };
                int resultInput = inputManagement.AddInput(newInput);
                if (resultInput < 0)
                {
                    MessageBox.Show("Fail");
                }
                else
                {
                    txt_TotalPrice.Text = totalPrice.ToString() + " VND";
                    returnNewestInputId();

                    InputInfo newInputInfo = new InputInfo()
                    {
                        IdFood = countFoodId,
                        IdInput = countInputId,
                        CountInput = int.Parse(txt_Quantity.Text.Trim()),
                        InputPrice = float.Parse(txt_Price.Text.Trim()),
                        StatusInput = selected
                    };
                    int resultInputInfo = inputInfoManagement.AddInputInfo(newInputInfo);
                    if (resultInputInfo < 0)
                    {
                        MessageBox.Show("Fail");
                    }
                    else
                    {
                        frmFoodManagement1.loadFoodData();
                        frmFoodManagement1.loadInputData();

                        toolStripStatusLabel1.Text = "Save food sucessfully!";

                    }
                }

            }



        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic_Food.Image = new Bitmap(openFileDialog1.OpenFile());
                txt_PathFile.Text = openFileDialog1.FileName;
                toolStripStatusLabel1.Text = "open file ...";
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            try
            {
                fileName = openFileDialog1.SafeFileName;
                rootPath = @"../../upload";
                File.Copy(openFileDialog1.FileName, rootPath + "/" + fileName, true);
                toolStripStatusLabel1.Text = "Save file sucessfully!";
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
        }




        //
    }
}
