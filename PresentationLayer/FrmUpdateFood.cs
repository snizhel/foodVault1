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
    public partial class FrmUpdateFood : Form
    {

        FoodManagement foodManagement = new FoodManagement();

        private readonly FrmFoodManagement frmFoodManagement1;

        private static string fileName;
        private static string rootPath;


        public FrmUpdateFood(FrmFoodManagement frmFoodManagement)
        {
            InitializeComponent();
            frmFoodManagement1 = frmFoodManagement;

        }

        private void FrmUpdateFood_Load(object sender, EventArgs e)
        {
            loadFoodData();
        }

        private void loadFoodData()
        {
            SqlDataReader drFood = foodManagement.getDatails(FrmFoodManagement.foodId.ToString());
            if (drFood.Read())
            {
                pic_Food.Image = Image.FromFile(drFood.GetString(3));

                txt_idfood.Text = FrmFoodManagement.foodId.ToString();
                txt_namefood.Text = drFood.GetString(1);
                txt_quantity.Text = drFood.GetInt32(2).ToString();
                txt_FilePath.Text = drFood.GetString(3);
                txt_idsuplier.Text = drFood.GetInt32(4).ToString();
                date_start.Value = drFood.GetDateTime(5);
                date_end.Value = drFood.GetDateTime(6);


            }
            foodManagement.closeConnection();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Food food = new Food()
            {
                FoodId = FrmFoodManagement.foodId,
                DisplayNameFood = txt_namefood.Text.Trim(),
                Quantity = int.Parse(txt_quantity.Text.Trim()),
                Image = rootPath + "/" + fileName,
                IDSuplier = int.Parse(txt_idsuplier.Text.Trim()),
                StartDate = date_start.Value,
                EndDate = date_end.Value

            };
            int result = foodManagement.UpdateFood(food);
            if (result < 0)
            {
                toolStripStatusLabel1.Text = "Food have inventory!!!";
            }
            else
            {
                toolStripStatusLabel1.Text = "Update done !!!";
            }
            frmFoodManagement1.loadFoodData();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic_Food.Image = new Bitmap(openFileDialog1.OpenFile());
                txt_FilePath.Text = openFileDialog1.FileName;
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
    }
}
