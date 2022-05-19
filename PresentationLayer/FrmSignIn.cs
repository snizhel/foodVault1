using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmSignIn : Form
    {
        UserManagement userManagement = new UserManagement();
        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                UserName = txt_userName.Text,
                PassWord = txt_password.Text
            };
            if (userManagement.loginUser(user))
            {
                FrmFoodManagement frmMain = new FrmFoodManagement();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }


        }
            
        

        private void FrmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_navigateRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            //this.Hide();
            
        }
    }
}
