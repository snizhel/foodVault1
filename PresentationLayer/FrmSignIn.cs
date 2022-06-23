using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.ComponentModel;
using System.Drawing;
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
        private void btn_login_Click_1(object sender, EventArgs e)
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
        private void btn_navigateRegister_Click_1(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
        }

        private void txt_userName_Validating(object sender, CancelEventArgs e)
        {

            //if (string.IsNullOrEmpty(txt_userName.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txt_userName, "Username is not left blank!");
            //}
            //else
            //{
            //    errorProvider1.SetError(txt_userName, null);
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_userName_Click(object sender, EventArgs e)
        {
            txt_userName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txt_userName.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void txt_userName_Enter(object sender, EventArgs e)
        {
            if (txt_userName.Text == "User Name")
            {
                txt_userName.Text = "";

                txt_userName.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void txt_userName_Leave(object sender, EventArgs e)
        {
            if (txt_userName.Text == "")
            {
                txt_userName.Text = "User Name";

                txt_userName.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";

                txt_password.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";

                txt_password.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }
    }
}
