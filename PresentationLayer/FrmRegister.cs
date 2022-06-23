using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.ComponentModel;
using System.Drawing;
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

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            User user = new User()
            {
                DisplayNameUser = txt_displayUserName.Text,
                UserName = txt_username.Text,
                PassWord = txt_password.Text,
                IdRole = 2

            };
            if (txt_confirmPasssword.Text == txt_password.Text)
            {
                if (userManagement.registerUser(user))
                {
                    MessageBox.Show("Đăng ký thành công");
                    FrmSignIn frmSignIn = new FrmSignIn();
                    frmSignIn.Show();
                    this.Hide();


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

            //if (string.IsNullOrEmpty(txt_displayUserName.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txt_displayUserName, "FullName is not left blank!");
            //}

            //else
            //{
            //    errorProvider1.SetError(txt_displayUserName, null);
            //    e.Cancel = false;
            //}
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {

            //if (string.IsNullOrEmpty(txt_username.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txt_username, "UserName is not left blank!");
            //}
            //else if (userManagement.isExistUserName(txt_username.Text))
            //{
            //    errorProvider1.SetError(txt_username, "UserName existed!!!");
            //}
            //else
            //{
            //    errorProvider1.SetError(txt_username, null);
            //    e.Cancel = false;
            //}
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {

            //if (string.IsNullOrEmpty(txt_password.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txt_password, "Password is not left blank!");
            //}
            //else if (txt_password.Text.Trim().Length < 6)
            //{
            //    errorProvider1.SetError(txt_password, "at least 6 characters");

            //}
            //else
            //{
            //    errorProvider1.SetError(txt_password, null);
            //    e.Cancel = false;
            //}
        }

        private void txt_confirmPasssword_Validating(object sender, CancelEventArgs e)
        {

            //if (string.IsNullOrEmpty(txt_confirmPasssword.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txt_confirmPasssword, "Password is not left blank!");
            //}
            //else if (txt_confirmPasssword.Text.Trim().Length < 6)
            //{
            //    errorProvider1.SetError(txt_confirmPasssword, "at least 6 characters");
            //    e.Cancel = false;
            //}
            //else
            //{
            //    errorProvider1.SetError(txt_confirmPasssword, null);
            //    e.Cancel = false;
            //}
        }

        private void txt_displayUserName_Enter(object sender, EventArgs e)
        {
            if (txt_displayUserName.Text == "Full Name")
            {
                txt_displayUserName.Text = "";

                txt_displayUserName.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }
        private void txt_displayUserName_Leave(object sender, EventArgs e)
        {
            if (txt_displayUserName.Text == "")
            {
                txt_displayUserName.Text = "Full Name";

                txt_displayUserName.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }
        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Account Name")
            {
                txt_username.Text = "";

                txt_username.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }
        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Account Name";

                txt_username.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void txt_password_Enter_1(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";

                txt_password.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void txt_password_Leave_1(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";

                txt_password.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void txt_confirmPasssword_Enter_1(object sender, EventArgs e)
        {
            if (txt_confirmPasssword.Text == "Confirm Password")
            {
                txt_confirmPasssword.Text = "";

                txt_confirmPasssword.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void txt_confirmPasssword_Leave_1(object sender, EventArgs e)
        {
            if (txt_confirmPasssword.Text == "")
            {
                txt_confirmPasssword.Text = "Confirm Password";

                txt_confirmPasssword.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_loginNavigate_Click(object sender, EventArgs e)
        {
            FrmSignIn frmSignIn = new FrmSignIn();
            frmSignIn.Show();
            this.Hide();
        }
    }
}
