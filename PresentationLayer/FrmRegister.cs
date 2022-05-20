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

        private void txt_displayUserName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_displayUserName.Text))
            {
                errorProvider1.SetError(txt_displayUserName, "FullName is not left blank!");
            }
            else if (userManagement.isExistdisplayUserName(txt_displayUserName.Text))
            {
                errorProvider1.SetError(txt_displayUserName, "FullName existed!!!");
            }
            else
            {
                errorProvider1.SetError(txt_displayUserName, null);
                e.Cancel = false;
            }
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_username.Text))
            {
                errorProvider1.SetError(txt_username, "UserName is not left blank!");
            }
            else if (userManagement.isExistUserName(txt_username.Text))
            {
                errorProvider1.SetError(txt_username, "UserName existed!!!");
            }
            else
            {
                errorProvider1.SetError(txt_username, null);
                e.Cancel = false;
            }
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_password.Text))
            {
                errorProvider1.SetError(txt_password, "Password is not left blank!");
            }
            else if (txt_password.Text.Trim().Length < 6)
            {
                errorProvider1.SetError(txt_password, "at least 6 characters");

            }
            else
            {
                errorProvider1.SetError(txt_password, null);
                e.Cancel = false;
            }
        }

        private void txt_confirmPasssword_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (string.IsNullOrEmpty(txt_confirmPasssword.Text))
            {
                errorProvider1.SetError(txt_confirmPasssword, "Password is not left blank!");
            }
            else if (txt_confirmPasssword.Text.Trim().Length < 6)
            {
                errorProvider1.SetError(txt_confirmPasssword, "at least 6 characters");

            }
            else
            {
                errorProvider1.SetError(txt_confirmPasssword, null);
                e.Cancel = false;
            }
        }
    }
}
