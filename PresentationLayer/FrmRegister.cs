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
    public partial class FrmRegister : Form
    {
        UserManagement userManagement = new UserManagement();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                DisplayNameUser = txt_displayUserName.Text,
                UserName = txt_username.Text,
                PassWord = txt_password.Text,
                IdRole=2

            };
            if (txt_confirmPasssword.Text == txt_password.Text)
            {
                if (userManagement.registerUser(user))
                {
                    MessageBox.Show("Đăng ký thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
            }


        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
